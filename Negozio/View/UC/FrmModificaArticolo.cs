using Negozio.Controllers;
using Negozio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.View.UC
{
    public partial class FrmModificaArticolo : UserControl
    {
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        GestoreRegex gestoreRegex = new GestoreRegex();
        GestoreDelegate gestoreDelegate = new GestoreDelegate();

        string OldPath;
        public FrmModificaArticolo(GestoreDelegate _gestoreDelegate, string dgvSelectedCodiceArticolo)
        {
            InitializeComponent();
            gestoreDelegate = _gestoreDelegate;
            CaricaCmb();
            if (dgvSelectedCodiceArticolo != null)
            {
                CmbArticoli.SelectedValue = dgvSelectedCodiceArticolo;
                CaricaCampi(dgvSelectedCodiceArticolo);
            }
        }

        private void CaricaCmb()
        {
            try
            {
                CmbArticoli.SelectedIndexChanged -= CmbArticoli_SelectedIndexChanged;
                List<Articolo> listaArticoli = DbNegozio.OttieniTuttiGliArticoli();
                listaArticoli = listaArticoli.OrderBy(x => x.DescrizioneArticolo).ToList();

                CmbArticoli.DataSource = listaArticoli;
                CmbArticoli.ValueMember = "CodiceArticolo";
                CmbArticoli.DisplayMember = "DescrizioneArticolo";

                CmbArticoli.SelectedIndex = -1;
                CmbArticoli.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbArticoli.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;

                CmbFornitori.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbFornitori.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;

                CmbArticoli.SelectedIndexChanged += CmbArticoli_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CaricaCampi(string dgvSelectedCodiceArticolo)
        {
            Articolo a = DbNegozio.OttieniArticolo(dgvSelectedCodiceArticolo);
            TxtDescrizione.Text = a.DescrizioneArticolo;
            TxtCategoria.Text = a.Categoria;
            CmbFornitori.SelectedValue = a.IdFornitore;
            NudIva.Value = a.Iva;
            NudPrezzo.Value = (decimal)a.PrezzoArticolo;
            if (a.Immagine != null)
            {
                TxtPath.Text = a.Immagine;
                OldPath = a.Immagine;
            }
        }

        private void CmbArticoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            GbFornitore.Enabled = true;
            GbListaArticoli.Enabled = true;
            GbDescrizioneArticolo.Enabled = true;
            GbFornitore.Enabled = true;
            GbImmagineProdotto.Enabled = true;
            GbInformazioniArticolo.Enabled = true;
            List<Fornitore> listaFornitori = DbNegozio.OttieniTuttiIFornitori();
            listaFornitori = listaFornitori.Where(x => x.TipoFornimento == DbNegozio.OttieniArticolo(CmbArticoli.SelectedValue.ToString()).Categoria).ToList();
            CmbFornitori.DataSource = listaFornitori;
            CmbFornitori.ValueMember = "IdFornitore";
            CmbFornitori.DisplayMember = "NomeAzienda";
            CaricaCampi(CmbArticoli.SelectedValue.ToString());
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCampi();

                string immagine = null;

                if (TxtPath.Text.Trim() != "")
                {
                    string sourcePath = TxtPath.Text;
                    string estensione = Path.GetExtension(sourcePath);
                    string fileBase = "Img" + CmbArticoli.SelectedValue.ToString();
                    string fileName = fileBase + estensione;

                    string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                    string destinationFolder = Path.Combine(projectRoot, "img", "DbImage");
                    string destinationPath = Path.Combine(destinationFolder, fileName);

                    string[] estensioniPossibili = { ".jpg", ".jpeg", ".png", ".bmp", ".gif" };
                    foreach (string ext in estensioniPossibili)
                    {
                        string oldPath = Path.Combine(destinationFolder, fileBase + ext);
                        if (File.Exists(oldPath))
                            File.Delete(oldPath);
                    }

                    File.Copy(sourcePath, destinationPath, overwrite: true);

                    immagine = Path.Combine("img", "DbImage", fileName);
                }
                else
                {
                    EliminaImmagine(CmbArticoli.SelectedValue.ToString());
                }

                DbNegozio.ModificaArticolo(CmbArticoli.SelectedValue.ToString(), CmbFornitori.SelectedValue.ToString(), TxtDescrizione.Text, (double)NudPrezzo.Value, (int)NudIva.Value, TxtCategoria.Text, immagine);

                MessageBox.Show("Articolo modificato con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gestoreDelegate.NotificaArticoloEvidenziato(CmbArticoli.SelectedValue.ToString());
                PulisciCampi();
                CaricaCmb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void PulisciCampi()
        {
            TxtDescrizione.Clear();
            TxtDescrizione.BackColor = Color.White;
            TxtCategoria.Clear();
            TxtCategoria.BackColor = Color.White;
            CmbFornitori.SelectedIndex = -1;
            NudPrezzo.Value = 1;
            NudIva.Value = 22;
            TxtPath.Clear();
            NudQuantitaR.Value = 1;


            GbFornitore.Enabled = false;
            GbListaArticoli.Enabled = false;
            GbDescrizioneArticolo.Enabled = false;
            GbFornitore.Enabled = false;
            GbImmagineProdotto.Enabled = false;
            GbInformazioniArticolo.Enabled = false;
        }

        private void VerificaCampi()
        {
            if (!gestoreRegex.RegexMatch(TxtDescrizione.Text, @"^[a-zA-Z ']{2,}$"))
                throw new Exception("Campo articolo non valido");
            if (!gestoreRegex.RegexMatch(TxtCategoria.Text, @"^[A-Za-zÀ-ÿ0-9,\'\-&\s]{2,}$"))
                throw new Exception("Campo categoria non valido");
        }

        private void TxtCategoria_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexTipologia(TxtCategoria);
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

        private void BtnRimuoviImmagine_Click(object sender, EventArgs e)
        {
            TxtPath.Clear();
        }

        private void TxtDescrizione_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexNome(TxtDescrizione);
        }

        private void BtnRifornisci_Click(object sender, EventArgs e)
        {
            try
            {
                DbNegozio.RifornisciMagazzino(CmbArticoli.SelectedValue.ToString(), (int)NudQuantitaR.Value);
                MessageBox.Show("Magazzino rifornito con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gestoreDelegate.NotificaArticoloEvidenziato(CmbArticoli.SelectedValue.ToString());
                PulisciCampi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
