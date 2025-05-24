using Guna.UI2.WinForms;
using Microsoft.AspNetCore.Identity;
using Negozio.Controllers;
using Negozio.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Negozio.View.UC
{
    public partial class FrmGestioneAdmin : UserControl
    {

        // VARIABILI GLOBALI
        string tipologia;
        GestoreDbNegozio db = new GestoreDbNegozio();
        GestoreDelegate gestoreDelegate;
        Guna2GradientButton btnPrecedente;
        public FrmGestioneAdmin(GestoreDelegate _gestoreDelegate, string _tipologia)
        {
            InitializeComponent();
            tipologia = _tipologia;
            gestoreDelegate = _gestoreDelegate;

            InizializzaDelegate();
            CaricaCampi();
        }

        // INIZIALIZZAZIONE DELEGATE
        private void InizializzaDelegate()
        {
            gestoreDelegate.OnAdminEvidenziato += EvidenziaAdminDgv;
            gestoreDelegate.OnCommessoEvidenziato += EvidenziaCommessoDgv;
            gestoreDelegate.OnFornitoreEvidenziato += EvidenziaFornitoreDgv;
            gestoreDelegate.OnArticoloEvidenziato += EvidenziaArticoloDgv;
            gestoreDelegate.OnClienteEvidenziato += EvidenziaClienteDgv;
            gestoreDelegate.OnFornitoriModificati += ModificaFornitoreDgv;
            gestoreDelegate.OnCommessiModificati += ModificaCommessoDgv;
            gestoreDelegate.OnArticoliModificati += ModificaArticoloDgv;
            gestoreDelegate.OnClientiModificati += ModificaClienteDgv;
            gestoreDelegate.OnDatiAggiornati += RicaricaDgv;
        }

        private void EvidenziaAdminDgv(string username)
        {
            try
            {
                List<Admin> admins = db.OttieniTuttiGliAmministratori().OrderBy(c => c.Username).ToList();
                Dgv.Rows.Clear();

                int rowIndex = -1;
                for (int i = 0; i < admins.Count; i++)
                {
                    var a = admins[i];
                    Dgv.Rows.Add(a.Username, a.Nome, a.Cognome, a.Email, a.Livello);

                    if (a.Username == username)
                        rowIndex = i;
                }

                Dgv.ClearSelection();
                if (rowIndex >= 0)
                    Dgv.Rows[rowIndex].Selected = true;
            }
            catch (Exception ex)
            {
                MostraErrore(ex);
            }
        }

        // EVENTI DELEGATE
        private void EvidenziaCommessoDgv(string username)
        {
            try
            {
                var commessi = db.OttieniTuttiICommessi().OrderBy(c => c.Username).ToList();
                Dgv.Rows.Clear();

                int rowIndex = -1;
                for (int i = 0; i < commessi.Count; i++)
                {
                    var c = commessi[i];
                    Dgv.Rows.Add(c.Username, c.Nome, c.Cognome, c.Email, c.Turno,
                                 c.DataAssunzione.ToString("dd/MM/yyyy"),
                                 c.OraInizioTurno.ToString(@"hh\:mm"),
                                 c.OraFineTurno.ToString(@"hh\:mm"));

                    if (c.Username == username)
                        rowIndex = i;
                }

                Dgv.ClearSelection();
                if (rowIndex >= 0)
                    Dgv.Rows[rowIndex].Selected = true;
            }
            catch (Exception ex)
            {
                MostraErrore(ex);
            }
        }
        private void EvidenziaFornitoreDgv(string idFornitore)
        {
            try
            {
                Dgv.Rows.Clear();

                List<Fornitore> fornitori = db.OttieniTuttiIFornitori();
                fornitori = fornitori.OrderBy(x => x.IdFornitore).ToList();

                int rigaDaEvidenziare = 0;

                foreach (Fornitore f in fornitori)
                {
                    int indice =
                        Dgv.Rows.Add(f.IdFornitore, f.NomeAzienda, f.Indirizzo, f.StampaNumeroDiTelefono(), f.Email, f.TipoFornimento);
                    if (f.IdFornitore == idFornitore)
                    {
                        rigaDaEvidenziare = indice;
                    }
                }

                Dgv.ClearSelection();
                if (rigaDaEvidenziare != 0)
                    Dgv.Rows[rigaDaEvidenziare].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EvidenziaArticoloDgv(string codiceArticolo)
        {
            try
            {
                Dgv.Rows.Clear();

                List<Articolo> articoli = db.OttieniTuttiGliArticoli();
                articoli = articoli.OrderBy(x => x.CodiceArticolo).ToList();

                int rigaDaEvidenziare = 0;

                foreach (Articolo a in articoli)
                {
                    int indice = Dgv.Rows.Add(a.CodiceArticolo, a.IdFornitore, a.DescrizioneArticolo, a.PrezzoArticolo, a.Quantita, a.Iva, a.Categoria);
                    if (a.CodiceArticolo == codiceArticolo)
                        rigaDaEvidenziare = indice;
                    if (a.Quantita < 5)
                        Dgv.Rows[indice].DefaultCellStyle.BackColor = Color.OrangeRed;
                    else
                        Dgv.Rows[indice].DefaultCellStyle.BackColor = Color.LightGreen;
                }

                Dgv.ClearSelection();
                if (rigaDaEvidenziare != 0)
                    Dgv.Rows[rigaDaEvidenziare].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EvidenziaClienteDgv(int codiceCliente)
        {
            try
            {
                Dgv.Rows.Clear();

                List<Cliente> clienti = db.OttieniTuttiIClienti();
                clienti = clienti.OrderBy(x => x.CodiceFedelta).ToList();

                int rigaDaEvidenziare = 0;

                foreach (Cliente c in clienti)
                {
                    int indice = Dgv.Rows.Add(c.CodiceFedelta, c.Nome, c.Cognome, c.Email,
                                 c.Telefono);
                    if (c.CodiceFedelta == codiceCliente)
                        rigaDaEvidenziare = indice;
                }

                Dgv.ClearSelection();
                if (rigaDaEvidenziare != 0)
                    Dgv.Rows[rigaDaEvidenziare].Selected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ModificaArticoloDgv(List<Articolo> articoli)
        {
            Dgv.Rows.Clear();
            foreach (Articolo a in articoli)
            {
                int indice = Dgv.Rows.Add(a.CodiceArticolo, db.OttieniFornitore(a.IdFornitore).NomeAzienda, a.DescrizioneArticolo, a.PrezzoArticolo, a.Quantita, a.Iva, a.Categoria);
                if (a.Quantita < 5)
                    Dgv.Rows[indice].DefaultCellStyle.BackColor = Color.OrangeRed;
                else
                    Dgv.Rows[indice].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            Dgv.ClearSelection();
        }
        private void ModificaCommessoDgv(List<Commesso> commessi)
        {
            Dgv.Rows.Clear();
            foreach (Commesso c in commessi)
                Dgv.Rows.Add(c.Username, c.Nome, c.Cognome, c.Email, c.Turno,
                                c.DataAssunzione.ToString("dd/MM/yyyy"),
                                c.OraInizioTurno.ToString(@"hh\:mm"),
                                c.OraFineTurno.ToString(@"hh\:mm"));
            Dgv.ClearSelection();
        }
        private void ModificaFornitoreDgv(List<Fornitore> fornitori)
        {
            Dgv.Rows.Clear();
            foreach (Fornitore f in fornitori)
                Dgv.Rows.Add(f.IdFornitore, f.NomeAzienda, f.Indirizzo, f.TelefonoAzienda, f.Email, f.TipoFornimento);
            Dgv.ClearSelection();
        }
        private void ModificaClienteDgv(List<Cliente> clienti)
        {
            Dgv.Rows.Clear();
            foreach (Cliente c in clienti)
                Dgv.Rows.Add(c.CodiceFedelta, c.Nome, c.Cognome, c.Email, c.StampaNumeroDiTelefono());
            Dgv.ClearSelection();
        }
        private void RicaricaDgv()
        {
            try
            {
                if (tipologia == "Commessi")
                    CaricaDatiCommessi(db.OttieniTuttiICommessi().OrderBy(c => c.Username).ToList());
                else if (tipologia == "Fornitori")
                    CaricaDatiFornitori(db.OttieniTuttiIFornitori().OrderBy(f => f.IdFornitore).ToList());
                else if (tipologia == "Magazzino")
                    CaricaDatiMagazzino(db.OttieniTuttiGliArticoli().OrderBy(a => a.CodiceArticolo).ToList());
                else if (tipologia == "Clienti")
                    CaricaDatiClienti(db.OttieniTuttiIClienti().OrderBy(c => c.CodiceFedelta).ToList());
                else if (tipologia == "Admin")
                    CaricaDAtiAdmin(db.OttieniTuttiGliAmministratori().OrderBy(a => a.Username).ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // CARICARE L' USERCONTROL
        private void CaricaCampi()
        {
            if (tipologia == "Commessi")
                SetupGestioneCommessi();
            else if (tipologia == "Fornitori")
                SetupGestioneFornitori();
            else if (tipologia == "Magazzino")
                SetupGestioneMagazzino();
            else if (tipologia == "Clienti")
                SetupGestioneClienti();
            else if (tipologia == "Admin")
                SetupGestioneAdmin();
        }

        private void SetupGestioneAdmin()
        {
            try
            {
                IntestaDgv("USERNAME", "NOME", "COGNOME", "EMAIL", "LIVELLO DI AMMMINISTRAZIONE");
                CaricaDAtiAdmin(db.OttieniTuttiGliAmministratori().OrderBy(a => a.Username).ToList());
                ConfiguraTesti("LISTA ADMIN", "GESTIONE ADMIN", "NUOVO ADMIN", "MODIFICA ADMIN", "RIMUOVI ADMIN");

                BtnNuovo.Click += (s, e) => ApriPannello(new FrmAggiuntaAdmin(gestoreDelegate), BtnNuovo);
                BtnModifica.Click += (s, e) => ApriPannello(new FrmModificaAdmin(gestoreDelegate, null), BtnModifica);
                BtnElimina.Click += (s, e) => ApriPannello(new FrmEliminaAdmin(gestoreDelegate), BtnElimina);

                Dgv.CellClick += DgvAdmin_CellClick;

                btnPrecedente = BtnNuovo;
                ApriPannello(new FrmAggiuntaAdmin(gestoreDelegate), BtnNuovo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedValue = Dgv.Rows[e.RowIndex].Cells[0].Value?.ToString();

                ApriPannello(new FrmModificaAdmin(gestoreDelegate, selectedValue), BtnModifica);
            }
        }

        private void SetupGestioneClienti()
        {
            try
            {
                IntestaDgv("CODICE CARTA FEDELTA'", "NOME", "COGNOME", "EMAIL", "TELEFONO");
                CaricaDatiClienti(db.OttieniTuttiIClienti().OrderBy(x => x.CodiceFedelta).ToList());
                ConfiguraTesti("LISTA CLIENTI", "GESTIONE CLIENTI", "NUOVO CLIENTE", "MODIFICA CLIENTE", "RIMUOVI CLIENTE");

                BtnNuovo.Click += (s, e) => ApriPannello(new FrmAggiuntaCliente(gestoreDelegate), BtnNuovo);
                BtnModifica.Click += (s, e) => ApriPannello(new FrmModificaCliente(gestoreDelegate, null), BtnModifica);
                BtnElimina.Click += (s, e) => ApriPannello(new FrmEliminaCliente(gestoreDelegate), BtnElimina);

                Dgv.CellClick += DgvClienti_CellClick;

                btnPrecedente = BtnNuovo;
                ApriPannello(new FrmAggiuntaCliente(gestoreDelegate), BtnNuovo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DgvClienti_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedValue = Dgv.Rows[e.RowIndex].Cells[0].Value?.ToString();

                ApriPannello(new FrmModificaCliente(gestoreDelegate, selectedValue), BtnModifica);
            }
        }
        private void SetupGestioneMagazzino()
        {
            try
            {
                IntestaDgv("CODICE ARTICOLO", "FORNITORE", "DESCRIZIONE ARTICOLO", "PREZZO ARTICOLO", "QUANTITA", "IVA", "CATEGORIA");
                CaricaDatiMagazzino(db.OttieniTuttiGliArticoli().OrderBy(x => x.CodiceArticolo).ToList());
                ConfiguraTesti("LISTA PRODOTTI", "GESTIONE MAGAZZINO", "NUOVO PRODOTTO", "MODIFICA PRODOTTO", "RIMUOVI QUANTITA' PRODOTTO");

                BtnNuovo.Click += (s, e) => ApriPannello(new FrmAggiuntaArticolo(gestoreDelegate), BtnNuovo);
                BtnModifica.Click += (s, e) => ApriPannello(new FrmModificaArticolo(gestoreDelegate, null), BtnModifica);
                BtnElimina.Click += (s, e) => ApriPannello(new FrmEliminaArticolo(gestoreDelegate), BtnElimina);

                Dgv.CellClick += DgvArticoli_CellClick;

                btnPrecedente = BtnNuovo;
                ApriPannello(new FrmAggiuntaArticolo(gestoreDelegate), BtnNuovo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DgvArticoli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedValue = Dgv.Rows[e.RowIndex].Cells[0].Value?.ToString();

                ApriPannello(new FrmModificaArticolo(gestoreDelegate, selectedValue), BtnModifica);
            }
        }
        private void SetupGestioneCommessi()
        {
            try
            {
                IntestaDgv("USERNAME", "NOME", "COGNOME", "EMAIL", "TURNO", "DATA ASSUNZIONE", "ORARIO INIZIO", "ORARIO FINE");
                CaricaDatiCommessi(db.OttieniTuttiICommessi().OrderBy(x => x.Username).ToList());
                ConfiguraTesti("LISTA COMMESSI", "GESTIONE COMMESSI", "NUOVO COMMESSO", "MODIFICA COMMESSO", "RIMUOVI COMMESSO");

                BtnNuovo.Click += (s, e) => ApriPannello(new FrmAggiuntaCommesso(gestoreDelegate), BtnNuovo);
                BtnModifica.Click += (s, e) => ApriPannello(new FrmModificaCommesso(gestoreDelegate, null), BtnModifica);
                BtnElimina.Click += (s, e) => ApriPannello(new FrmEliminaCommesso(gestoreDelegate), BtnElimina);

                Dgv.CellClick += DgvCommessi_CellClick;

                btnPrecedente = BtnNuovo;
                ApriPannello(new FrmAggiuntaCommesso(gestoreDelegate), BtnNuovo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DgvCommessi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedValue = Dgv.Rows[e.RowIndex].Cells[0].Value?.ToString();

                ApriPannello(new FrmModificaCommesso(gestoreDelegate, selectedValue), BtnModifica);
            }
        }
        private void SetupGestioneFornitori()
        {
            try
            {
                IntestaDgv("ID DEL FORNITORE", "NOME DELL'AZIENDA", "INDIRIZZO", "TELEFONO", "EMAIL", "TIPO FORNIMENTO");
                CaricaDatiFornitori(db.OttieniTuttiIFornitori().OrderBy(f => f.IdFornitore).ToList());
                ConfiguraTesti("LISTA FORNITORI", "GESTIONE FORNITORI", "NUOVO FORNITORE", "MODIFICA FORNITORE", "RIMUOVI FORNITORE");

                BtnNuovo.Click += (s, e) => ApriPannello(new FrmAggiuntaFornitore(gestoreDelegate), BtnNuovo);
                BtnModifica.Click += (s, e) => ApriPannello(new FrmModficaFornitore(gestoreDelegate, null), BtnModifica);
                BtnElimina.Click += (s, e) => ApriPannello(new FrmEliminaFornitore(gestoreDelegate), BtnElimina);

                Dgv.CellClick += DgvFornitori_CellClick;

                btnPrecedente = BtnNuovo;
                ApriPannello(new FrmAggiuntaFornitore(gestoreDelegate), BtnNuovo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DgvFornitori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedValue = Dgv.Rows[e.RowIndex].Cells[0].Value?.ToString();

                ApriPannello(new FrmModficaFornitore(gestoreDelegate, selectedValue), BtnModifica);
            }
        }
        private void BtnModificaFornitore_Click(object sender, EventArgs e)
        {
            if (!db.OttieniTuttiIFornitori().Any())
            {
                MessageBox.Show("Devi inserire almeno un fornitore", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApriPannello(new FrmAggiuntaFornitore(gestoreDelegate), BtnModifica);
        }

        // INIZIALIZZA DGV
        private void IntestaDgv(params string[] intestazioni)
        {
            Dgv.Columns.Clear();
            foreach (string header in intestazioni)
            {
                Dgv.Columns.Add(header, header);
            }

            Dgv.RowHeadersVisible = false;
            Dgv.ReadOnly = true;
            Dgv.AllowUserToAddRows = false;
            Dgv.AllowUserToDeleteRows = false;
            Dgv.AllowUserToResizeColumns = false;
            Dgv.AllowUserToResizeRows = false;
            Dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Dgv.MultiSelect = false;
            Dgv.RowTemplate.Height = 28;
            Dgv.ColumnHeadersHeight = 40;
            Dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CaricaDatiCommessi(List<Commesso> lista)
        {

            Dgv.Rows.Clear();
            foreach (var c in lista)
            {
                Dgv.Rows.Add(c.Username, c.Nome, c.Cognome, c.Email,
                             c.Turno,
                             c.DataAssunzione.ToString("dd/MM/yyyy"),
                             c.OraInizioTurno.ToString(@"hh\:mm"),
                             c.OraFineTurno.ToString(@"hh\:mm"));
            }
            Dgv.ClearSelection();

        }
        private void CaricaDatiClienti(List<Cliente> clienti)
        {

            Dgv.Rows.Clear();
            foreach (var c in clienti)
            {
                Dgv.Rows.Add(c.CodiceFedelta, c.Nome, c.Cognome, c.Email,
                             c.StampaNumeroDiTelefono());
            }
            Dgv.ClearSelection();

        }
        private void CaricaDatiMagazzino(List<Articolo> articolos)
        {
            Dgv.Rows.Clear();

            List<Articolo> lstArticoli = db.OttieniTuttiGliArticoli();
            foreach (Articolo a in lstArticoli)
            {
                int rowIndex = Dgv.Rows.Add(a.CodiceArticolo, db.OttieniFornitore(a.IdFornitore).NomeAzienda, a.DescrizioneArticolo, a.PrezzoArticolo, a.Quantita, a.Iva, a.Categoria);
                if (a.Quantita < 5)
                    Dgv.Rows[rowIndex].DefaultCellStyle.BackColor = Color.OrangeRed;
                else
                    Dgv.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
            }
            Dgv.ClearSelection();

        }
        private void CaricaDatiFornitori(List<Fornitore> lista)
        {
            Dgv.Rows.Clear();
            foreach (var f in lista)
            {
                Dgv.Rows.Add(f.IdFornitore, f.NomeAzienda, f.Indirizzo, f.StampaNumeroDiTelefono(), f.Email, f.TipoFornimento);
            }
            Dgv.ClearSelection();
        }
        private void CaricaDAtiAdmin(List<Admin> amministatori)
        {
            Dgv.Rows.Clear();
            foreach (var a in amministatori)
            {
                Dgv.Rows.Add(a.Username, a.Nome, a.Cognome, a.Email, a.Livello);
            }
            Dgv.ClearSelection();
        }

        private void ApriPannello(Control controllo, Guna2GradientButton bottone)
        {
            ColoreDisattivato(btnPrecedente);
            ColoreAttivato(bottone);
            btnPrecedente = bottone;

            PanelEdit.Controls.Clear();
            PanelEdit.Controls.Add(controllo);
            PanelEdit.BringToFront();
        }
        private void ConfiguraTesti(string titoloDgv, string titoloPulsanti, string testoNuovo, string testoModifica, string testoElimina)
        {
            GbDgv.Text = titoloDgv;
            GbPulsanti.Text = titoloPulsanti;
            BtnNuovo.Text = testoNuovo;
            BtnModifica.Text = testoModifica;
            BtnElimina.Text = testoElimina;
        }

        private void ColoreAttivato(Guna2GradientButton btn)
        {
            btn.FillColor = Color.Silver;
            btn.FillColor2 = Color.Silver;
            btn.BorderColor = Color.Black;
            btn.ForeColor = Color.Black;
        }
        private void ColoreDisattivato(Guna2GradientButton btn)
        {
            btn.FillColor = Color.Gray;
            btn.FillColor2 = Color.Gray;
            btn.BorderColor = Color.Black;
        }
        private void MostraErrore(Exception ex)
        {
            MessageBox.Show(ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
