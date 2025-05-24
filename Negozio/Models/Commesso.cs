using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.Models
{
    public class Commesso : Utente
    {
        private string turno;
        private DateTime dataAssunzione;
        private TimeSpan oraInizioTurno;
        private TimeSpan oraFineTurno;
        public string Turno { get => turno; set => turno = value; }
        public DateTime DataAssunzione { get => dataAssunzione; set => dataAssunzione = value; }
        public TimeSpan OraInizioTurno { get => oraInizioTurno; set => oraInizioTurno = value; }
        public TimeSpan OraFineTurno { get => oraFineTurno; set => oraFineTurno = value; }

        public Commesso(string username, string nome, string cognome, string email, string turno, DateTime dataAssunzione, TimeSpan oraInizioTurno, TimeSpan oraFineTurno)
        : base(username, nome, cognome, email)
        {
            Turno = turno;
            DataAssunzione = dataAssunzione;
            OraInizioTurno = oraInizioTurno;
            OraFineTurno = oraFineTurno;
        }

        public override string ToString()
        {
            return $"Username: {Username},\nNome: {Nome},\nCognome: {Cognome},\nEmail: {Email},\nTurno: {Turno},\n" +
                   $"Data Assunzione: {DataAssunzione.ToShortDateString()},\nOra Inizio Turno: {OraInizioTurno},\n" +
                   $"Ora Fine Turno: {OraFineTurno}";
        }

    }
}
