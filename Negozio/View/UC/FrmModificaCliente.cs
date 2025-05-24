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
    public partial class FrmModificaCliente : UserControl
    {
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        GestoreDelegate gestoreDelegate;
        GestoreRegex gestoreRegex = new GestoreRegex();
        public FrmModificaCliente(GestoreDelegate _gestoreDelegate, string dgvSelectIdCliente)
        {
            InitializeComponent();
            CaricaCmb();

            gestoreDelegate = _gestoreDelegate;

            if (dgvSelectIdCliente != null)
            {
                CaricaCampi(dgvSelectIdCliente);
            }
        }

        private void CaricaCampi(string dgvSelectIdCliente)
        {
            try
            {
                Cliente c = DbNegozio.OttieniCliente(dgvSelectIdCliente);
                TxtNome.Text = c.Nome;
                TxtEmail.Text = c.Email;
                TxtCognome.Text = c.Cognome;
                TxtTelefono.Text = c.Telefono;
                CmbClienti.SelectedValue = Convert.ToInt32(dgvSelectIdCliente);
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
                CmbClienti.SelectedIndexChanged -= CmbClienti_SelectedIndexChanged;
                List<Cliente> lstCliente = DbNegozio.OttieniTuttiIClienti();
                lstCliente = lstCliente.OrderBy(x => x.Cognome).ToList();
                CmbClienti.DataSource = lstCliente;
                CmbClienti.DisplayMember = "Cognome";
                CmbClienti.ValueMember = "CodiceFedelta";
                CmbClienti.SelectedIndex = -1;
                CmbClienti.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbClienti.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
                CmbClienti.SelectedIndexChanged += CmbClienti_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbClienti.SelectedIndex != -1)
            {
                GbNome.Enabled = true;
                GbCognome.Enabled = true;
                GbEmail.Enabled = true;
                GbContattoTelefonico.Enabled = true;
                CaricaCampi(CmbClienti.SelectedValue.ToString());
            }
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCampi();
                DbNegozio.ModificaCliente((int)CmbClienti.SelectedValue, TxtNome.Text, TxtCognome.Text, TxtEmail.Text, TxtTelefono.Text);
                MessageBox.Show("Cliente modificato con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gestoreDelegate.NotificaClienteEvidenziato(Convert.ToInt32(CmbClienti.SelectedValue));
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
            TxtNome.FillColor = Color.White;

            TxtTelefono.Clear();
            TxtTelefono.BackColor = Color.White;

            TxtEmail.Clear();
            TxtEmail.BackColor = Color.White;

            TxtCognome.Clear();
            TxtCognome.BackColor = Color.White;

            CmbClienti.SelectedIndex = -1;

            GbNome.Enabled = false;
            GbCognome.Enabled = false;
            GbEmail.Enabled = false;
            GbContattoTelefonico.Enabled = false;
        }

        private void VerificaCampi()
        {
            if (!gestoreRegex.RegexMatch(TxtNome.Text, @"^[a-zA-Z ']{2,}$"))
                throw new Exception("Campo nome non valido");
            if (!string.IsNullOrEmpty(TxtCognome.Text))
                if (!gestoreRegex.RegexMatch(TxtCognome.Text, @"^[a-zA-Z ']{2,}$"))
                    throw new Exception("Campo cognome non valido");
            if (!gestoreRegex.RegexMatch(TxtEmail.Text, @"^[\w\.-]+@[\w\.-]+\.[a-zA-Z]{2,}$"))
                throw new Exception("Campo email non valido");
            if (!string.IsNullOrEmpty(TxtTelefono.Text))
                if (!gestoreRegex.RegexMatch(TxtTelefono.Text, @"^\d{10}$"))
                    throw new Exception("Campo telefono non valido");
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

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexTelefono(TxtTelefono);
        }
    }
}
