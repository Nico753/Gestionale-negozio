using Negozio.Controllers;
using Negozio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.View.UC
{
    public partial class FrmAggiuntaArticolo : UserControl
    {
        Random rnd = new Random();
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        GestoreRegex gestoreRegex = new GestoreRegex();
        GestoreDelegate gestoreDelegate = new GestoreDelegate();
        public FrmAggiuntaArticolo(GestoreDelegate _gestoreDelegate)
        {
            InitializeComponent();
            CaricaCmb();
            gestoreDelegate = _gestoreDelegate;
        }

        private void CaricaCmb()
        {
            try
            {
                CmbFornitori.DataSource = DbNegozio.OttieniTuttiIFornitori().OrderBy(x => x.NomeAzienda).ToList();
                CmbFornitori.ValueMember = "IdFornitore";
                CmbFornitori.DisplayMember = "NomeAzienda";
                CmbFornitori.SelectedIndex = -1;
                CmbFornitori.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbFornitori.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
                CmbFornitori.SelectedIndexChanged += CmbFornitori_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbFornitori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fornitore f = DbNegozio.OttieniFornitore(CmbFornitori.SelectedValue.ToString());
            TxtCategoria.Text = f.TipoFornimento;
        }

        private void BtnAggiungiArticolo_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCampi();
                string codiceArticolo = GeneraId("A");
                string immagine = null;

                if (TxtPath.Text.Trim() != "")
                {
                    string sourcePath = TxtPath.Text;
                    string estensione = Path.GetExtension(sourcePath);
                    string fileName = "Img" + codiceArticolo + estensione;

                    string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string destinationFolder = Path.Combine(projectRoot, "img", "DbImage");
                    string destinationPath = Path.Combine(destinationFolder, fileName);

                    if (!Directory.Exists(destinationFolder))
                        Directory.CreateDirectory(destinationFolder);

                    File.Copy(sourcePath, destinationPath, overwrite: true);

                    immagine = Path.Combine("img", "DbImage", fileName);
                }

                DbNegozio.AggiungiArticolo(codiceArticolo, CmbFornitori.SelectedValue.ToString(), TxtDescrizione.Text, (double)NudPrezzo.Value, (int)NudQuantita.Value, (int)NudIva.Value, TxtCategoria.Text, immagine);
                gestoreDelegate.NotificaArticoloEvidenziato(codiceArticolo);
                MessageBox.Show("Articolo aggiunto con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PulisciCampi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GeneraId(string codice)
        {
            string identificativo = codice;
            do
            {
                for (int i = 0; i < 4; i++)
                    identificativo += rnd.Next(0, 10).ToString();
            } while (DbNegozio.VerificaIdUnivoco(identificativo, "Articolo"));

            return identificativo;
        }

        private void PulisciCampi()
        {
            TxtDescrizione.Clear();
            TxtDescrizione.BackColor = Color.White;
            TxtCategoria.Clear();
            TxtCategoria.BackColor = Color.White;
            CmbFornitori.SelectedIndexChanged -= CmbFornitori_SelectedIndexChanged;
            CmbFornitori.SelectedIndex = -1;
            CmbFornitori.SelectedIndexChanged += CmbFornitori_SelectedIndexChanged;
            NudPrezzo.Value = 1;
            NudIva.Value = 22;
            NudQuantita.Value = 1;
            TxtPath.Clear();
        }

        private void VerificaCampi()
        {
            if (!gestoreRegex.RegexMatch(TxtDescrizione.Text, @"^[a-zA-Z ']{2,}$"))
                throw new Exception("Campo descrizione non valido");
            if (CmbFornitori.SelectedIndex == -1)
                throw new Exception("Selezionare un fornitore perfavore");
        }

        private void TxtDescrizione_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexNome(TxtDescrizione);
        }

        private void BtnPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.Title = "Seleziona un'immagine";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    TxtPath.Text = ofd.FileName;
                }

            }
        }
    }
}
