using Negozio.Controllers;
using Negozio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.View.UC
{
    public partial class FrmEliminaArticolo : UserControl
    {
        GestoreDelegate gestoreDelegate = new GestoreDelegate();
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        public FrmEliminaArticolo(GestoreDelegate _gestoreDelegate)
        {
            InitializeComponent();
            CaricaCmb();
            gestoreDelegate = _gestoreDelegate;
            GbQuantita.Enabled = false;
        }

        private void CaricaCmb()
        {
            try
            {
                CmbArticoli.SelectedIndexChanged -= CmbArticoli_SelectedIndexChanged;
                CmbArticoli.DataSource = DbNegozio.OttieniTuttiGliArticoli().OrderBy(x => x.DescrizioneArticolo).ToList();
                CmbArticoli.DisplayMember = "DescrizioneArticolo";
                CmbArticoli.ValueMember = "CodiceArticolo";
                CmbArticoli.SelectedIndex = -1;
                CmbArticoli.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbArticoli.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
                CmbArticoli.SelectedIndexChanged += CmbArticoli_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbArticoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            Articolo a = DbNegozio.OttieniArticolo(CmbArticoli.SelectedValue.ToString());
            GbQuantita.Enabled = true;
            NudQuantita.Maximum = a.Quantita;
            NudQuantita.Minimum = 1;
            NudQuantita.Value = 1;
        }
        private void EliminaImmagine(string articoloId)
        {
            try
            {
                string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string destinationFolder = Path.Combine(projectRoot, "img", "DbImage");

                string fileBase = "Img" + articoloId;

                string[] estensioniPossibili = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };

                foreach (string ext in estensioniPossibili)
                {
                    string oldPath = Path.Combine(destinationFolder, fileBase + ext);

                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'eliminazione delle immagini: " + ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                Articolo a = DbNegozio.OttieniArticolo(CmbArticoli.SelectedValue.ToString());
                int quantita = (int)NudQuantita.Value;
                if (quantita == a.Quantita)
                {
                    if (MessageBox.Show("Sei sicuro di voler eliminare l'articolo selezionato ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                        throw new Exception("Operazione annullata");
                    DbNegozio.EliminaArticolo(a.CodiceArticolo);
                    MessageBox.Show("Articolo eliminato con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DbNegozio.EliminaQuantitaArticolo(a.CodiceArticolo, a.Quantita - quantita);
                    MessageBox.Show("Quantità articolo eliminata con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                EliminaImmagine(CmbArticoli.SelectedValue.ToString());
                GbQuantita.Enabled = false;
                NudQuantita.Value = 1;
                CaricaCmb();
                gestoreDelegate.NotificaAggiornamentoDati();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnMAX_Click(object sender, EventArgs e)
        {
            Articolo a = DbNegozio.OttieniArticolo(CmbArticoli.SelectedValue.ToString());
            NudQuantita.Value = a.Quantita;
        }
    }
}
