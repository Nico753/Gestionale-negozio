using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Negozio.Controllers;
using Negozio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.View.UC
{
    public partial class FrmArticoli : UserControl
    {
        // VARIABILI GLOBALI
        GestoreDbNegozio dbNegozio = new GestoreDbNegozio();
        GestoreDelegate gestoreDelegate;
        GestoreLoader loader = new GestoreLoader();

        string Ricerca;
        string Categoria;
        public FrmArticoli(string categoria, GestoreDelegate _gestoreDelegate, string ricerca)
        {
            InitializeComponent();
            // Inizializza delegate
            gestoreDelegate = _gestoreDelegate;
            gestoreDelegate.OnChiusuraFrmCommesso += PulisciImmagini;
            PanelProdotti.BackColor = Color.FromArgb(18, 18, 18);
            this.BackColor = Color.FromArgb(18, 18, 18);
            Ricerca = ricerca;
            Categoria = categoria;
        }


        private void FrmArticoli_Load(object sender, EventArgs e)
        {
            loader.MostraLoader(this);

            Thread t = new Thread(new ThreadStart(CaricaArticoliInThread));
            t.Start();
        }

        private void CaricaArticoliInThread()
        {
            try
            {
                List<Articolo> listaArticoli;

                if (string.IsNullOrEmpty(Ricerca))
                {
                    listaArticoli = dbNegozio.OttieniArticoliCategoria(Categoria);
                }
                else
                {
                    listaArticoli = dbNegozio.RicercaInDbArticoli(Ricerca);
                }
                
                Invoke(new Action(() =>
                {

                    List<Control> controlliDaAggiornare = new List<Control>();

                    foreach (var articolo in listaArticoli)
                    {
                        Guna2Panel pannelloArticolo = new Guna2Panel
                        {
                            Width = 220,
                            Height = 320,
                            Margin = new Padding(15),
                            BackColor = Color.FromArgb(30, 30, 30),
                            Tag = articolo.CodiceArticolo,
                            BorderRadius = 15,
                        };

                        Guna2PictureBox pictureBox = new Guna2PictureBox
                        {
                            Width = 200,
                            Height = 160,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Location = new Point(10, 10),
                            BorderRadius = 10,
                        };

                        if (!string.IsNullOrEmpty(articolo.Immagine))
                        {
                            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../" + articolo.Immagine);
                            if (File.Exists(path))
                            {
                                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                                using (var ms = new MemoryStream())
                                {
                                    fs.CopyTo(ms);
                                    pictureBox.Image = Image.FromStream(new MemoryStream(ms.ToArray()));
                                }
                            }
                        }
                        else
                        {
                            pictureBox.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../" + "img/DbImage/noDisponibile.png"));
                        }

                        Guna2HtmlLabel nomeLabel = new Guna2HtmlLabel
                        {
                            Text = articolo.DescrizioneArticolo,
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            ForeColor = Color.White,
                            TextAlignment = ContentAlignment.MiddleCenter,
                            Width = 200,
                            AutoSize = false,
                            Location = new Point(10, 175)
                        };

                        Guna2HtmlLabel prezzoLabel = new Guna2HtmlLabel
                        {
                            Text = articolo.PrezzoConIva().ToString("C"),
                            Font = new Font("Segoe UI", 12, FontStyle.Bold),
                            ForeColor = Color.LimeGreen,
                            TextAlignment = ContentAlignment.MiddleCenter,
                            Width = 200,
                            AutoSize = false,
                            Location = new Point(10, 205)
                        };

                        Guna2HtmlLabel giacenzaLabel = new Guna2HtmlLabel
                        {
                            Text = $"Giacenza: {articolo.Quantita}",
                            Font = new Font("Segoe UI", 10),
                            ForeColor = Color.LightGray,
                            TextAlignment = ContentAlignment.MiddleCenter,
                            Width = 200,
                            AutoSize = false,
                            Location = new Point(10, 230)
                        };

                        Guna2Button btn = new Guna2Button
                        {
                            Text = "Aggiungi",
                            Width = 200,
                            Height = 40,
                            Location = new Point(10, 255),
                            BackColor = Color.Transparent,
                            FillColor = Color.Black,
                            ForeColor = Color.White,
                            BorderColor = Color.White,
                            BorderThickness = 2,
                            Font = new Font("Segoe UI", 10, FontStyle.Bold),
                            Cursor = Cursors.Hand,
                            Name = articolo.CodiceArticolo,
                            BorderRadius = 7,
                            HoverState = { FillColor = Color.White, BorderColor = Color.Black, ForeColor = Color.Black },
                        };
                        btn.Click += new EventHandler(BtnAggiungiAlCarrello_Click);

                        pannelloArticolo.Controls.Add(pictureBox);
                        pannelloArticolo.Controls.Add(nomeLabel);
                        pannelloArticolo.Controls.Add(prezzoLabel);
                        pannelloArticolo.Controls.Add(giacenzaLabel);
                        pannelloArticolo.Controls.Add(btn);

                        controlliDaAggiornare.Add(pannelloArticolo);
                    }

                    AggiungiControlliAllaUI(controlliDaAggiornare);

                }));
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    loader.NascondiLoader(this);
                    MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }));
            }
        }

        private void AggiungiControlliAllaUI(List<Control> controlliDaAggiornare)
        {
            PanelProdotti.Controls.Clear();

            if (controlliDaAggiornare.Count == 0)
            {
                Guna2HtmlLabel messaggioNessunProdotto = new Guna2HtmlLabel
                {
                    Text = "Nessun prodotto trovato",
                    Font = new Font("Segoe UI", 36),
                    ForeColor = Color.Red,
                    TextAlignment = ContentAlignment.MiddleCenter,
                    Width = PanelProdotti.Width,
                    AutoSize = false,
                    Location = new Point(0, PanelProdotti.Height / 32 - 40)
                };

                PanelProdotti.Controls.Add(messaggioNessunProdotto);
            }
            else
            {
                foreach (var controllo in controlliDaAggiornare)
                {
                    PanelProdotti.Controls.Add(controllo);
                }
            }

            loader.NascondiLoader(this);
        }

        private void PulisciImmagini()
        {
            foreach (Control controllo in PanelProdotti.Controls)
            {
                if (controllo is Guna2PictureBox pictureBox)
                {
                    pictureBox.Image.Dispose();
                    pictureBox.Image = null;
                }
            }
        }

        private void BtnAggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string codiceArticolo = btn.Name;
            gestoreDelegate.NotificaAggiuntaArticoloAlCarrello(codiceArticolo);
        }
    }
}