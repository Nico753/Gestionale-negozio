using Negozio.Controllers;
using Negozio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Negozio.View
{
    public partial class FrmReport : Form
    {
        GestoreDbNegozio dbNegozio = new GestoreDbNegozio();
        OpenXml openXml = new OpenXml();
        string folderPath;
        public FrmReport()
        {
            InitializeComponent();
            CaricaCmb();
            NudAnno.Maximum = DateTime.Now.Year;
            NudAnno.Value = DateTime.Now.Year;
        }

        private void CaricaCmb()
        {
            string[] mesi = {
                "Gennaio",
                "Febbraio",
                "Marzo",
                "Aprile",
                "Maggio",
                "Giugno",
                "Luglio",
                "Agosto",
                "Settembre",
                "Ottobre",
                "Novembre",
                "Dicembre"
            };

            for (int i = 0; i < mesi.Length; i++)
            {
                CmbMesi.Items.Add(mesi[i]);
            }

            CmbMesi.SelectedItem = mesi[DateTime.Now.Month - 1];
        }


        private void FrmReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog dbD = new FolderBrowserDialog
                {
                    Description = "Seleziona la cartella di destinazione del salvataggio della fattura"
                };
                if (dbD.ShowDialog() == DialogResult.OK)
                {
                    folderPath = dbD.SelectedPath + "\\Report";
                    TxtPath.Text = folderPath;
                    BtnSalvaReport.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAnnulla_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler annullare ?", "ATTENZIONE",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnSalvaReport_Click(object sender, EventArgs e)
        {
            int mese = CmbMesi.SelectedIndex + 1;
            int anno = (int)NudAnno.Value;

            Thread t = new Thread(() => AvviaSalvataggio(mese, anno));
            t.Start();
        }

        private void AvviaSalvataggio(int mese, int anno)
        {
            try
            {
                // Recupero dati dal database
                List<Cliente> lstClienti = dbNegozio.OttieniClientiDelMese(mese, anno);
                List<Commesso> lstCommessi = dbNegozio.OttieniCommessiDelMese(mese, anno);
                List<Articolo> lstArticoliInEsaurimento = dbNegozio.OttieniTuttiGliArticoliInEsaurimento();
                List<Fattura> totaleFatture = dbNegozio.OttieniFattureDelMese(mese, anno);

                string nomeMese = new DateTime(anno, mese, 1)
                    .ToString("MMMM", new CultureInfo("it-IT"));

                string nomeReport = $"Report_{nomeMese}_{anno}.docx";

                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string filePath = Path.Combine(folderPath, nomeReport);
                string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "template_report.docx");

                if (File.Exists(filePath))
                    File.Delete(filePath);

                File.Copy(templatePath, filePath);

                openXml.StampaReport(
                    lstClienti,
                    lstCommessi,
                    lstArticoliInEsaurimento,
                    totaleFatture,
                    nomeMese,
                    anno,
                    filePath
                );
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    MessageBox.Show("Errore durante la generazione del report:\n" + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }
    }
}
