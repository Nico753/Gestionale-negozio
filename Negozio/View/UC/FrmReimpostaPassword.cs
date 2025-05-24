using Negozio.Controllers;
using Negozio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.View.UC
{
    public partial class FrmReimpostaPassword : UserControl
    {
        GestoreDbNegozio dbNegozio = new GestoreDbNegozio();
        Utente utenteLoggato;
        GestoreRegex gestoreRegex = new GestoreRegex();
        GestoreDelegate gestoreDelegate;
        public FrmReimpostaPassword(Utente utente, GestoreDelegate _gestoreDelegate)
        {
            InitializeComponent();
            utenteLoggato = utente;
            gestoreDelegate = _gestoreDelegate;
        }

        private void BtnModificaPassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtConferma.Text == "" || TxtNuovaPassword.Text == "" || TxtPrecedente.Text == "")
                    throw new Exception("Compila tutti i campi");
                if (TxtConferma.Text != TxtNuovaPassword.Text)
                    throw new Exception("Le password non coincidono");
                if (TxtPrecedente.FillColor == Color.Red)
                    throw new Exception("Nuova password non valida deve contenre :\n1 carattere maiuscolo\n1 carattere minuscolo\n1 carattere speciale\n1 numero\n8 caratteri totali");

                dbNegozio.ModificaPassword(TxtNuovaPassword.Text, TxtPrecedente.Text, utenteLoggato);
                MessageBox.Show("Password Modificata con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPrecedente.Clear();
                TxtConferma.Clear();
                TxtPrecedente.Clear();

                TxtPrecedente.FillColor = Color.White;
                TxtConferma.FillColor = Color.White;
                gestoreDelegate.NotificaPasswordReimpostata();

                this.BackColor = Color.FromArgb(18, 18, 18);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CbPrecedente_CheckedChanged(object sender, EventArgs e)
        {
            if (CbPrecedente.Checked)
            {
                TxtPrecedente.UseSystemPasswordChar = false;
                CbPrecedente.Text = "Nascondi Password";
            }
            else
            {
                TxtPrecedente.UseSystemPasswordChar = true;
                CbPrecedente.Text = "Mostra Password";
            }
        }

        private void CbNuova_CheckedChanged(object sender, EventArgs e)
        {
            if (CbNuova.Checked)
            {
                TxtNuovaPassword.UseSystemPasswordChar = false;
                CbNuova.Text = "Nascondi Password";
            }
            else
            {
                TxtNuovaPassword.UseSystemPasswordChar = true;
                CbNuova.Text = "Mostra Password";
            }
        }

        private void CbConferma_CheckedChanged(object sender, EventArgs e)
        {
            if (CbConferma.Checked)
            {
                TxtConferma.UseSystemPasswordChar = false;
                CbConferma.Text = "Nascondi Password";
            }
            else
            {
                TxtConferma.UseSystemPasswordChar = true;
                CbConferma.Text = "Mostra Password";
            }
        }

        private void TxtConferma_TextChanged(object sender, EventArgs e)
        {
            if (TxtConferma.Text != TxtNuovaPassword.Text)
                TxtConferma.FillColor = Color.Red;
            else
                TxtConferma.FillColor = Color.LightGreen;
        }

        private void TxtNuovaPassword_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexPassword(TxtNuovaPassword);

            if (TxtConferma.Text.Trim() == "")
            {
                TxtConferma.FillColor = Color.White;
            }
            else if (TxtConferma.Text != TxtNuovaPassword.Text)
            {
                TxtConferma.FillColor = Color.Red;
            }
            else
            {
                TxtConferma.FillColor = Color.LightGreen;
            }
        }
    }
}
