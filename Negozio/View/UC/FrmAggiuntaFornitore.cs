using Negozio.Controllers;
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
    public partial class FrmAggiuntaFornitore : UserControl
    {
        Random rnd = new Random();
        GestoreDelegate gestoreDelegate;
        GestoreRegex gestoreRegex = new GestoreRegex();
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        public FrmAggiuntaFornitore(GestoreDelegate _gestoreDelegate)
        {
            InitializeComponent();
            gestoreDelegate = _gestoreDelegate;
        }

        private void TxtAzienda_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexAzienda(TxtAzienda);
        }

        private void BtnAggiungiFornitore_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCampi();
                string idFornitore = GeneraId("F");
                DbNegozio.AggiungiFornitore(idFornitore, TxtAzienda.Text, TxtIndirizzo.Text, TxtTelefono.Text, TxtEmail.Text, TxtCategoria.Text);
                MessageBox.Show("Fornitore aggiunto con successo!", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gestoreDelegate.NotificaFornitoreEvidenziato(idFornitore);
                PulisciCampi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GeneraId(string codice)
        {
            string identificativo = codice;
            do
            {
                for (int i = 0; i < 4; i++)
                    identificativo += rnd.Next(0, 10).ToString();
            } while (DbNegozio.VerificaIdUnivoco(identificativo, "Fornitore"));

            return identificativo;
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

        private void TxtIndirizzo_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexIndirizzo(TxtIndirizzo);
        }

        private void TxtTelefono_TextChanged(object sender, EventArgs e)
        {

            gestoreRegex.RegexTelefono(TxtTelefono);
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            gestoreRegex.RegexEmail(TxtEmail);
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
