using Guna.UI2.WinForms;
using Negozio.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.Controllers
{
    public class GestoreCarrello
    {
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        Panel PanCarrello;
        Label LblTotale;
        public GestoreDelegate gestoreDelegate { get; set; }
        public Cliente Cliente { get; set; }
        public List<Articolo> carrello { get; set; }
        public Dictionary<string, int> quantitaCarrello { get; set; }
        public double totale { get; set; }
        public int quantitaSacchetti { get; set; }
        public GestoreCarrello()
        {
            carrello = new List<Articolo>();
            quantitaCarrello = new Dictionary<string, int>();
            gestoreDelegate = new GestoreDelegate();
            quantitaSacchetti = 0;
            gestoreDelegate.OnScannerizzazione += CaricaScannerizzazione;
        }

        private void CaricaScannerizzazione(string codiceScannerizzato, Panel panel)
        {
            if (Cliente != null)
                MessageBox.Show("Cliente già presente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Cliente = DbNegozio.OttieniCliente(codiceScannerizzato);
                MostraCliente(panel);
            }
        }

        internal void VisualizzaCarrelloVuoto(Panel panel)
        {
            var labelVuoto = new Guna2HtmlLabel
            {
                Text = "IL CARRELLO È VUOTO",
                Font = new Font("Segoe UI", 16, FontStyle.Bold),
                ForeColor = Color.IndianRed,
                AutoSize = true,
                Location = new Point(20, 20),
            };
            panel.Controls.Add(labelVuoto);
        }

        public void AggiungiAlCarrello(string codice, Panel panel, Label lblTotale)
        {
            try
            {
                if (codice.StartsWith("A"))
                {
                    Articolo articolo = DbNegozio.OttieniArticolo(codice);

                    if (carrello.Exists(x => x.CodiceArticolo == articolo.CodiceArticolo))
                    {
                        if (quantitaCarrello[codice] == articolo.Quantita)
                            throw new Exception("La quantità del prodotto nel carrello ha raggiunto il massimo disponibile.");

                        quantitaCarrello[codice]++;
                    }
                    else
                    {
                        carrello.Add(articolo);
                        quantitaCarrello[codice] = 1;
                    }
                }
                else
                {
                    Cliente = DbNegozio.OttieniCliente(codice);
                }

                PanCarrello = panel;
                LblTotale = lblTotale;

                AggiornaCarrello();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AggiornaCarrello()
        {
            PanCarrello.SuspendLayout();
            PanCarrello.Controls.Clear();
            PanCarrello.AutoScroll = true;
            PanCarrello.BackColor = Color.FromArgb(18, 18, 18);

            int yPos = 10;
            totale = 0;

            if (Cliente != null)
            {
                Guna2Panel pannelCliente = new Guna2Panel
                {
                    BorderRadius = 10,
                    FillColor = Color.FromArgb(30, 30, 30),
                    Size = new Size(PanCarrello.Width - 30, 110),
                    Location = new Point(10, 10),
                    ShadowDecoration = { Enabled = true, Depth = 4 },
                    Padding = new Padding(10)
                };

                Guna2HtmlLabel labelCliente = new Guna2HtmlLabel
                {
                    Text = $"Cliente: {Cliente.Nome} {Cliente.Cognome}",
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    ForeColor = Color.White,
                    AutoSize = true,
                };
                labelCliente.Location = new Point((pannelCliente.Width - labelCliente.PreferredSize.Width) / 2, 15);
                Guna2Button btn = new Guna2Button
                {
                    Text = "Annulla",
                    Width = 200,
                    Height = 30,
                    FillColor = Color.DarkRed,
                    ForeColor = Color.Black,
                    BorderColor = Color.Black,
                    BorderThickness = 2,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Name = Cliente.CodiceFedelta.ToString(),
                    BorderRadius = 7,
                    HoverState = { BorderColor = Color.White, ForeColor = Color.White },
                };
                btn.Location = new Point((pannelCliente.Width - btn.Width) / 2, 60);
                btn.Click += (sender, e) =>
                {
                    Cliente = null;
                    AggiornaCarrello();
                };

                pannelCliente.Controls.Add(labelCliente);
                pannelCliente.Controls.Add(btn);
                PanCarrello.Controls.Add(pannelCliente);
                yPos += pannelCliente.Height + 10;
            }

            if (carrello.Count == 0)
            {
                VisualizzaCarrelloVuoto(PanCarrello);
                LblTotale.Text = "TOTALE: €0.00";
                PanCarrello.ResumeLayout();
                return;
            }

            foreach (Articolo a in carrello)
            {
                int quantita = quantitaCarrello[a.CodiceArticolo];

                Guna2Panel pannelloArticolo = new Guna2Panel
                {
                    BorderRadius = 12,
                    FillColor = Color.FromArgb(30, 30, 30),
                    Size = new Size(PanCarrello.Width - 30, 110),
                    Location = new Point(10, yPos),
                    ShadowDecoration = { Enabled = true, Depth = 4 },
                    Padding = new Padding(12),
                    BackColor = Color.Transparent
                };

                var labelDescrizione = new Guna2HtmlLabel
                {
                    Text = a.DescrizioneArticolo,
                    Font = new Font("Segoe UI Semibold", 11),
                    ForeColor = Color.White,
                    Location = new Point(10, 10),
                    AutoSize = true,
                    BackColor = Color.Transparent
                };

                var labelPrezzo = new Guna2HtmlLabel
                {
                    Text = a.PrezzoConIva().ToString("C"),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.LightGreen,
                    Location = new Point(pannelloArticolo.Width - 110, 10),
                    AutoSize = false,
                    Height = 40,
                    TextAlignment = ContentAlignment.MiddleRight,
                    Size = new Size(100, 50),
                    BackColor = Color.Transparent
                };

                var labelQuantita = new Guna2HtmlLabel
                {
                    Text = $"Quantità: {quantita}",
                    Font = new Font("Segoe UI", 9),
                    ForeColor = Color.Silver,
                    Location = new Point(10, 40),
                    BackColor = Color.Transparent,
                    AutoSize = true
                };

                var btnAggiungi = new Guna2Button
                {
                    Text = "+",
                    Size = new Size(30, 30),
                    Font = new Font("Segoe UI", 10),
                    Location = new Point(pannelloArticolo.Width - 75, 60),
                    BorderRadius = 5,
                    FillColor = Color.Teal,
                    ForeColor = Color.White
                };
                btnAggiungi.Click += (sender, e) => AumentaQuantita(a);

                var btnRimuovi = new Guna2Button
                {
                    Text = "-",
                    Size = new Size(30, 30),
                    Font = new Font("Segoe UI", 10),
                    Location = new Point(pannelloArticolo.Width - 40, 60),
                    BorderRadius = 5,
                    FillColor = Color.OrangeRed,
                    ForeColor = Color.White
                };
                btnRimuovi.Click += (sender, e) => RiduciQuantita(a);

                pannelloArticolo.Controls.Add(labelDescrizione);
                pannelloArticolo.Controls.Add(labelPrezzo);
                pannelloArticolo.Controls.Add(labelQuantita);
                pannelloArticolo.Controls.Add(btnAggiungi);
                pannelloArticolo.Controls.Add(btnRimuovi);

                PanCarrello.Controls.Add(pannelloArticolo);
                yPos += pannelloArticolo.Height + 10;

                totale += a.PrezzoConIva() * quantita;
            }

            LblTotale.Text = "TOTALE: " + totale.ToString("C");
            PanCarrello.ResumeLayout();
        }

        private void AumentaQuantita(Articolo articolo)
        {
            quantitaCarrello[articolo.CodiceArticolo]++;
            totale += articolo.PrezzoArticolo;
            AggiornaCarrello();
        }

        private void RiduciQuantita(Articolo articolo)
        {
            if (quantitaCarrello[articolo.CodiceArticolo] > 1)
            {
                quantitaCarrello[articolo.CodiceArticolo]--;
                totale -= articolo.PrezzoArticolo;
            }
            else
            {
                carrello.RemoveAll(a => a.CodiceArticolo == articolo.CodiceArticolo);
                quantitaCarrello.Remove(articolo.CodiceArticolo);
                totale -= articolo.PrezzoArticolo;
            }
            AggiornaCarrello();
        }

        public void MostraRecapitoCarrello(Panel panel)
        {
            PanCarrello = panel;
            panel.SuspendLayout();
            panel.Controls.Clear();
            panel.AutoScroll = true;
            panel.BackColor = Color.FromArgb(18, 18, 18);

            int yPos = 10;
            totale = 0;
            foreach (Articolo a in carrello)
            {
                var codice = a.CodiceArticolo;
                int quantita = quantitaCarrello.ContainsKey(codice) ? quantitaCarrello[codice] : 0;

                Guna2Panel pannelloArticolo = new Guna2Panel
                {
                    BorderRadius = 12,
                    FillColor = Color.FromArgb(30, 30, 30),
                    Size = new Size(panel.Width - 30, 80),
                    Location = new Point(10, yPos),
                    ShadowDecoration = { Enabled = true, Depth = 4 },
                    Padding = new Padding(12),
                    BackColor = Color.Transparent
                };

                var labelDescrizione = new Guna2HtmlLabel
                {
                    Text = a.DescrizioneArticolo,
                    Font = new Font("Segoe UI Semibold", 11),
                    ForeColor = Color.White,
                    Location = new Point(10, 10),
                    AutoSize = true,
                    BackColor = Color.Transparent
                };

                var labelPrezzo = new Guna2HtmlLabel
                {
                    Text = a.PrezzoConIva().ToString("C"),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.LightGreen,
                    Location = new Point(pannelloArticolo.Width - 110, 10),
                    AutoSize = false,
                    Height = 40,
                    TextAlignment = ContentAlignment.MiddleRight,
                    Size = new Size(100, 50),
                    BackColor = Color.Transparent
                };

                var labelQuantita = new Guna2HtmlLabel
                {
                    Text = $"Quantità: {quantita}",
                    Font = new Font("Segoe UI", 9, FontStyle.Italic),
                    ForeColor = Color.Silver,
                    Location = new Point(10, 40),
                    AutoSize = false,
                    Size = new Size(pannelloArticolo.Width - 40, 20),
                    BackColor = Color.Transparent
                };

                pannelloArticolo.Controls.Add(labelDescrizione);
                pannelloArticolo.Controls.Add(labelPrezzo);
                pannelloArticolo.Controls.Add(labelQuantita);

                panel.Controls.Add(pannelloArticolo);
                yPos += pannelloArticolo.Height + 10;
                totale += a.PrezzoConIva();
            }

            if (quantitaSacchetti > 0)
            {
                Guna2Panel pannelSacchetto = new Guna2Panel
                {
                    BorderRadius = 12,
                    FillColor = Color.FromArgb(30, 30, 30),
                    Size = new Size(panel.Width - 30, 80),
                    Location = new Point(10, yPos),
                    ShadowDecoration = { Enabled = true, Depth = 4 },
                    Padding = new Padding(12),
                    BackColor = Color.Transparent
                };

                var labelSacchetto = new Guna2HtmlLabel
                {
                    Text = "Sacchetto di tessuto",
                    Font = new Font("Segoe UI Semibold", 11),
                    ForeColor = Color.White,
                    Location = new Point(10, 10),
                    AutoSize = true,
                    BackColor = Color.Transparent
                };

                var labelPrezzo = new Guna2HtmlLabel
                {
                    Text = 0.10.ToString("C"),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.LightGreen,
                    Location = new Point(pannelSacchetto.Width - 110, 10),
                    AutoSize = false,
                    Height = 40,
                    TextAlignment = ContentAlignment.MiddleRight,
                    Size = new Size(100, 50),
                    BackColor = Color.Transparent
                };

                var labelQuantita = new Guna2HtmlLabel
                {
                    Text = "Quantità " + quantitaSacchetti.ToString(),
                    Font = new Font("Segoe UI", 9, FontStyle.Italic),
                    ForeColor = Color.Silver,
                    Location = new Point(10, 40),
                    AutoSize = false,
                    Size = new Size(pannelSacchetto.Width - 40, 20),
                    BackColor = Color.Transparent
                };

                pannelSacchetto.Controls.Add(labelSacchetto);
                pannelSacchetto.Controls.Add(labelPrezzo);
                pannelSacchetto.Controls.Add(labelQuantita);

                panel.Controls.Add(pannelSacchetto);
                yPos += pannelSacchetto.Height + 10;
                totale += quantitaSacchetti * 0.10;
            }
            gestoreDelegate.NotificaAggiuntaCarta();

            panel.ResumeLayout();
        }

        internal void MostraCliente(Panel panCliente)
        {
            panCliente.Controls.Clear();
            Guna2Panel pannelCliente = new Guna2Panel
            {
                BorderRadius = 10,
                FillColor = Color.FromArgb(30, 30, 30),
                Size = new Size(PanCarrello.Width - 24, 120),
                Location = new Point(10, 10),
                ShadowDecoration = { Enabled = true, Depth = 4 },
                Padding = new Padding(10),
            };

            Guna2HtmlLabel labelCliente = new Guna2HtmlLabel
            {
                Text = $"Cliente: {Cliente.Nome} {Cliente.Cognome}",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(17, 20),
            };
            pannelCliente.Controls.Add(labelCliente);
            labelCliente.Location = new Point((pannelCliente.Width - labelCliente.Width) / 2, 10);

            Guna2Button btn = new Guna2Button
            {
                Text = "Annulla",
                Size = new Size(pannelCliente.Width - 40, 30),
                BackColor = Color.Transparent,
                FillColor = Color.DarkRed,
                ForeColor = Color.Black,
                BorderRadius = 6,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            pannelCliente.Controls.Add(btn);
            btn.Location = new Point((pannelCliente.Width - btn.Width) / 2, 55);

            btn.Click += (sender, e) =>
            {
                Cliente = null;
                gestoreDelegate.NotificaAggiuntaCarta();
                MostraPulsaneAggiuntaCliente(panCliente);
            };
            panCliente.Controls.Add(pannelCliente);
        }

        public void MostraPulsaneAggiuntaCliente(Panel panCliente)
        {
            panCliente.Controls.Clear();

            Guna2Panel pannelloAggiunta = new Guna2Panel
            {
                BorderRadius = 10,
                FillColor = Color.FromArgb(30, 30, 30),
                Size = new Size(PanCarrello.Width - 24, 120),
                Location = new Point(10, 10),
                ShadowDecoration = { Enabled = true, Depth = 4 },
                Padding = new Padding(10),
                BackColor = Color.Transparent
            };

            Guna2TextBox txtCliente = new Guna2TextBox
            {
                PlaceholderText = "Inserisci codice carta fedeltà",
                Font = new Font("Segoe UI", 10),
                Size = new Size(pannelloAggiunta.Width - 40, 30),
                BorderRadius = 6,
                FillColor = Color.FromArgb(50, 50, 50),
                ForeColor = Color.White,
                PlaceholderForeColor = Color.Gray,
                BorderColor = Color.DarkGray,
                MaxLength = 5
            };
            txtCliente.Location = new Point(
                (pannelloAggiunta.Width - txtCliente.Width) / 2,
                10
            );
            txtCliente.KeyPress += (sender, e) =>
            {
                TextBox tb = sender as TextBox;

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            };

            Guna2Button btnAggiungi = new Guna2Button
            {
                Text = "Aggiungi",
                Size = new Size(pannelloAggiunta.Width - 40, 30),
                BackColor = Color.Transparent,
                FillColor = Color.DarkRed,
                ForeColor = Color.Black,
                BorderRadius = 6,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            btnAggiungi.Location = new Point(
                (pannelloAggiunta.Width - btnAggiungi.Width) / 2,
                55
            );

            btnAggiungi.Click += (sender, e) =>
            {
                string input = txtCliente.Text.Trim();
                if (input != "" && input.Length == 5)
                {
                    try
                    {
                        if (!DbNegozio.VerificaPresenzaCliente(input))
                            throw new Exception("Codice carta fedeltà non valido");
                        else
                        {
                            Cliente = DbNegozio.OttieniCliente(input);
                            MostraCliente(panCliente);
                            gestoreDelegate.NotificaAggiuntaCarta();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Codie carta fedeltà non valido", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            pannelloAggiunta.Controls.Add(txtCliente);
            pannelloAggiunta.Controls.Add(btnAggiungi);
            panCliente.Controls.Add(pannelloAggiunta);
        }

        internal double CalcolaSconto(int sconto)
        {
            double totale = 0;
            double percentualeSconto = sconto / 100.0;

            Console.WriteLine($"Sconto ricevuto: {sconto}% ({percentualeSconto})");

            foreach (Articolo a in carrello)
            {
                double prezzoFinale = a.PrezzoConIva();

                if (a.PrezzoConIva() > 150)
                {
                    double scontoArticolo = a.PrezzoConIva() * percentualeSconto;
                    prezzoFinale -= scontoArticolo;

                    Console.WriteLine($"Articolo > 150 €: Prezzo originale = {a.PrezzoConIva()}, sconto = {scontoArticolo}, finale = {prezzoFinale}");
                }
                else
                {
                    Console.WriteLine($"Articolo <= 150 €: Nessuno sconto. Prezzo = {a.PrezzoConIva()}");
                }

                totale += prezzoFinale;
            }

            if (quantitaSacchetti > 0)
            {
                double costoSacchetti = quantitaSacchetti * 0.10;
                Console.WriteLine($"Costo sacchetti: {costoSacchetti}");
                totale += costoSacchetti;
            }

            Console.WriteLine($"Totale finale scontato: {totale}");
            return totale;
        }


        internal void AggiungiSacchetto(int value)
        {
            quantitaSacchetti += value;
            MostraRecapitoCarrello(PanCarrello);
        }

        internal void RimuoviSacchetto(int value)
        {
            quantitaSacchetti -= value;
            MostraRecapitoCarrello(PanCarrello);
        }

        internal void RicaricaCarrello(Panel panCarrello)
        {
            PanCarrello = panCarrello;
            AggiornaCarrello();
        }

        public string CalcolaIvaTotale()
        {
            double totale = 0;
            foreach (Articolo a in carrello)
            {
                totale += a.PrezzoConIva() * ((double)a.Iva / 100);
            }
            return totale.ToString("F2");
        }
    }
}
