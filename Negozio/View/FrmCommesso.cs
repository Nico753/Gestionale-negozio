using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using Negozio.Controllers;
using Negozio.Models;
using Negozio.View.UC;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Negozio.View
{
    public partial class FrmCommesso : Form
    {
        GestoreDelegate gestoreDelegate = new GestoreDelegate();
        GestoreCarrello gestoreCarrello = new GestoreCarrello();
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();

        Guna2GradientButton btnPrecedente;
        Guna2GradientButton btnPrimo = null;

        string codiceScannerizzato = "";
        Timer barcodeTimer;

        Utente utenteLoggato;
        string categoria;

        public FrmCommesso(Utente _utenteLoggato)
        {
            InitializeComponent();

            utenteLoggato = _utenteLoggato;
            lblUsername.Text = "Accesso effettuato come " + utenteLoggato.Username;

            SetupInitialUI();

            gestoreDelegate.OnPasswordReimpostata += AggiornaPanBody;
            gestoreDelegate.OnArticoloAggiuntoAlCarrello += AggiornaCarrello;
            this.KeyPreview = true;

            barcodeTimer = new Timer();
            barcodeTimer.Interval = 200;
            barcodeTimer.Tick += BarcodeTimer_Tick;

        }


        private void SetupInitialUI()
        {
            ImpostazioniPanel(PanCarrello);
            ImpostazioniPanel(PanCategorie);
            CaricaCategorie();

            gestoreCarrello.VisualizzaCarrelloVuoto(PanCarrello);

            PanCarrello.AutoScrollMinSize = new Size(0, 120);
            PanCategorie.BackColor = Color.FromArgb(18, 18, 18);
            PanBar.BackColor = Color.FromArgb(18, 18, 18);
            PanCarrello.BackColor = Color.FromArgb(18, 18, 18);
            PanTotale.BackColor = Color.FromArgb(18, 18, 18);
            PanBtnCassa.BackColor = Color.FromArgb(18, 18, 18);
            pictureBox1.BackColor = Color.FromArgb(18, 18, 18);
        }
        private void ImpostazioniPanel(Panel panel)
        {
            panel.HorizontalScroll.Visible = false;
            panel.HorizontalScroll.Enabled = false;
            panel.HorizontalScroll.Maximum = 0;
            panel.AutoScroll = true;

            if (panel.Name == "PanCategorie")
            {
                panel.RightToLeft = RightToLeft.Yes;
                panel.Scroll += (s, e) =>
                {
                    panel.RightToLeft = RightToLeft.Yes;
                    foreach (Control ctrl in panel.Controls)
                    {
                        ctrl.RightToLeft = RightToLeft.No;
                    }
                };
            }
        }
        private void CaricaCategorie()
        {
            try
            {
                PanCategorie.Controls.Clear();
                string[] categorie = DbNegozio.OttieniCategorie();
                int x = 7, y = 10;

                foreach (string categoria in categorie)
                {
                    Guna2GradientButton btn = new Guna2GradientButton
                    {
                        Cursor = Cursors.Hand,
                        Font = new Font("Segoe UI", 12, FontStyle.Bold),
                        Location = new Point(x, y),
                        ForeColor = Color.White,
                        Size = new Size(162, 62),
                        Name = "Btn" + categoria,
                        Text = categoria.ToUpper(),
                        BorderRadius = 6,
                        BorderThickness = 2,
                        BorderColor = Color.DimGray,
                        FillColor = Color.Black,
                        FillColor2 = Color.DimGray,
                        FocusedColor = Color.White
                    };

                    btn.Click += BtnModificaPandBody_Click;
                    PanCategorie.Controls.Add(btn);

                    if (btnPrimo == null)
                        btnPrimo = btn;

                    y += 70;
                }

                btnPrecedente = btnPrimo;
                BtnModificaPandBody_Click(btnPrimo, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AggiornaCarrello(string codiceArticolo)
        {
            gestoreCarrello.AggiungiAlCarrello(codiceArticolo, PanCarrello, LblTotale);
        }
        private void AggiornaPanBody()
        {
            BtnModificaPandBody_Click(btnPrimo, EventArgs.Empty);
        }

        private void BtnModificaPandBody_Click(object sender, EventArgs e)
        {
            Guna2GradientButton btn = (Guna2GradientButton)sender;
            categoria = btn.Text;

            ColoreAttivato(btn);
            ColoreDisattivato(btnPrecedente);
            btnPrecedente = btn;

            PanBody.Controls.Clear();
            PanBody.Controls.Add(new FrmArticoli(categoria, gestoreDelegate, null));
            PanBody.BringToFront();
        }

        private void BtnReimpostaPassword_Click(object sender, EventArgs e)
        {
            ColoreAttivato(BtnReimpostaPassword);
            ColoreDisattivato(btnPrecedente);
            btnPrecedente = BtnReimpostaPassword;

            PanBody.Controls.Clear();
            PanBody.Controls.Add(new FrmReimpostaPassword(utenteLoggato, gestoreDelegate));
            PanBody.BringToFront();
        }

        private void BtnCassa_Click(object sender, EventArgs e)
        {
            if (gestoreCarrello.carrello.Count <= 0)
            {
                MessageBox.Show("Il carrello non può essere vuoto", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            FrmCassa frm = new FrmCassa(gestoreCarrello);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.Abort)
            {
                foreach (var articolo in gestoreCarrello.carrello)
                {
                    if (articolo.Quantita <= 0)
                        DbNegozio.EliminaArticolo(articolo.CodiceArticolo);
                    else
                        DbNegozio.EliminaQuantitaArticolo(articolo.CodiceArticolo, gestoreCarrello.quantitaCarrello[articolo.CodiceArticolo]);
                }
                gestoreCarrello = new GestoreCarrello();
                PanCarrello.Controls.Clear();
                gestoreCarrello.VisualizzaCarrelloVuoto(PanCarrello);
                BtnModificaPandBody_Click(btnPrimo, EventArgs.Empty);
                LblTotale.Text = "TOTALE :";
                TxtRicerca.Clear();
            }
            else
            {
                PanCarrello.Controls.Clear();
                gestoreCarrello.RicaricaCarrello(PanCarrello);
            }
            this.Show();
        }

        private void TxtRicerca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtRicerca.Text.Trim().Length > 2)
                {

                    PanBody.Controls.Clear();
                    PanBody.Controls.Add(new FrmArticoli(null, gestoreDelegate, TxtRicerca.Text.ToLower()));
                    PanBody.BringToFront();
                }
                else if (TxtRicerca.Text.Trim().Length == 0)
                {
                    PanBody.Controls.Clear();
                    PanBody.Controls.Add(new FrmArticoli(categoria, gestoreDelegate, null));
                    PanBody.BringToFront();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BarcodeTimer_Tick(object sender, EventArgs e)
        {
            codiceScannerizzato = "";
            barcodeTimer.Stop();
        }
        private void FrmCommesso_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Menu)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (codiceScannerizzato.Length == 5)
                {
                    string codice = codiceScannerizzato.ToUpper();
                    try
                    {
                        if (codice.StartsWith("A"))
                        {
                            if (!DbNegozio.VerificaPresenzaArticolo(codice))
                                throw new Exception("Articolo non trovato");

                            AggiornaCarrello(codice);
                        }
                        else
                        {
                            if (gestoreCarrello.Cliente != null)
                                throw new Exception("Cliente già selezionato");
                            if (!DbNegozio.VerificaPresenzaCliente(codice))
                                throw new Exception("Cliente non trovato");

                            AggiornaCarrello(codice);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    codiceScannerizzato = "";
                }
            }
            else if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                codiceScannerizzato += (char)e.KeyCode;
                barcodeTimer.Stop();
                barcodeTimer.Start();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            gestoreDelegate.NotificaChiusuraFrmCommesso();
            this.Close();
        }
        private void FrmCommesso_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sei sicuro di voler uscire ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ColoreAttivato(Guna2GradientButton btn)
        {
            btn.FillColor = Color.Black;
            btn.FillColor2 = Color.DimGray;
            btn.BorderColor = Color.White;
        }
        private void ColoreDisattivato(Guna2GradientButton btn)
        {
            btn.FillColor = Color.Black;
            btn.FillColor2 = Color.DimGray;
            btn.BorderColor = Color.DimGray;
        }
    }
}