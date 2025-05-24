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
    public partial class FrmModificaCommesso : UserControl
    {
        GestoreRegex gestoreRegex = new GestoreRegex();
        GestoreDelegate gestoreDelegate;
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        public FrmModificaCommesso(GestoreDelegate DELEGATE, string dgvSelectedUsername)
        {
            InitializeComponent();
            gestoreDelegate = DELEGATE;
            CaricaCmb();
            if (dgvSelectedUsername != null)
            {
                CmbCommessi.SelectedValue = dgvSelectedUsername;
                CaricaCampi(dgvSelectedUsername);
            }
        }

        private void CaricaCampi(string dgvSelectedUsername)
        {
            try
            {
                Commesso c = DbNegozio.OttieniCommesso(dgvSelectedUsername);
                TxtNome.Text = c.Nome;
                TxtCognome.Text = c.Cognome;
                TxtEmail.Text = c.Email;
                DtoraInizio.Value = DateTime.Now.Date.Add(c.OraInizioTurno);
                DtoraFine.Value = DateTime.Now.Date.Add(c.OraFineTurno);
                DtpAssunzione.Value = c.DataAssunzione;
                CmbTurni.SelectedItem = c.Turno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CaricaCmb()
        {
            try
            {
                CmbCommessi.SelectedIndexChanged -= CmbCommessi_SelectedIndexChanged;
                List<Commesso> lstCommessi = DbNegozio.OttieniTuttiICommessi();
                lstCommessi.OrderBy(x => x.Username).ToList();
                CmbCommessi.DataSource = lstCommessi;
                CmbCommessi.DisplayMember = "Username";
                CmbCommessi.ValueMember = "Username";
                CmbCommessi.SelectedIndex = -1;
                CmbCommessi.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbCommessi.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
                CmbCommessi.SelectedIndexChanged += CmbCommessi_SelectedIndexChanged;

                string[] turni = { "MATTINA", "POMERIGGIO", "NOTTE" };
                foreach (string tiplogia in turni)
                {
                    CmbTurni.Items.Add(tiplogia);
                }
                CmbTurni.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbTurni.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCampi();
                DbNegozio.ModificaCommesso(CmbCommessi.SelectedValue.ToString(), TxtNome.Text, TxtCognome.Text, TxtEmail.Text, CmbTurni.SelectedItem.ToString(), DtpAssunzione.Value, DtoraInizio.Value, DtoraFine.Value);
                MessageBox.Show("Commesso modificato con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gestoreDelegate.NotificaCommessoEvidenziato(CmbCommessi.SelectedValue.ToString());
                CaricaCmb();
                PulisciCampi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PulisciCampi()
        {
            TxtNome.Clear();
            TxtNome.BackColor = Color.White;

            TxtCognome.Clear();
            TxtCognome.BackColor = Color.White;

            TxtEmail.Clear();
            TxtEmail.BackColor = Color.White;

            CmbTurni.SelectedIndex = -1;
            DtpAssunzione.Value = DateTime.Now;
            DtoraInizio.Value = DateTime.Now;
            DtoraFine.Value = DateTime.Now;

            GbNome.Enabled = false;
            GbCognome.Enabled = false;
            GbEmail.Enabled = false;
            GbInformazioni.Enabled = false;
        }

        private void VerificaCampi()
        {
            string nome = TxtNome.Text;
            string cognome = TxtCognome.Text;
            string email = TxtEmail.Text;

            string patternNome = @"^[a-zA-Z ']{2,}$";
            string patternCognome = @"^[a-zA-Z ']{2,}$";
            string patternEmail = @"^[\w\.-]+@[\w\.-]+\.[a-zA-Z]{2,}$";

            if (!string.IsNullOrEmpty(nome))
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

        private void CmbCommessi_SelectedIndexChanged(object sender, EventArgs e)
        {
            GbNome.Enabled = true;
            GbCognome.Enabled = true;
            GbEmail.Enabled = true;
            GbInformazioni.Enabled = true;
            CaricaCampi(CmbCommessi.SelectedValue.ToString());
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
    }
}
