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
    public partial class FrmModficaFornitore : UserControl
    {
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        GestoreDelegate gestoreDelegate = new GestoreDelegate();
        GestoreRegex gestoreRegex = new GestoreRegex();
        public FrmModficaFornitore(GestoreDelegate _gestoreDelegate, string dgvSelectIdFornitore)
        {
            InitializeComponent();
            gestoreDelegate = _gestoreDelegate;
            CaricaCmb();
            if (dgvSelectIdFornitore != null)
            {
                CmbFornitori.SelectedValue = dgvSelectIdFornitore;
                CaricaCampi(dgvSelectIdFornitore);
            }
        }

        private void CaricaCampi(string dgvSelectIdFornitore)
        {
            try
            {
                Fornitore f = DbNegozio.OttieniFornitore(dgvSelectIdFornitore);
                TxtAzienda.Text = f.NomeAzienda;
                TxtEmail.Text = f.Email;
                TxtCategoria.Text = f.TipoFornimento;
                TxtIndirizzo.Text = f.Indirizzo;
                TxtTelefono.Text = f.TelefonoAzienda;
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
                CmbFornitori.SelectedIndexChanged -= CmbFornitori_SelectedIndexChanged;
                List<Fornitore> lstFornitore = DbNegozio.OttieniTuttiIFornitori();
                lstFornitore.OrderBy(x => x.NomeAzienda).ToList();
                CmbFornitori.DataSource = lstFornitore;
                CmbFornitori.DisplayMember = "NomeAzienda";
                CmbFornitori.ValueMember = "IdFornitore";
                CmbFornitori.SelectedIndex = -1;
                CmbFornitori.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbFornitori.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
                CmbFornitori.SelectedIndexChanged += CmbFornitori_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CmbFornitori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbFornitori.SelectedIndex != -1)
            {
                GbNome.Enabled = true;
                GbCategoria.Enabled = true;
                GbEmail.Enabled = true;
                GbContattoTelefonico.Enabled = true;
                GbIndirizzo.Enabled = true;
                CaricaCampi(CmbFornitori.SelectedValue.ToString());
            }
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCampi();
                DbNegozio.ModificaFornitore(CmbFornitori.SelectedValue.ToString(), TxtAzienda.Text, TxtIndirizzo.Text, TxtTelefono.Text, TxtEmail.Text, TxtCategoria.Text);
                MessageBox.Show("Fornitore modificato con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gestoreDelegate.NotificaFornitoreEvidenziato(CmbFornitori.SelectedValue.ToString());
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
            TxtAzienda.Clear();
            TxtAzienda.BackColor = Color.White;

            TxtIndirizzo.Clear();
            TxtIndirizzo.BackColor = Color.White;

            TxtTelefono.Clear();
            TxtTelefono.BackColor = Color.White;

            TxtEmail.Clear();
            TxtEmail.BackColor = Color.White;

            TxtCategoria.Clear();
            TxtCategoria.BackColor = Color.White;
            CmbFornitori.SelectedIndex = -1;

            GbNome.Enabled = false;
            GbCategoria.Enabled = false;
            GbEmail.Enabled = false;
            GbContattoTelefonico.Enabled = false;
            GbIndirizzo.Enabled = false;
        }

        private void VerificaCampi()
        {
            string azienda = TxtAzienda.Text;
            string email = TxtEmail.Text;
            string telefono = TxtTelefono.Text;
            string indirizzo = TxtIndirizzo.Text;
            string tipo = TxtCategoria.Text;

            string patternAzienda = @"^[A-Za-z0-9&’'\.\- ]{2,}$";
            string patternIndirizzo = @"^[A-Za-zÀ-ÿ\s'\.\-]+ \d+[A-Za-z]?(, [A-Za-zÀ-ÿ'\.\- ]+)?$";
            string patternEmail = @"^[\w\.-]+@[\w\.-]+\.[a-zA-Z]{2,}$";
            string patternTelefono = @"^\d{10}$";
            string patternTipologia = @"^[A-Za-zÀ-ÿ0-9,\'\-&\s]{2,}$";

            if (!gestoreRegex.RegexMatch(azienda, patternAzienda))
                throw new Exception("Campo nome azienda non valido !");
            if (!gestoreRegex.RegexMatch(email, patternEmail))
                throw new Exception("Campo email non valido !");
            if (!string.IsNullOrEmpty(telefono))
                if (!gestoreRegex.RegexMatch(telefono, patternTelefono))
                    throw new Exception("Numero di telefono non valido !");
            if (!string.IsNullOrEmpty(indirizzo))
                if (!gestoreRegex.RegexMatch(indirizzo, patternIndirizzo))
                    throw new Exception("Campo indirizzo non valido !");
            if (!gestoreRegex.RegexMatch(tipo, patternTipologia))
                throw new Exception("Campo tipologia prodotto fornito non valido !");
        }

        private void TxtAzienda_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexAzienda(TxtAzienda);
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexEmail(TxtEmail);
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexTelefono(TxtTelefono);
        }

        private void TxtIndirizzo_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexIndirizzo(TxtIndirizzo);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TxtCategoria_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexTipologia(TxtCategoria);
        }
    }
}
