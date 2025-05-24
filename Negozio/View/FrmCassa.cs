using Guna.UI2.WinForms;
using Negozio.Controllers;
using Negozio.Models;
using Negozio.View.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.View
{
    public partial class FrmCassa : Form
    {
        GestoreCarrello gestoreCarrello;
        GestoreDelegate gestoreDelegate;
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();

        Guna2Button btnPrecedente;

        string codiceScannerizzato = "";
        Timer barcodeTimer;
        public FrmCassa(GestoreCarrello _gestoreCarrello)
        {
            InitializeComponent();
            gestoreCarrello = _gestoreCarrello;
            gestoreDelegate = _gestoreCarrello.gestoreDelegate;

            gestoreDelegate.OnStampaFattura += ChiudiForm;

            gestoreCarrello.MostraRecapitoCarrello(PanCarrello);

            if (gestoreCarrello.Cliente != null)
                gestoreCarrello.MostraCliente(PanCliente);
            else
                gestoreCarrello.MostraPulsaneAggiuntaCliente(PanCliente);

            PanCliente.BackColor = Color.FromArgb(18, 18, 18);
            PanBar.BackColor = Color.FromArgb(18, 18, 18);
            PanBody.BackColor = Color.FromArgb(18, 18, 18);

            PanBody.Controls.Clear();
            PanBody.Controls.Add(new FrmPagamentoCassa(gestoreCarrello.gestoreDelegate, gestoreCarrello));
            PanBody.BringToFront();
            ColoreAttivato(BtnPagamento);
            btnPrecedente = BtnPagamento;

            this.KeyPreview = true;
            barcodeTimer = new Timer();
            barcodeTimer.Interval = 200;
            barcodeTimer.Tick += BarcodeTimer_Tick;
        }

        private void ChiudiForm()
        {
            DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void BarcodeTimer_Tick(object sender, EventArgs e)
        {
            codiceScannerizzato = "";
            barcodeTimer.Stop();
        }

        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            ColoreDisattivato(btnPrecedente);
            btnPrecedente = BtnPagamento;
            ColoreAttivato(BtnPagamento);

            PanBody.Controls.Clear();
            PanBody.Controls.Add(new FrmPagamentoCassa(gestoreCarrello.gestoreDelegate, gestoreCarrello));
            PanBody.BringToFront();
        }

        private void FrmCassa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Menu)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                if (codiceScannerizzato.Length == 5)
                {
                    string codice = codiceScannerizzato.ToUpper();
                    if (DbNegozio.VerificaPresenzaCliente(codice))
                    {
                        gestoreDelegate.NotificaScannerizzazione(codice, PanCliente);
                        gestoreDelegate.NotificaAggiuntaCarta();
                    }
                    else
                        MessageBox.Show("Cliente non trovato", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z) || (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                codiceScannerizzato += (char)e.KeyCode;
                barcodeTimer.Stop();
                barcodeTimer.Start();
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ColoreAttivato(Guna2Button btn)
        {
            btn.FillColor = Color.Silver;
            btn.BorderColor = Color.DimGray;
            btn.ForeColor = Color.Black;
        }

        private void ColoreDisattivato(Guna2Button btn)
        {
            btn.FillColor = Color.DimGray;
            btn.BorderColor = Color.White;
            btn.ForeColor = Color.White;
        }

        private void BtnNuovoCliente_Click(object sender, EventArgs e)
        {
            ColoreDisattivato(btnPrecedente);
            btnPrecedente = BtnNuovoCliente;
            ColoreAttivato(BtnNuovoCliente);

            PanBody.Controls.Clear();
            PanBody.Controls.Add(new FrmGestioneClienti());
            PanBody.BringToFront();
        }
    }
}

