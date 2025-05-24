using Negozio.Controllers;
using Negozio.Models;
using Negozio.View.UC;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Negozio.View
{
    public partial class FrmAdmin : Form
    {
        Utente utente;
        Guna2GradientButton btnPrecedente;
        readonly GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        readonly GestoreDelegate gestoreDelegate = new GestoreDelegate();
        string GestioneCorrente;

        public FrmAdmin(Utente _utente)
        {
            InitializeComponent();

            gestoreDelegate.OnPasswordReimpostata += DefaultPanBody;

            SetupInitialUI(_utente);
        }

        private void SetupInitialUI(Utente _utente)
        {
            utente = _utente;
            lblUsername.Text = $"Accesso effettuato come {utente.Username}";

            PanBody.Controls.Clear();
            PanBody.Controls.Add(new FrmGestioneAdmin(gestoreDelegate, "Fornitori"));
            GestioneCorrente = "Fornitori";
            PanBody.BringToFront();

            btnPrecedente = BtnFornitori;
            ColoreAttivato(BtnFornitori);

            Color backColor = Color.FromArgb(18, 18, 18);
            PanBar.BackColor = backColor;
            PanBody.BackColor = backColor;
            PanMenu.BackColor = backColor;

            if ((utente as Admin).Livello == 2)
            {
                BtnCommessi.Enabled = true;

                CambiaVista(BtnCommessi, new FrmGestioneAdmin(gestoreDelegate, "Commessi"), "Commessi");
            }
            else if ((utente as Admin).Livello == 3)
            {
                BtnCommessi.Enabled = true;
                BtnAdmin.Enabled = true;
                CambiaVista(BtnCommessi, new FrmGestioneAdmin(gestoreDelegate, "Commessi"), "Commessi");
            }
        }

        private void TxtRicerca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtRicerca.Text.Trim().Length < 3)
                {
                    gestoreDelegate.NotificaAggiornamentoDati();
                    return;
                }

                string testoCercato = TxtRicerca.Text.ToLower();

                switch (GestioneCorrente)
                {
                    case "Commessi":
                        List<Commesso> commessi = DbNegozio.RicercaInDbCommessi(testoCercato);
                        gestoreDelegate.NotificaCommessiModificati(commessi);
                        break;

                    case "Fornitori":
                        List<Fornitore> fornitori = DbNegozio.RicercaInDbFornitori(testoCercato);
                        gestoreDelegate.NotificaFornitoriModificati(fornitori);
                        break;

                    case "Magazzino":
                        List<Articolo> articoli = DbNegozio.RicercaInDbArticoli(testoCercato);
                        gestoreDelegate.NotificaArticoliModificati(articoli);
                        break;

                    case "Clienti":
                        List<Cliente> clienti = DbNegozio.RicercaInDbClienti(testoCercato);
                        gestoreDelegate.NotificaClientiModificati(clienti);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Sei sicuro di voler uscire?", "ATTENZIONE",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }


        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnReimpostaPassword_Click(object sender, EventArgs e)
        {
            CambiaVista(BtnReimpostaPassword, new FrmReimpostaPassword(utente, gestoreDelegate));
        }
        private void BtnCommessi_Click(object sender, EventArgs e)
        {
            CambiaVista(BtnCommessi, new FrmGestioneAdmin(gestoreDelegate, "Commessi"), "Commessi");
        }
        private void BtnFornitori_Click(object sender, EventArgs e)
        {
            CambiaVista(BtnFornitori, new FrmGestioneAdmin(gestoreDelegate, "Fornitori"), "Fornitori");
        }
        private void BtnClienti_Click(object sender, EventArgs e)
        {
            CambiaVista(BtnClienti, new FrmGestioneAdmin(gestoreDelegate, "Clienti"), "Clienti");
        }
        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            CambiaVista(BtnAdmin, new FrmGestioneAdmin(gestoreDelegate, "Admin"), "Admin");
        }
        private void BtnMagazzino_Click(object sender, EventArgs e)
        {
            if (DbNegozio.OttieniTuttiIFornitori().Count == 0)
            {
                MessageBox.Show(
                    "Prima di inserire articoli è necessario aggiungere fornitori",
                    "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);

                BtnFornitori_Click(sender, e);
                return;
            }

            CambiaVista(BtnMagazzino, new FrmGestioneAdmin(gestoreDelegate, "Magazzino"), "Magazzino");
        }
        private void BtnReport_Click(object sender, EventArgs e)
        {
            FrmReport frm = new FrmReport();
            if (frm.ShowDialog() == DialogResult.Cancel)
                MessageBox.Show("Operazione annullata", "Operazione annullata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Operazione completata con successo", "Operazione completata", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DefaultPanBody()
        {
            CambiaVista(BtnCommessi, new FrmGestioneAdmin(gestoreDelegate, "Commessi"), "Commessi");
        }

        private void CambiaVista(Guna2GradientButton btn, UserControl control, string gestione = "")
        {
            ColoreDisattivato(btnPrecedente);
            btnPrecedente = btn;
            ColoreAttivato(btn);

            TxtRicerca.Clear();
            PanBody.Controls.Clear();
            PanBody.Controls.Add(control);
            PanBody.BringToFront();

            GestioneCorrente = gestione;
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
