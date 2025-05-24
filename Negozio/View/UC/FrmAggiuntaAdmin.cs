using Negozio.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.View.UC
{
    public partial class FrmAggiuntaAdmin : UserControl
    {
        // VARIABILI GLOBALI
        GestoreDbNegozio dbNegozio = new GestoreDbNegozio();
        GestoreRegex gestoreRegex = new GestoreRegex();
        GestoreDelegate gestoreDelegate;
        public FrmAggiuntaAdmin(GestoreDelegate _gestoreDelegate)
        {
            InitializeComponent();
            gestoreDelegate = _gestoreDelegate;
        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCampi();
                dbNegozio.AggiungiAdmin(TxtNome.Text, TxtCognome.Text, TxtEmail.Text, TxtPassword.Text, TxtUsername.Text, 1);
                PulisciCampi();
                MessageBox.Show("Admin aggiunto con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gestoreDelegate.NotificaAdminEvidenziato(TxtUsername.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PulisciCampi()
        {
            TxtNome.Clear();
            TxtCognome.Clear();
            TxtUsername.Clear();
            TxtPassword.Clear();
            TxtEmail.Clear();

            TxtNome.BackColor = Color.White;
            TxtCognome.BackColor = Color.White;
            TxtEmail.BackColor = Color.White;
            TxtUsername.BackColor = Color.White;
        }

        private void VerificaCampi()
        {
            string nome = TxtNome.Text;
            string cognome = TxtCognome.Text;
            string email = TxtEmail.Text;
            string username = TxtUsername.Text;
            string password = TxtPassword.Text;

            string patternPassword = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$";
            string patternNome = @"^[a-zA-Z ']{2,}$";
            string patternCognome = @"^[a-zA-Z ']{2,}$";
            string patternEmail = @"^[\w\.-]+@[\w\.-]+\.[a-zA-Z]{2,}$";
            string patternUsername = @"^[a-zA-Z0-9_]{4,20}$";

            if (!string.IsNullOrEmpty(nome))
                if (!gestoreRegex.RegexMatch(nome, patternNome))
                    throw new Exception("Nome non valido");
            if (!string.IsNullOrEmpty(cognome))
                if (!gestoreRegex.RegexMatch(cognome, patternCognome))
                    throw new Exception("Cognome non valido");
            if (!gestoreRegex.RegexMatch(email, patternEmail))
                throw new Exception("Email non valida");
            if (!gestoreRegex.RegexMatch(username, patternUsername))
                throw new Exception("Username non valido");
            if (!gestoreRegex.RegexMatch(password, patternPassword))
                throw new Exception("Campo password non valida");
        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexNome(TxtNome);
        }

        private void TxtCognome_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexCognome(TxtCognome);
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexEmail(TxtEmail);
        }

        private void TxtUsername_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexUsername(TxtUsername);
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexPassword(TxtPassword);
        }

        private void CbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CbPassword.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
