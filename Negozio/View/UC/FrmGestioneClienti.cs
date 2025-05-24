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
    public partial class FrmGestioneClienti : UserControl
    {
        GestoreDbNegozio dbNegozio = new GestoreDbNegozio();
        GestoreRegex gestoreRegex = new GestoreRegex();
        GestoreDelegate gestoreDelegate = new GestoreDelegate();
        public FrmGestioneClienti()
        {
            InitializeComponent();
            IntestaDgv();
            CaricaDgv();

            gestoreDelegate.OnClienteEvidenziato += EvidenziaCliente;
        }

        private void EvidenziaCliente(int codiceCliente)
        {
            List<Cliente> temp = dbNegozio.OttieniTuttiIClienti();

            int rigaDaEvidenziare = 0;
            foreach (Cliente cliente in temp)
            {
                int rowIndex = DgvClienti.Rows.Add(cliente.CodiceFedelta, cliente.Nome, cliente.Cognome, cliente.Email, cliente.Telefono);
                if (cliente.CodiceFedelta == codiceCliente)
                {
                    rigaDaEvidenziare = rowIndex;
                }
            }
            DgvClienti.ClearSelection();
            DgvClienti.Rows[rigaDaEvidenziare].Selected = true;
        }

        private void IntestaDgv()
        {
            string[] intestazioni = { "CODICE CARTA FEDELTA'", "NOME", "COGNOME", "EMAIL", "TELEFONO" };
            DgvClienti.Columns.Clear();
            foreach (string header in intestazioni)
            {
                DgvClienti.Columns.Add(header, header);
            }

            DgvClienti.RowHeadersVisible = false;
            DgvClienti.ReadOnly = true;
            DgvClienti.AllowUserToAddRows = false;
            DgvClienti.AllowUserToDeleteRows = false;
            DgvClienti.AllowUserToResizeColumns = false;
            DgvClienti.AllowUserToResizeRows = false;
            DgvClienti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvClienti.MultiSelect = false;
            DgvClienti.RowTemplate.Height = 28;
            DgvClienti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void TxtCliente_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (TxtRicerca.Text.Trim().Length < 3)
                    CaricaDgv();
                else
                {
                    List<Cliente> temp = dbNegozio.RicercaInDbClienti(TxtRicerca.Text.ToLower());
                    DgvClienti.Rows.Clear();
                    foreach (Cliente cliente in temp)
                    {
                        DgvClienti.Rows.Add(cliente.CodiceFedelta, cliente.Nome, cliente.Cognome, cliente.Email, cliente.StampaNumeroDiTelefono());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CaricaDgv()
        {
            List<Cliente> temp = dbNegozio.OttieniTuttiIClienti();

            foreach (Cliente cliente in temp)
            {
                DgvClienti.Rows.Add(cliente.CodiceFedelta, cliente.Nome, cliente.Cognome, cliente.Email, cliente.Telefono);
            }

            DgvClienti.ClearSelection();
        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                VerificaCampi();
                int CodiceCliente = dbNegozio.AggiungiCliente(TxtNome.Text, TxtCognome.Text, TxtEmail.Text, TxtTelefono.Text);
                MessageBox.Show("Cliente aggiunto con successo !", "SUCCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gestoreDelegate.NotificaClienteEvidenziato(CodiceCliente);
                PulisciCampi();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
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
        }
    }
}
