using Guna.UI2.WinForms;
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
    public partial class FrmModificaAdmin : UserControl
    {
        GestoreDelegate gestoreDelegate;
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        GestoreRegex gestoreRegex = new GestoreRegex();

        Guna2Button btnPrecedente;

        int btnlivello;
        public FrmModificaAdmin(GestoreDelegate _gestoreDelegate, string dgvUsernameAdmin)
        {
            InitializeComponent();
            gestoreDelegate = _gestoreDelegate;
            btnPrecedente = Btn1;
            CaricaCmb();
            if (dgvUsernameAdmin != null)
            {
                CmbAdmin.SelectedValue = dgvUsernameAdmin;
                CaricaCampi(dgvUsernameAdmin);
            }
        }

        private void CaricaCampi(string dgvUsernameAdmin)
        {
            try
            {
                Admin a = DbNegozio.OttieniAmministratore(dgvUsernameAdmin);
                TxtNome.Text = a.Nome;
                TxtEmail.Text = a.Email;
                TxtCognome.Text = a.Cognome;

                if (a.Livello == 1)
                {
                    btnlivello = 1;
                    Btn1.FillColor = Color.Black;
                    Btn1.ForeColor = Color.White;
                    Btn1.BorderColor = Color.White;
                    btnPrecedente = Btn1;
                }
                else if (a.Livello == 2)
                {
                    btnlivello = 2;
                    Btn2.FillColor = Color.Black;
                    Btn2.ForeColor = Color.White;
                    Btn2.BorderColor = Color.White;
                    btnPrecedente = Btn2;
                }
                else
                {
                    btnlivello = 3;
                    BtnLivello3.FillColor = Color.Black;
                    BtnLivello3.ForeColor = Color.White;
                    BtnLivello3.BorderColor = Color.White;
                    btnPrecedente = BtnLivello3;
                }
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
                CmbAdmin.SelectedIndexChanged -= CmbAdmin_SelectedIndexChanged;
                List<Admin> lstAdmin = DbNegozio.OttieniTuttiGliAmministratori();
                lstAdmin.OrderBy(x => x.Username).ToList();
                CmbAdmin.DataSource = lstAdmin;
                CmbAdmin.DisplayMember = "Username";
                CmbAdmin.ValueMember = "Username";
                CmbAdmin.SelectedIndex = -1;
                CmbAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbAdmin.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
                CmbAdmin.SelectedIndexChanged += CmbAdmin_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbAdmin.SelectedIndex != -1)
            {
                GbNome.Enabled = true;
                GbEmail.Enabled = true;
                GbCognome.Enabled = true;
                GbLivello.Enabled = true;
                CaricaCampi(CmbAdmin.SelectedValue.ToString());
            }
        }

        private void BtnModificaAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCampi();
                DbNegozio.ModificaAdmin(CmbAdmin.SelectedValue.ToString(), TxtNome.Text, TxtCognome.Text, TxtEmail.Text, btnlivello);
                MessageBox.Show("Admin modificato con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gestoreDelegate.NotificaAdminEvidenziato(CmbAdmin.SelectedValue.ToString());
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
            TxtCognome.Clear();
            TxtEmail.Clear();

            TxtNome.BackColor = Color.White;
            TxtCognome.BackColor = Color.White;
            TxtEmail.BackColor = Color.White;
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
                    throw new Exception("Nome non valido");
            if (!string.IsNullOrEmpty(cognome))
                if (!gestoreRegex.RegexMatch(cognome, patternCognome))
                    throw new Exception("Cognome non valido");
            if (!gestoreRegex.RegexMatch(email, patternEmail))
                throw new Exception("Email non valida");
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

        private void Btn2_Click(object sender, EventArgs e)
        {
            btnlivello = 2;
            Btn2.FillColor = Color.Black;
            Btn2.Font = new Font(Btn2.Font, FontStyle.Bold);
            btnPrecedente.FillColor = SystemColors.ControlDarkDark;
            btnPrecedente = Btn2;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            btnlivello = 1;
            Btn1.FillColor = Color.Black;
            Btn1.Font = new Font(Btn1.Font, FontStyle.Bold);
            btnPrecedente.FillColor = SystemColors.ControlDarkDark;
            btnPrecedente = Btn1;
        }

        private void BtnLivello3_Click(object sender, EventArgs e)
        {
            btnlivello = 3;
            BtnLivello3.FillColor = Color.Black;
            BtnLivello3.Font = new Font(Btn1.Font, FontStyle.Bold);
            btnPrecedente.FillColor = SystemColors.ControlDarkDark;
            btnPrecedente = BtnLivello3;
        }
    }
}
