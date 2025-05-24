using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Identity;
using Negozio.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Negozio.Controllers
{
    public class GestoreDbNegozio
    {
        // Variabili globali
        static Random rnd = new Random();
        private SqlConnection _sqlConnetion;
        private SqlCommand _sqlCommand;
        private readonly string nomeDb = Application.StartupPath + @"\DbNegozio.mdf";
        private string _strConn;
        private PasswordHasher<Utente> _passwordHasher = new PasswordHasher<Utente>();

        // Connessione al db
        private void Connetti()
        {
            _strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + nomeDb
                + ";Integrated Security=True;Connect Timeout=30";
            _sqlConnetion = new SqlConnection(_strConn);
            _sqlConnetion.Open();
        }

        // Disconnessione dal db
        private void Disconnetti()
        {
            _sqlConnetion.Close();
        }

        // LOGIN

        // Accesso utente
        public Utente Login(string username, string password)
        {
            try
            {
                Connetti(); // Apre la connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per ottenere l'utente con lo username fornito
                string query = "Select * from Utenti where Utenti.Username = @username";
                _sqlCommand.Parameters.AddWithValue("@username", username);
                _sqlCommand.CommandText = query;

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                if (!_dr.HasRows)
                    throw new Exception("Errore campi username o password non corretti");
                _dr.Read();

                string hashedPassword = _dr["Pwd"].ToString();
                string tipo = _dr["Tipologia"].ToString();
                _dr.Close();

                Utente utente = null;

                // Controllo del tipo di utente e verifica della password
                if (tipo == "AM")
                {
                    Admin admin = OttieniAmministratore(username);
                    if (_passwordHasher.VerifyHashedPassword(admin, hashedPassword, password) == PasswordVerificationResult.Success)
                        utente = admin;
                    else
                        throw new Exception("Errore campi username o password non corretti");
                }
                else
                {
                    Commesso commesso = OttieniCommesso(username);
                    if (_passwordHasher.VerifyHashedPassword(commesso, hashedPassword, password) == PasswordVerificationResult.Success)
                        utente = commesso;
                    else
                        throw new Exception("Errore campi username o password non corretti");
                }

                return utente; // Login riuscito
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione al database
            }
        }
        public void ModificaPassword(string txtNuovaPassword, string txtPasswordCorrente, Utente utenteLoggato)
        {
            try
            {
                Connetti(); // Apre la connessione

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Ottiene la password attuale dal database
                string query = "Select * from Utenti where Utenti.Username = @username";
                _sqlCommand.Parameters.AddWithValue("@username", utenteLoggato.Username);
                _sqlCommand.CommandText = query;

                SqlDataReader _dr = _sqlCommand.ExecuteReader();
                _dr.Read();

                string hashedPassword = _dr["Pwd"].ToString();
                _dr.Close();
                Disconnetti(); // Chiude la connessione dopo la lettura

                // Verifica della password corrente
                if (_passwordHasher.VerifyHashedPassword(utenteLoggato, hashedPassword, txtPasswordCorrente) == PasswordVerificationResult.Success)
                {
                    hashedPassword = _passwordHasher.HashPassword(utenteLoggato, txtNuovaPassword);

                    Connetti(); // Riapre la connessione per l'update
                    _sqlCommand = new SqlCommand();
                    _sqlCommand.Connection = _sqlConnetion;
                    _sqlCommand.CommandType = CommandType.Text;

                    // Aggiorna la password nel database
                    query = "update Utenti set Utenti.Pwd = @nuovaPassword where Utenti.username = @username";
                    _sqlCommand.Parameters.AddWithValue("@username", utenteLoggato.Username);
                    _sqlCommand.Parameters.AddWithValue("@nuovaPassword", hashedPassword);

                    _sqlCommand.CommandText = query;
                    _sqlCommand.ExecuteNonQuery();
                }
                else
                    throw new Exception("Errore la password corrente non corrisponde");
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione al database
            }
        }

        // OTTIENI

        public List<Articolo> OttieniArticoliCategoria(string categoria)
        {
            try
            {
                Connetti(); // Apre la connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per selezionare tutti gli articoli della categoria specificata
                string query = "select Magazzino.* from Magazzino where Magazzino.Categoria = @categoria";
                _sqlCommand.Parameters.AddWithValue("@categoria", categoria);
                _sqlCommand.CommandText = query;

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                List<Articolo> articoli = new List<Articolo>();

                // Popola la lista di articoli leggendo i risultati
                while (_dr.Read())
                {
                    articoli.Add(new Articolo(
                        _dr["CodiceArticolo"].ToString(),
                        _dr["IdFornitore"].ToString(),
                        _dr["DescrizioneArticolo"].ToString(),
                        (double)_dr["PrezzoArticolo"],
                        (int)_dr["Quantita"],
                        (int)_dr["Iva"],
                        _dr["Categoria"].ToString(),
                        _dr["Immagine"].ToString()));
                }

                _dr.Close();
                return articoli;
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }
        public string[] OttieniCategorie()
        {
            try
            {
                Connetti(); // Apre la connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per ottenere le categorie di fornitura uniche
                string query = "select distinct Fornitori.TipoFornimento from Fornitori";
                _sqlCommand.CommandText = query;

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                List<string> categorie = new List<string>();

                // Aggiunge le categorie uniche alla lista
                while (_dr.Read())
                {
                    categorie.Add(_dr["TipoFornimento"].ToString());
                }

                _dr.Close();
                return categorie.ToArray(); // Restituisce l'array di categorie
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }
        public Commesso OttieniCommesso(string username)
        {
            try
            {
                Connetti(); // Apre la connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per ottenere le informazioni del commesso in base allo username
                string query = "select * from Commessi where Commessi.Username = @Username";
                _sqlCommand.Parameters.AddWithValue("@Username", username);

                _sqlCommand.CommandText = query;

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                _dr.Read();

                // Estrae i dati per creare l'oggetto Commesso
                string nome = _dr["Nome"].ToString();
                string cognome = _dr["Cognome"].ToString();
                string email = _dr["Email"].ToString();
                string turno = _dr["Turno"].ToString();
                DateTime dataAssunzione = Convert.ToDateTime(_dr["DataAssunzione"]);
                TimeSpan orarioInizioTurno = TimeSpan.Parse(_dr["OrarioInizio"].ToString());
                TimeSpan orarioFineTurno = TimeSpan.Parse(_dr["OrarioFine"].ToString());

                _dr.Close();

                // Restituisce l'oggetto Commesso con i dati recuperati
                return new Commesso(username, nome, cognome, email, turno, dataAssunzione, orarioInizioTurno, orarioFineTurno);
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude il collegamento
            }
        }
        public Cliente OttieniCliente(string codice)
        {
            try
            {
                Connetti(); // Apre la connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per ottenere i dettagli del cliente con il codice carta fedeltà
                string query = "select * from Clienti where Clienti.CodiceCartaFedelta = @codice";
                _sqlCommand.Parameters.AddWithValue("@codice", codice);

                _sqlCommand.CommandText = query;

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                _dr.Read();

                // Estrae i dati per creare l'oggetto Cliente
                string nome = _dr["Nome"].ToString();
                string cognome = _dr["Cognome"].ToString();
                string email = _dr["Email"].ToString();
                string telefono = _dr["Telefono"].ToString();
                int codiceCartaFedelta = (int)_dr["CodiceCartaFedelta"];
                DateTime dataCreazione = Convert.ToDateTime(_dr["DataInserimento"]);
                _dr.Close();

                // Restituisce un oggetto Cliente con i dati recuperati
                return new Cliente(codiceCartaFedelta, nome, cognome, email, telefono, dataCreazione);
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }
        public Admin OttieniAmministratore(string username)
        {
            try
            {
                Connetti(); // Apre la connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per ottenere i dettagli dell'amministratore in base allo username
                string query = "select * from Admin where Admin.Username = @Username";
                _sqlCommand.Parameters.AddWithValue("@Username", username);

                _sqlCommand.CommandText = query;

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                _dr.Read();

                // Estrae i dati per creare l'oggetto Admin
                string nome = _dr["Nome"].ToString();
                string cognome = _dr["Cognome"].ToString();
                string email = _dr["Email"].ToString();
                int livello = (int)_dr["Livello"];

                _dr.Close();

                // Restituisce un oggetto Admin con i dati recuperati
                return new Admin(username, nome, cognome, email, livello);
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }
        internal List<Admin> OttieniTuttiGliAmministratori()
        {
            try
            {
                Connetti(); // Apre la connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per ottenere tutti gli amministratori
                string query = "select * from Admin";
                _sqlCommand.CommandText = query;

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                List<Admin> temp = new List<Admin>();

                // Legge ogni cliente e lo aggiunge alla lista
                while (_dr.Read())
                {
                    temp.Add(new Admin(
                        _dr["Username"].ToString(),
                        _dr["Nome"].ToString(),
                        _dr["Cognome"].ToString(),
                        _dr["Email"].ToString(),
                        (int)_dr["Livello"]));
                }

                return temp; // Restituisce la lista dei clienti
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }
        public List<Cliente> OttieniTuttiIClienti()
        {
            try
            {
                Connetti(); // Apre la connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per ottenere tutti i clienti
                string query = "select * from Clienti";
                _sqlCommand.CommandText = query;

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                List<Cliente> temp = new List<Cliente>();

                // Legge ogni cliente e lo aggiunge alla lista
                while (_dr.Read())
                {
                    temp.Add(new Cliente(
                        (int)_dr["CodiceCartaFedelta"],
                        _dr["Nome"].ToString(),
                        _dr["Cognome"].ToString(),
                        _dr["Email"].ToString(),
                        _dr["Telefono"].ToString(),
                        Convert.ToDateTime(_dr["DataInserimento"])));
                }

                return temp; // Restituisce la lista dei clienti
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }
        public Articolo OttieniArticolo(string codiceArticolo)
        {
            try
            {
                Connetti(); // Apre la connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per ottenere i dettagli dell'articolo in base al codice
                string query = "select * from Magazzino where Magazzino.CodiceArticolo = @codice";
                _sqlCommand.Parameters.AddWithValue("@codice", codiceArticolo);
                _sqlCommand.CommandText = query;

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                _dr.Read();

                // Estrae i dati per creare l'oggetto Articolo
                string idFornitore = _dr["IdFornitore"].ToString();
                string descrizioneArticolo = _dr["DescrizioneArticolo"].ToString();
                double prezzo = (double)_dr["PrezzoArticolo"];
                int quantita = (int)_dr["Quantita"];
                int iva = (int)_dr["Iva"];
                string categoria = _dr["Categoria"].ToString();
                string immagine = _dr["Immagine"].ToString();

                _dr.Close();

                // Restituisce l'oggetto Articolo con i dati recuperati
                return new Articolo(codiceArticolo, idFornitore, descrizioneArticolo, prezzo, quantita, iva, categoria, immagine);
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }
        public List<Commesso> OttieniTuttiICommessi()
        {
            List<Commesso> temp = new List<Commesso>();
            try
            {
                Connetti(); // Connessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                string query = "select * from Commessi"; // Query per ottenere tutti i commessi
                _sqlCommand.CommandText = query;
                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                if (_dr.HasRows)
                {
                    while (_dr.Read()) // Crea un oggetto Commesso e aggiungilo alla lista
                    {
                        Commesso commesso = new Commesso(
                            _dr["Username"].ToString(),
                            _dr["Nome"].ToString(),
                            _dr["Cognome"].ToString(),
                            _dr["Email"].ToString(),
                            _dr["Turno"].ToString(),
                            Convert.ToDateTime(_dr["DataAssunzione"]),
                            TimeSpan.Parse(_dr["OrarioInizio"].ToString()),
                            TimeSpan.Parse(_dr["OrarioFine"].ToString())
                        );
                        temp.Add(commesso);
                    }
                    _dr.Close();
                }
                return temp; // Restituisce la lista di commessi
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }
        public List<Fornitore> OttieniTuttiIFornitori()
        {
            List<Fornitore> temp = new List<Fornitore>();
            try
            {
                Connetti(); // Connessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                string query = "select * from Fornitori"; // Query per ottenere tutti i fornitori
                _sqlCommand.CommandText = query;
                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                if (_dr.HasRows)
                {
                    while (_dr.Read()) // Per ogni riga, crea un oggetto Fornitore e aggiungilo alla lista
                    {
                        Fornitore fornitore = new Fornitore(
                            _dr["IdFornitore"].ToString(),
                            _dr["NomeAzienda"].ToString(),
                            _dr["Indirizzo"].ToString(),
                            _dr["TelefonoAzienda"].ToString(),
                            _dr["Email"].ToString(),
                            _dr["TipoFornimento"].ToString()
                        );
                        temp.Add(fornitore);
                    }
                    _dr.Close();
                }
                return temp; // Restituisce la lista di fornitori
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }
        internal List<Fattura> OttieniFattureDelMese(int mese, int anno)
        {
            List<Fattura> fatture = new List<Fattura>(); // Lista per memorizzare le fatture

            try
            {
                Connetti(); // Connessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per ottenere tutte le fatture del mese e anno
                string query = "SELECT * FROM Fatture WHERE MONTH(DataFattura) = @Mese AND YEAR(DataFattura) = @Anno";
                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@Mese", mese);
                _sqlCommand.Parameters.AddWithValue("@Anno", anno);

                // Esegui la query e ottieni i risultati
                SqlDataReader dr = _sqlCommand.ExecuteReader();

                // Se ci sono righe nel reader
                while (dr.Read())
                {
                    int codice = 0;
                    if (dr["CodiceCartaFedelta"] != DBNull.Value)
                        codice = (int)dr["CodiceCartaFedelta"];
                    fatture.Add(new Fattura(dr["NumeroFattura"].ToString(), Convert.ToDateTime(dr["DataFattura"]), Convert.ToDouble(dr["TotaleComplessivo"]), Convert.ToDouble(dr["Pagamento"]
                        ), Convert.ToDouble(dr["Resto"]), dr["MetodoDiPagamento"].ToString(), codice, Convert.ToDouble(dr["IvaTotale"])));
                }

                // Restituisci la lista di fatture
                return fatture;
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }
        internal List<Commesso> OttieniCommessiDelMese(int mese, int anno)
        {
            try
            {
                Connetti(); // Apre la connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query filtrata per mese e anno
                string query = @"SELECT * FROM Commessi 
                         WHERE MONTH(DataAssunzione) = @Mese 
                         AND YEAR(DataAssunzione) = @Anno";
                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@Mese", mese);
                _sqlCommand.Parameters.AddWithValue("@Anno", anno);

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                List<Commesso> temp = new List<Commesso>();

                while (_dr.Read())
                {
                    temp.Add(new Commesso(
                        _dr["Username"].ToString(),
                        _dr["Nome"].ToString(),
                        _dr["Cognome"].ToString(),
                        _dr["Email"].ToString(),
                        _dr["Turno"].ToString(),
                        Convert.ToDateTime(_dr["DataAssunzione"]),
                        TimeSpan.Parse(_dr["OrarioInizio"].ToString()),
                        TimeSpan.Parse(_dr["OrarioFine"].ToString())));
                }

                return temp;
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }
        internal List<Cliente> OttieniClientiDelMese(int mese, int anno)
        {
            try
            {
                Connetti(); // Apre la connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query filtrata per mese e anno
                string query = @"SELECT * FROM Clienti 
                         WHERE MONTH(DataInserimento) = @Mese 
                         AND YEAR(DataInserimento) = @Anno";
                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@Mese", mese);
                _sqlCommand.Parameters.AddWithValue("@Anno", anno);

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                List<Cliente> temp = new List<Cliente>();

                while (_dr.Read())
                {
                    temp.Add(new Cliente(
                        (int)_dr["CodiceCartaFedelta"],
                        _dr["Nome"].ToString(),
                        _dr["Cognome"].ToString(),
                        _dr["Email"].ToString(),
                        _dr["Telefono"].ToString(),
                        Convert.ToDateTime(_dr["DataInserimento"])));
                }

                return temp;
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }

        internal List<Articolo> OttieniTuttiGliArticoliInEsaurimento()
        {
            List<Articolo> temp = new List<Articolo>();
            try
            {
                Connetti(); // Connessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                string query = "select * from Magazzino WHERE Quantita <= 3"; // Query per ottenere tutti gli articoli in esaurimento
                _sqlCommand.CommandText = query;
                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                if (_dr.HasRows)
                {
                    while (_dr.Read()) // Per ogni riga, crea un oggetto Articolo e aggiungilo alla lista
                    {
                        Articolo articolo = new Articolo(
                            _dr["CodiceArticolo"].ToString(),
                            _dr["IdFornitore"].ToString(),
                            _dr["DescrizioneArticolo"].ToString(),
                            (double)_dr["PrezzoArticolo"],
                            (int)_dr["Quantita"],
                            (int)_dr["Iva"],
                            _dr["Categoria"].ToString(),
                            _dr["Immagine"].ToString()
                        );
                        temp.Add(articolo);
                    }
                    _dr.Close();
                }
                return temp; // Restituisce la lista di articoli
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura connessione
            }
        }
        public List<Articolo> OttieniTuttiGliArticoli()
        {
            List<Articolo> temp = new List<Articolo>();
            try
            {
                Connetti(); // Connessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                string query = "select * from Magazzino"; // Query per ottenere tutti gli articoli
                _sqlCommand.CommandText = query;
                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                if (_dr.HasRows)
                {
                    while (_dr.Read()) // Per ogni riga, crea un oggetto Articolo e aggiungilo alla lista
                    {
                        Articolo articolo = new Articolo(
                            _dr["CodiceArticolo"].ToString(),
                            _dr["IdFornitore"].ToString(),
                            _dr["DescrizioneArticolo"].ToString(),
                            (double)_dr["PrezzoArticolo"],
                            (int)_dr["Quantita"],
                            (int)_dr["Iva"],
                            _dr["Categoria"].ToString(),
                            _dr["Immagine"].ToString()
                        );
                        temp.Add(articolo);
                    }
                    _dr.Close();
                }
                return temp; // Restituisce la lista di articoli
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura connessione
            }
        }
        public Fornitore OttieniFornitore(string idFornitore)
        {
            try
            {
                Connetti(); // Connessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per ottenere il fornitore specifico tramite ID
                string query = "select * from Fornitori where Fornitori.IdFornitore = @idFornitore";
                _sqlCommand.Parameters.AddWithValue("@idFornitore", idFornitore);
                _sqlCommand.CommandText = query;

                SqlDataReader _dr = _sqlCommand.ExecuteReader();

                _dr.Read();

                Fornitore fornitore = new Fornitore(
                    idFornitore,
                    _dr["NomeAzienda"].ToString(),
                    _dr["Indirizzo"].ToString(),
                    _dr["TelefonoAzienda"].ToString(),
                    _dr["Email"].ToString(),
                    _dr["TipoFornimento"].ToString()
                );
                _dr.Close();

                return fornitore; // Restituisce il fornitore
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiude la connessione
            }
        }

        // AGGIUNGI

        public int AggiungiCliente(string nome, string cognome, string email, string telefono)
        {
            int codiceCartaFedelta = GeneraCodiceCarta(); // Genera un codice unico per la carta fedeltà

            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query di inserimento
                string query = @"INSERT INTO Clienti (CodiceCartaFedelta, Nome, Cognome, Email, Telefono, DataInserimento) VALUES (@codice, @nome, @cognome, @email, @telefono, @DataInserimento)";
                _sqlCommand.CommandText = query;

                // Parametri per prevenire SQL Injection
                _sqlCommand.Parameters.AddWithValue("@codice", codiceCartaFedelta);
                _sqlCommand.Parameters.AddWithValue("@nome", nome);
                if (string.IsNullOrEmpty(cognome))
                    _sqlCommand.Parameters.AddWithValue("@cognome", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@cognome", cognome);
                _sqlCommand.Parameters.AddWithValue("@email", email);
                _sqlCommand.Parameters.AddWithValue("@telefono", telefono);
                _sqlCommand.Parameters.AddWithValue("@DataInserimento", DateTime.Now.Date);
                _sqlCommand.ExecuteNonQuery();

                return codiceCartaFedelta;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    throw new Exception("Email già registrata nel sistema.");
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }
        internal void AggiungiAdmin(string nome, string cognome, string email, string password, string username, int livello)
        {
            SqlTransaction _sqlTransaction = null;
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                _sqlTransaction = _sqlConnetion.BeginTransaction();
                _sqlCommand.Transaction = _sqlTransaction;

                // Aggiungi l'utente
                Utente u = new Utente(username, nome, cognome, email);
                string hashedPassword = _passwordHasher.HashPassword(u, password);

                string query = @"INSERT INTO Utenti(Username, Pwd, Tipologia) VALUES(@Username, @pwd, @Tipo)";
                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@Username", username);
                _sqlCommand.Parameters.AddWithValue("@pwd", hashedPassword);
                _sqlCommand.Parameters.AddWithValue("@Tipo", "AM");

                _sqlCommand.ExecuteNonQuery();
                _sqlCommand.Parameters.Clear();

                // Aggiungi l' Admin
                query = @"INSERT INTO Admin(Username, Nome, Cognome, Email, Livello)
                  VALUES (@Username, @nome, @cognome, @email, @livello)";
                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@Username", username);
                if (string.IsNullOrEmpty(nome))
                    _sqlCommand.Parameters.AddWithValue("@nome", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@nome", nome);
                if (string.IsNullOrEmpty(cognome))
                    _sqlCommand.Parameters.AddWithValue("@cognome", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@cognome", cognome);
                _sqlCommand.Parameters.AddWithValue("@email", email);
                _sqlCommand.Parameters.AddWithValue("@livello", livello);

                _sqlCommand.ExecuteNonQuery();
                _sqlTransaction.Commit();
            }
            catch (SqlException ex)
            {
                _sqlTransaction?.Rollback();
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("PK_Utente"))
                        throw new Exception("Utente con username: " + username + " già esistente");

                    if (ex.Message.Contains("UQ_Admin_Email"))
                        throw new Exception("Email: " + email + " già registrata");
                }
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti();
            }
        }
        public void AggiungiCommesso(string nome, string cognome, string email, string password, string username, string turno, DateTime assuntoIl, TimeSpan oraInizio, TimeSpan oraFine)
        {
            SqlTransaction _sqlTransaction = null;
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                _sqlTransaction = _sqlConnetion.BeginTransaction();
                _sqlCommand.Transaction = _sqlTransaction;

                // Aggiungi l'utente
                Utente u = new Utente(username, nome, cognome, email);
                string hashedPassword = _passwordHasher.HashPassword(u, password);

                string query = @"INSERT INTO Utenti(Username, Pwd, Tipologia) VALUES(@Username, @pwd, @Tipo)";
                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@Username", username);
                _sqlCommand.Parameters.AddWithValue("@pwd", hashedPassword);
                _sqlCommand.Parameters.AddWithValue("@Tipo", "CM");

                _sqlCommand.ExecuteNonQuery();
                _sqlCommand.Parameters.Clear();

                // Aggiungi il commesso
                query = @"INSERT INTO Commessi(Username, Nome, Cognome, Email, Turno, DataAssunzione, OrarioInizio, OrarioFine)
                  VALUES (@CommessoUsername, @nome, @cognome, @email, @turno, @assuntoIl, @oraInizio, @oraFine)";
                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@CommessoUsername", username);
                if (string.IsNullOrEmpty(nome))
                    _sqlCommand.Parameters.AddWithValue("@nome", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@nome", nome);
                if (string.IsNullOrEmpty(cognome))
                    _sqlCommand.Parameters.AddWithValue("@cognome", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@cognome", cognome);
                _sqlCommand.Parameters.AddWithValue("@email", email);
                _sqlCommand.Parameters.AddWithValue("@turno", turno);
                _sqlCommand.Parameters.AddWithValue("@assuntoIl", assuntoIl.Date);
                _sqlCommand.Parameters.AddWithValue("@oraInizio", oraInizio);
                _sqlCommand.Parameters.AddWithValue("@oraFine", oraFine);

                _sqlCommand.ExecuteNonQuery();

                _sqlTransaction.Commit();
            }
            catch (SqlException ex)
            {
                _sqlTransaction?.Rollback();
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    if (ex.Message.Contains("PK_Utente"))
                        throw new Exception("Utente con username: " + username + " già esistente");

                    if (ex.Message.Contains("UQ_Commesso_Email"))
                        throw new Exception("Email: " + email + " già registrata");
                }
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }

            finally
            {
                _sqlCommand = null;
                Disconnetti();
            }
        }

        public void AggiungiFornitore(string idFornitore, string nome, string indirizzo, string telefono, string email, string tipo)
        {
            try
            {
                Connetti();  // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // query inserimento del nuovo fornitore
                string query = "INSERT INTO Fornitori(IdFornitore, NomeAzienda, Indirizzo, TelefonoAzienda, Email, TipoFornimento) " +
                               "VALUES (@id, @nome, @indirizzo, @telefono, @email, @tipo)";

                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@id", idFornitore);
                _sqlCommand.Parameters.AddWithValue("@nome", nome);
                if (string.IsNullOrEmpty(indirizzo))
                    _sqlCommand.Parameters.AddWithValue("@indirizzo", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@indirizzo", DBNull.Value);
                if (string.IsNullOrEmpty(telefono))
                    _sqlCommand.Parameters.AddWithValue("@telefono", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@telefono", DBNull.Value);
                _sqlCommand.Parameters.AddWithValue("@email", email);
                _sqlCommand.Parameters.AddWithValue("@tipo", tipo);

                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("Email: " + email + " già registrata");
                }

                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }
        public void AggiungiArticolo(string codiceArticolo, string codiceFornitore, string descrioneArticolo, double prezzo, int quantita, int iva, string categoria, string immagine)
        {
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query inserimento nuovo prodotto
                string query = "Insert into Magazzino(CodiceArticolo, IdFornitore, DescrizioneArticolo, PrezzoArticolo, Quantita, Iva, Categoria, Immagine) " +
                    "values(@CodiceArticolo, @idFornitore, @descrizione, @prezzo, @quantita, @iva, @categoria, @immagine)";

                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@CodiceArticolo", codiceArticolo);
                _sqlCommand.Parameters.AddWithValue("@idFornitore", codiceFornitore);
                _sqlCommand.Parameters.AddWithValue("@descrizione", descrioneArticolo);
                _sqlCommand.Parameters.AddWithValue("@prezzo", prezzo);
                _sqlCommand.Parameters.AddWithValue("@quantita", quantita);
                _sqlCommand.Parameters.AddWithValue("@iva", iva);
                _sqlCommand.Parameters.AddWithValue("@categoria", categoria);
                if (string.IsNullOrEmpty(immagine))
                    _sqlCommand.Parameters.AddWithValue("@immagine", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@immagine", immagine);

                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura connessione
            }
        }
        public void RifornisciMagazzino(string codiceArticolo, int value)
        {
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query aumento quantità prodotto
                string query = "update Magazzino set Quantita = Quantita + @quantita where Magazzino.CodiceArticolo = @codiceArticolo";
                _sqlCommand.Parameters.AddWithValue("@quantita", value);
                _sqlCommand.Parameters.AddWithValue("@codiceArticolo", codiceArticolo);
                _sqlCommand.CommandText = query;

                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }

        // MODIFICA

        public void ModificaAdmin(string username, string nome, string cognome, string email, int livello)
        {
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per aggiornare i dati dell' admin
                string query = @"UPDATE Admin SET Nome = @Nome, Cognome = @Cognome, Email = @Email, Livello = @Livello WHERE Username = @Username";

                _sqlCommand.CommandText = query;

                // Aggiungi i parametri al comando SQL
                if (string.IsNullOrEmpty(nome))
                    _sqlCommand.Parameters.AddWithValue("@Nome", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@Nome", nome);
                if (string.IsNullOrEmpty(cognome))
                    _sqlCommand.Parameters.AddWithValue("@Cognome", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@Cognome", cognome);
                _sqlCommand.Parameters.AddWithValue("@Email", email);
                _sqlCommand.Parameters.AddWithValue("@Livello", livello);
                _sqlCommand.Parameters.AddWithValue("@Username", username);

                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("Email: " + email + " già registrata");
                }
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }
        public void ModificaCommesso(string username, string nome, string cognome, string email, string turno, DateTime dataAssunzione, DateTime oraInizio, DateTime oraFine)
        {
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per aggiornare i dati del commesso
                string query = @"UPDATE Commessi SET Nome = @Nome, Cognome = @Cognome, Email = @Email, Turno = @Turno, DataAssunzione = @DataAssunzione, OrarioInizio = @OraInizio, OrarioFine = @OraFine WHERE Username = @Username";

                _sqlCommand.CommandText = query;

                // Aggiungi i parametri al comando SQL
                if (string.IsNullOrEmpty(nome))
                    _sqlCommand.Parameters.AddWithValue("@Nome", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@Nome", nome);
                if (string.IsNullOrEmpty(cognome))
                    _sqlCommand.Parameters.AddWithValue("@Cognome", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@Cognome", cognome);
                _sqlCommand.Parameters.AddWithValue("@Email", email);
                _sqlCommand.Parameters.AddWithValue("@Turno", turno);
                _sqlCommand.Parameters.AddWithValue("@DataAssunzione", dataAssunzione);
                _sqlCommand.Parameters.AddWithValue("@OraInizio", oraInizio);
                _sqlCommand.Parameters.AddWithValue("@OraFine", oraFine);
                _sqlCommand.Parameters.AddWithValue("@Username", username);

                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("Email: " + email + " già registrata");
                }
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }
        public void ModificaFornitore(string id, string nome, string indirizzo, string telefono, string email, string tipo)
        {
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query modifica del fornitore
                string query = "UPDATE Fornitori SET NomeAzienda = @nome, Indirizzo = @indirizzo, TelefonoAzienda = @telefono, Email = @email, TipoFornimento = @tipo WHERE IdFornitore = @id";

                _sqlCommand.CommandText = query;

                _sqlCommand.Parameters.AddWithValue("@id", id);
                _sqlCommand.Parameters.AddWithValue("@nome", nome);
                if (string.IsNullOrEmpty(indirizzo))
                    _sqlCommand.Parameters.AddWithValue("@indirizzo", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@indirizzo", indirizzo);
                if (string.IsNullOrEmpty(telefono))
                    _sqlCommand.Parameters.AddWithValue("@telefono", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@telefono", telefono);
                _sqlCommand.Parameters.AddWithValue("@email", email);
                _sqlCommand.Parameters.AddWithValue("@tipo", tipo);

                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("Email: " + email + " già registrata");
                }
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }
        public void ModificaArticolo(string codiceArticolo, string idFornitore, string descrizione, double prezzo, int iva, string categoria, string immagine)
        {
            try
            {
                Connetti(); // Connessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query modifica del prodotto
                string query = @"UPDATE Magazzino 
                             SET DescrizioneArticolo = @descrizione, IdFornitore = @fornitore, PrezzoArticolo = @prezzo, Iva = @iva, Categoria = @categoria, Immagine = @Immagine WHERE CodiceArticolo = @codiceArticolo";

                _sqlCommand.CommandText = query;

                _sqlCommand.Parameters.AddWithValue("@fornitore", idFornitore);
                _sqlCommand.Parameters.AddWithValue("@descrizione", descrizione);
                _sqlCommand.Parameters.AddWithValue("@prezzo", prezzo);
                _sqlCommand.Parameters.AddWithValue("@iva", iva);
                _sqlCommand.Parameters.AddWithValue("@categoria", categoria);
                _sqlCommand.Parameters.AddWithValue("@codiceArticolo", codiceArticolo);
                // Controlla se l'immagine è null e gestisce il parametro di conseguenza
                if (string.IsNullOrEmpty(immagine))
                    _sqlCommand.Parameters.AddWithValue("@Immagine", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@Immagine", immagine);

                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura del database
            }
        }
        public void ModificaCliente(int codiceCarta, string nome, string cognome, string email, string telefono)
        {
            try
            {
                Connetti(); // COnnessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query modifica del cliente
                string query = @"UPDATE Clienti SET Nome = @Nome, Cognome = @Cognome, Email = @Email, Telefono = @Telefono WHERE CodiceCartaFedelta = @Carta";

                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@Nome", nome);
                if (string.IsNullOrEmpty(cognome))
                    _sqlCommand.Parameters.AddWithValue("@Cognome", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@Cognome", cognome);
                _sqlCommand.Parameters.AddWithValue("@Email", email);
                if (string.IsNullOrEmpty(telefono))
                    _sqlCommand.Parameters.AddWithValue("@Telefono", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@Telefono", telefono);
                _sqlCommand.Parameters.AddWithValue("@Carta", codiceCarta);

                _sqlCommand.ExecuteNonQuery();
                Disconnetti();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                    throw new Exception("Email già registrata nel sistema.");
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura del database
            }
        }

        // ELIMINA

        public void EliminaUtente(string username)
        {
            try
            {
                Connetti(); // Connessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query eliminazione dell' admin
                string query = "delete Utenti where Username = @Username";
                _sqlCommand.Parameters.AddWithValue("@Username", username);
                _sqlCommand.CommandText = query;

                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }
        public void EliminaAdmin(string Username)
        {
            try
            {
                Connetti(); // Connessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query eliminazione dell' admin
                string query = "delete Admin where Username = @Username delete Utenti where Username = @Username";
                _sqlCommand.Parameters.AddWithValue("@Username", Username);
                _sqlCommand.CommandText = query;

                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }
        public void EliminaCommesso(string username)
        {
            try
            {
                Connetti(); // Connessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query eliminazione del commesso
                string query = "delete Commessi where Username = @Username delete Utenti where Username = @Username";
                _sqlCommand.Parameters.AddWithValue("@Username", username);
                _sqlCommand.CommandText = query;

                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }

        public void EliminaFornitore(string id)
        {
            try
            {
                Connetti(); // Connessione al database

                // Verifica se esistono ordini collegati al fornitore
                _sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Magazzino WHERE IdFornitore = @id", _sqlConnetion);
                _sqlCommand.Parameters.AddWithValue("@id", id);
                int count = (int)_sqlCommand.ExecuteScalar();

                if (count > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Sono presenti degli ordini per questo fornitore. Vuoi eliminare anche gli ordini collegati?",
                        "ATTENZIONE",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result != DialogResult.Yes)
                        return;

                    // Elimina prima gli ordini collegati
                    _sqlCommand = new SqlCommand("DELETE FROM Ordini WHERE IdFornitore = @id", _sqlConnetion);
                    _sqlCommand.Parameters.AddWithValue("@id", id);
                    _sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Fornitore eliminato con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Ora elimina il fornitore
                _sqlCommand = new SqlCommand("DELETE FROM Fornitori WHERE IdFornitore = @id", _sqlConnetion);
                _sqlCommand.Parameters.AddWithValue("@id", id);
                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura connessione
            }
        }
        public void EliminaArticolo(string codiceArticolo)
        {
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query eliminazione prodotto dal magazzino
                string query = "DELETE Magazzino where Magazzino.CodiceArticolo = @codice";
                _sqlCommand.Parameters.AddWithValue("@codice", codiceArticolo);

                _sqlCommand.CommandText = query;
                _sqlCommand.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura del database
            }
        }
        public void EliminaQuantitaArticolo(string codiceArticolo, int QuantitaDaSottrare)
        {
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per eliminare la quantità di un articolo
                string query = "update Magazzino set Quantita = Quantita - @quantita where Magazzino.CodiceArticolo = @codiceArticolo";
                _sqlCommand.Parameters.AddWithValue("@quantita", QuantitaDaSottrare);
                _sqlCommand.Parameters.AddWithValue("@codiceArticolo", codiceArticolo);
                _sqlCommand.CommandText = query;
                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura del database
            }
        }
        public void EliminaCliente(int codiceCliente)
        {
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query eliminazione cliente
                string query = "DELETE Clienti where Clienti.CodiceCartaFedelta = @codice";
                _sqlCommand.Parameters.AddWithValue("@codice", codiceCliente);

                _sqlCommand.CommandText = query;
                _sqlCommand.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura connessione
            }
        }

        // RICERCA

        public List<Cliente> RicercaInDbClienti(string ricerca)
        {
            try
            {
                List<Cliente> clienti = new List<Cliente>(); // Lista cliente filtrata
                Connetti(); // Connessione al database
                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query per la ricerca nella tabella Clienti
                string query = @"SELECT * FROM Clienti WHERE LOWER(CAST(CodiceCartaFedelta AS nvarchar)) LIKE @ricerca OR LOWER(Nome) LIKE @ricerca OR LOWER(Cognome) LIKE @ricerca" +
                                      " OR LOWER(Email) LIKE @ricerca OR LOWER(Telefono) LIKE @ricerca";

                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.Add("@ricerca", SqlDbType.NVarChar).Value = ricerca.ToLower() + "%";

                SqlDataReader dr = _sqlCommand.ExecuteReader();
                if (!dr.HasRows)
                    return clienti;

                while (dr.Read())
                {
                    // Aggiunta cliente filtrato alla lista clienti
                    clienti.Add(new Cliente((int)dr["CodiceCartaFedelta"], dr["Nome"].ToString(), dr["Cognome"].ToString(), dr["Email"].ToString(), dr["Telefono"].ToString(), Convert.ToDateTime(dr["DataInserimento"])));
                }
                dr.Close();

                return clienti;
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                Disconnetti(); // Chiusura della connessione
            }
        }
        public List<Articolo> RicercaInDbArticoli(string ricerca)
        {
            try
            {
                List<Articolo> temp = new List<Articolo>(); // Lista articolo filtrata
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query ricerca dei prodotti
                string query = "SELECT * FROM Magazzino WHERE LOWER(CodiceArticolo) LIKE @ricerca OR LOWER(CAST(IdFornitore AS NVARCHAR)) LIKE @ricerca OR LOWER(DescrizioneArticolo) LIKE @ricerca OR LOWER(CAST(PrezzoArticolo AS NVARCHAR)) LIKE @ricerca OR LOWER(CAST(Quantita AS NVARCHAR)) LIKE @ricerca OR LOWER(CAST(Iva AS NVARCHAR)) LIKE @ricerca OR LOWER(Categoria) LIKE @ricerca";

                _sqlCommand.Parameters.AddWithValue("@ricerca", ricerca + "%");
                _sqlCommand.CommandText = query;
                SqlDataReader dr = _sqlCommand.ExecuteReader();

                if (!dr.HasRows)
                    return temp;

                while (dr.Read())
                {
                    // Aggiunta di prodotti filtrati alla lista
                    temp.Add(new Articolo(dr["CodiceArticolo"].ToString(), dr["IdFornitore"].ToString(), dr["DescrizioneArticolo"].ToString(),
                        (double)dr["PrezzoArticolo"], (int)dr["Quantita"], (int)dr["Iva"], dr["Categoria"].ToString(), dr["Immagine"].ToString()));
                }
                return temp;
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura del database
            }
        }
        public List<Commesso> RicercaInDbCommessi(string ricerca)
        {
            try
            {
                List<Commesso> temp = new List<Commesso>(); // Lista commessi filtrati
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query ricerca commessi
                string query = "SELECT * FROM Commessi WHERE LOWER(Username) LIKE @ricerca OR LOWER(Nome) LIKE @ricerca OR LOWER(Cognome) LIKE @ricerca OR LOWER(Email) LIKE @ricerca OR LOWER(Turno) LIKE @ricerca OR LOWER(CONVERT(NVARCHAR, DataAssunzione, 103)) LIKE @ricerca OR LOWER(CONVERT(NVARCHAR, OrarioInizio, 108)) LIKE @ricerca OR LOWER(CONVERT(NVARCHAR, OrarioFine, 108)) LIKE @ricerca";

                _sqlCommand.Parameters.AddWithValue("@ricerca", ricerca + "%");
                _sqlCommand.CommandText = query;
                SqlDataReader dr = _sqlCommand.ExecuteReader();

                if (!dr.HasRows)
                    return temp;

                while (dr.Read())
                {
                    // Aggiunta commessi filtrati alla lista commessi
                    temp.Add(new Commesso(dr["Username"].ToString(), dr["Nome"].ToString(), dr["Cognome"].ToString(), dr["Email"].ToString(), dr["Turno"].ToString(), Convert.ToDateTime(dr["DataAssunzione"]), (TimeSpan)dr["OrarioInizio"], (TimeSpan)dr["OrarioFine"]));
                }
                dr.Close();

                return temp;
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }
        public List<Fornitore> RicercaInDbFornitori(string ricerca)
        {
            try
            {
                List<Fornitore> temp = new List<Fornitore>(); // Lista fornitori filtrata
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query ricerca fornitori
                string query = "SELECT * FROM Fornitori WHERE LOWER(CAST(IdFornitore AS NVARCHAR)) LIKE @ricerca OR LOWER(NomeAzienda) LIKE @ricerca OR LOWER(Indirizzo) LIKE @ricerca OR LOWER(TelefonoAzienda) LIKE @ricerca OR LOWER(Email) LIKE @ricerca OR LOWER(TipoFornimento) LIKE @ricerca";

                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@ricerca", ricerca + "%");

                SqlDataReader dr = _sqlCommand.ExecuteReader();

                if (!dr.HasRows)
                    return temp;

                while (dr.Read())
                {
                    // Aggiunta fornitori filtrati alla lista
                    temp.Add(new Fornitore(
                        dr["IdFornitore"].ToString(),
                        dr["NomeAzienda"].ToString(),
                        dr["Indirizzo"].ToString(),
                        dr["TelefonoAzienda"].ToString(),
                        dr["Email"].ToString(),
                        dr["TipoFornimento"].ToString()
                    ));
                }
                dr.Close();

                return temp;
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura connessione
            }
        }

        // VERIFICA PRESENZA NEL DATABASE
        public bool VerificaPresenzaArticolo(string codiceScannerizzato)
        {
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                //Query ricerca articolo
                string query = "SELECT * FROM Magazzino WHERE CodiceArticolo = @codice";

                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@codice", codiceScannerizzato);

                SqlDataReader dr = _sqlCommand.ExecuteReader();

                if (dr.HasRows)
                    // Ritorna presenza dell'articolo
                    return true;
                else
                    // Ritorna non presenza dell'articolo
                    return false;
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }
        public bool VerificaPresenzaCliente(string codice)
        {
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Ricerca cliente
                string query = "SELECT * FROM Clienti WHERE CodiceCartaFedelta = @codice";

                _sqlCommand.CommandText = query;
                _sqlCommand.Parameters.AddWithValue("@codice", codice);

                SqlDataReader dr = _sqlCommand.ExecuteReader();

                if (dr.HasRows)
                    // Ritorna presenza del cliente
                    return true;
                else
                    // Ritorna non presenza del cliente
                    return false;
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura della connessione
            }
        }

        // VERIFICA UNICITA ID FORNITORE E CODICE ARTICOLO

        public bool VerificaIdUnivoco(string identificativo, string tipo)
        {
            if (tipo == "Fornitore")
            {
                // Ottengo tutti i fornitori
                List<Fornitore> lista = OttieniTuttiIFornitori();
                // Gli scorro e se trovo un fornitore ritorno true
                foreach (Fornitore f in lista)
                    if (f.IdFornitore == identificativo)
                        return true;
            }
            else if (tipo == "Articolo")
            {
                // Ottengo tutti gli articoli
                List<Articolo> lista = OttieniTuttiGliArticoli();
                // Gli scorro e se trovo un articolo ritorno true
                foreach (Articolo a in lista)
                    if (a.CodiceArticolo == identificativo)
                        return true;
            }
            return false;
        }

        // SALVATAGGIO FATTURA
        public void SalvaFattura(string numeroScontrino, DateTime dateTime, double totaleSpesa, double pagamento, double resto, string metodoDiPagamento, Cliente cliente, double IvaTotale)
        {
            try
            {
                Connetti(); // Connessione al database

                _sqlCommand = new SqlCommand();
                _sqlCommand.Connection = _sqlConnetion;
                _sqlCommand.CommandType = CommandType.Text;

                // Query inserimento della fattura nel database
                string query = @"INSERT INTO Fatture
                        (NumeroFattura, DataFattura, TotaleComplessivo, Pagamento, Resto, MetodoDiPagamento, CodiceCartaFedelta, IvaTotale)
                        VALUES
                        (@NumeroFattura, @DataFattura, @TotaleComplessivo, @Pagamento, @Resto, @MetodoDiPagamento, @CodiceCartaFedelta, @IvaTotale)";
                _sqlCommand.CommandText = query;

                _sqlCommand.Parameters.AddWithValue("@NumeroFattura", numeroScontrino);
                _sqlCommand.Parameters.AddWithValue("@DataFattura", dateTime);
                _sqlCommand.Parameters.AddWithValue("@TotaleComplessivo", totaleSpesa);
                _sqlCommand.Parameters.AddWithValue("@Pagamento", pagamento);
                _sqlCommand.Parameters.AddWithValue("@Resto", resto);
                _sqlCommand.Parameters.AddWithValue("@MetodoDiPagamento", metodoDiPagamento);
                _sqlCommand.Parameters.AddWithValue("@IvaTotale", IvaTotale);
                // Controllo se è presente un cliente con carta fedeltà
                if (cliente == null)
                    _sqlCommand.Parameters.AddWithValue("@CodiceCartaFedelta", DBNull.Value);
                else
                    _sqlCommand.Parameters.AddWithValue("@CodiceCartaFedelta", cliente.CodiceFedelta);

                _sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Errore di connessione al database: " + ex.Message);
            }
            finally
            {
                _sqlCommand = null;
                Disconnetti(); // Chiusura del database
            }
        }

        // GENERAZIONE CODICE CARTA FEDELTA'
        private int GeneraCodiceCarta()
        {
            int codice;

            do
            {
                codice = rnd.Next(10000, 100000);
            } while (VerificaPresenzaCliente(codice.ToString())); // Vadi a controllare se il codice generato è presente nel db

            return codice;
        }

    }
}