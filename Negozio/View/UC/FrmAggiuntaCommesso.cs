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
    public partial class FrmAggiuntaCommesso : UserControl
    {
        GestoreDelegate gestoreDelegate;
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        GestoreRegex gestoreRegex = new GestoreRegex();
        public FrmAggiuntaCommesso(GestoreDelegate DELEGATE)
        {
            InitializeComponent();
            CaricaCmb();
            gestoreDelegate = DELEGATE;
        }

        private void CaricaCmb()
        {
            string[] tipologie = { "MATTINA", "POMERIGGIO", "NOTTE" };
            foreach (string tiplogia in tipologie)
            {
                CmbTurni.Items.Add(tiplogia);
            }

            CmbTurni.SelectedIndex = 0;
            CmbTurni.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTurni.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCampi();
                DbNegozio.AggiungiCommesso(TxtNome.Text, TxtCognome.Text, TxtEmail.Text, TxtPassword.Text, TxtUsername.Text, CmbTurni.SelectedItem.ToString(), DtpAssunzione.Value.Date, DtoraInizio.Value.TimeOfDay, DtoraFine.Value.TimeOfDay);
                MessageBox.Show("Commesso aggiunto con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gestoreDelegate.NotificaCommessoEvidenziato(TxtUsername.Text);
                PulisciCampi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void PulisciCampi()
        {
            TxtNome.Clear();
            TxtUsername.Clear();
            TxtCognome.Clear();
            TxtUsername.Clear();
            TxtPassword.Clear();
            TxtEmail.Clear();
            CmbTurni.SelectedIndex = -1;
            DtpAssunzione.Value = DateTime.Now;
            DtoraInizio.Value = DateTime.Now;
            DtoraFine.Value = DateTime.Now;

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

            if(!string.IsNullOrEmpty(nome))
            if (!gestoreRegex.RegexMatch(nome, patternNome))
            {
                throw new Exception("Nome non valido");
            }
            if (!string.IsNullOrEmpty(cognome))
                if (!gestoreRegex.RegexMatch(cognome, patternCognome))
            {
                throw new Exception("Cognome non valido");
            }

            if (!gestoreRegex.RegexMatch(email, patternEmail))
            {
                throw new Exception("Email non valida");
            }

            if (!gestoreRegex.RegexMatch(username, patternUsername))
            {
                throw new Exception("Username non valido (min 4 caratteri, solo lettere/numeri/underscore)");
            }

            if (!gestoreRegex.RegexMatch(password, patternPassword))
            {
                throw new Exception("Password non valida. Deve contenere almeno:\n- 8 caratteri\n- 1 maiuscola\n- 1 minuscola\n- 1 numero\n- 1 simbolo");
            }

            TimeSpan oraInizio = DtoraInizio.Value.TimeOfDay;
            TimeSpan oraFine = DtoraFine.Value.TimeOfDay;

            switch (CmbTurni.SelectedItem.ToString())
            {
                case "MATTINA":
                    if (oraInizio.Hours < 6 || oraFine.Hours > 14 || oraFine <= oraInizio)
                        throw new Exception("Per il turno MATTINA, l'orario deve essere tra le 06:00 e le 14:00.");
                    break;

                case "POMERIGGIO":
                    if (oraInizio.Hours < 14 || oraFine.Hours > 22 || oraFine <= oraInizio)
                        throw new Exception("Per il turno POMERIGGIO, l'orario deve essere tra le 14:00 e le 22:00.");
                    break;

                case "NOTTE":
                    if (!(oraInizio.Hours >= 22 || oraInizio.Hours < 6) || !(oraFine.Hours >= 22 || oraFine.Hours < 6))
                        throw new Exception("Per il turno NOTTE, l'orario deve essere tra le 22:00 e le 06:00.");
                    break;
            }

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
