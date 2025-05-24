using Guna.UI2.WinForms;
using Negozio.Controllers;
using Negozio.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.View.UC
{
    public partial class FrmPagamentoCassa : UserControl
    {
        bool puntoPremuto = false;
        GestoreCarrello gestoreCarrello;
        GestoreDelegate gestoreDelegate;
        GestoreDbNegozio dbNegozio = new GestoreDbNegozio();
        OpenXml Xml = new OpenXml();
        double totaleSpesa;
        double pagamento = 0;
        double resto = 0;
        string folderPath;

        string metodoDiPagamento = "Pagameno contante";
        public FrmPagamentoCassa(GestoreDelegate _gestoreDelegate, GestoreCarrello _gestoreCarrello)
        {
            InitializeComponent();
            gestoreCarrello = _gestoreCarrello;
            gestoreDelegate = _gestoreDelegate;

            gestoreDelegate.OnAggiuntaCarta += AggiornaTotaleSpesa;

            AggiornaTotaleSpesa();
            PreparaPerPagamento();
        }

        private void PreparaPerPagamento()
        {
            foreach (Control ctrl in GbPagamento.Controls)
            {
                if (ctrl is Guna2Button btn && btn.Tag == null)
                {
                    btn.Click += BtnPagamento_Click;
                    btn.Tag = "event-attached";
                }
            }
        }

        private void BtnPagamento_Click(object sender, EventArgs e)
        {
            if (sender is Guna2Button btn)
            {
                switch (btn.Text)
                {
                    case ".":
                        puntoPremuto = !puntoPremuto;
                        btn.FillColor = puntoPremuto ? Color.Yellow : Color.White;
                        break;

                    case "C":
                        pagamento = 0;
                        LblPagamento.Text = "PAGAMENTO : 0";
                        LblResto.Text = "RESTO : ";
                        LblImportoDaPagare.Text = "IMPORTO DA PAGARE : " + totaleSpesa.ToString("C");
                        puntoPremuto = false;
                        break;

                    case "APRI CASSA":
                        MessageBox.Show("Cassa aperta ora è possibile dare il resto", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BtnSalvaFattura.Enabled = true;
                        break;

                    case "SALVA FATTURA":
                        SalvaFattura();
                        gestoreDelegate.NotificaStampaFattura();
                        break;

                    default:
                        if (double.TryParse(btn.Text, out double valore))
                        {
                            pagamento += puntoPremuto ? valore / 100 : valore;
                            LblPagamento.Text = "PAGAMENTO : " + pagamento.ToString("C");
                            LblImportoDaPagare.Text = "RIMANE DA PAGARE : " + (totaleSpesa - pagamento).ToString("C");

                            if (pagamento >= totaleSpesa)
                            {
                                LblImportoDaPagare.Text = "IMPORTO COPERTO";
                                resto = pagamento - totaleSpesa;
                                LblResto.Text = "RESTO : " + resto.ToString("C");
                                if (resto == 0)
                                    BtnSalvaFattura.Enabled = true;
                                BtnApriCassa.Enabled = true;
                            }
                        }
                        break;
                }
            }
        }

        private void SalvaFattura()
        {
            FolderBrowserDialog dbD = new FolderBrowserDialog
            {
                Description = "Seleziona la cartella di destinazione del salvataggio della fattura"
            };
            if (dbD.ShowDialog() == DialogResult.OK)
            {
                folderPath = dbD.SelectedPath + "\\Fatture";
                Thread t = new Thread(AvviaSalvataggio);
                t.Start();
            }
        }

        private void AvviaSalvataggio()
        {
            try
            {
                string numeroScontrino = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string nomeFattura = "fattura_" + numeroScontrino + ".docx";

                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string filePath = Path.Combine(folderPath, nomeFattura);
                File.Copy(AppDomain.CurrentDomain.BaseDirectory + "\\template_scontrino.docx", filePath);

                Xml.StampaFattura(gestoreCarrello, totaleSpesa, pagamento, resto, metodoDiPagamento, filePath, numeroScontrino, gestoreCarrello.Cliente, gestoreCarrello.quantitaSacchetti);

                DateTime dataFattura = DateTime.ParseExact(numeroScontrino, "yyyyMMdd_HHmmss", CultureInfo.InvariantCulture);
                dbNegozio.SalvaFattura(numeroScontrino, dataFattura, totaleSpesa, pagamento, resto, metodoDiPagamento, gestoreCarrello.Cliente, Convert.ToDouble(gestoreCarrello.CalcolaIvaTotale()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AggiornaTotaleSpesa()
        {
            double totale = gestoreCarrello.totale;
            LblTotale.Text = "TOTALE : " + totale.ToString("C");

            if (gestoreCarrello.Cliente != null)
            {
                LblSconto.Text = "SCONTO : 2% SU OGNI PRODOTTO SUPERIORE DI 150 €";
                totaleSpesa = gestoreCarrello.CalcolaSconto(2);
                LblTotaleScontato.Text = "TOTALE SCONTATO : " + totaleSpesa.ToString("C");
                LblImportoDaPagare.Text = "IMPORTO DA PAGARE : " + totaleSpesa.ToString("C");
            }
            else
            {
                LblSconto.Text = "SCONTO : 0";
                totaleSpesa = totale;
                LblTotaleScontato.Text = "TOTALE SCONTATO : " + totaleSpesa.ToString("C");
                LblImportoDaPagare.Text = "IMPORTO DA PAGARE : " + totaleSpesa.ToString("C");
            }
        }

        private void BtnContanti_Click(object sender, EventArgs e)
        {
            BtnContanti.BorderColor = Color.Gold;
            BtnCarta.BorderColor = Color.Black;
            metodoDiPagamento = "Pagamento contante";
            pagamento = 0;
        }

        private void BtnCarta_Click(object sender, EventArgs e)
        {
            if (pagamento > 0)
            {
                if (MessageBox.Show("Vuoi annullare il pagamento in contanti e procedere con quello elettronico?",
                                    "Attenzione",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.No)
                    return;
            }

            BtnContanti.BorderColor = Color.Black;
            BtnCarta.BorderColor = Color.Gold;
            metodoDiPagamento = "Pagamento elettronico";
            pagamento = 0;
            LblPagamento.Text = "PAGAMENTO : 0";
            pagamento = totaleSpesa;
            resto = 0;
            LblResto.Text = "RESTO : ";
            if (MessageBox.Show("Procedere con metodo di pagamento carta ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                BtnContanti_Click(BtnContanti, EventArgs.Empty);
                GbPagamento.Enabled = false;
            }
            else
                SimulaLetturaCarta();
        }

        private async void SimulaLetturaCarta()
        {
            MessageBox.Show("Avvicinare la carta per il pagamento...", "Lettura in corso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            await Task.Delay(3000);

            MessageBox.Show("Pagamento effettuato con successo!", "Conferma pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SalvaFattura();
            gestoreDelegate.NotificaStampaFattura();
        }



        private void BtnAggiungiSacchetto_Click(object sender, EventArgs e)
        {
            gestoreCarrello.AggiungiSacchetto(Convert.ToInt32(NudSacchetto.Value));
        }

        private void BtnRimuoviSacchetto_Click(object sender, EventArgs e)
        {
            gestoreCarrello.RimuoviSacchetto(Convert.ToInt32(NudSacchetto.Value));
        }
    }
}
