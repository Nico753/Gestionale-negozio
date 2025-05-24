using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.Models
{
    public class Cliente
    {
        private int codiceFedelta;
        private string nome;
        private string cognome;
        private string email;
        private string telefono;
        private DateTime dataCrezione;
        public int CodiceFedelta { get => codiceFedelta; set => codiceFedelta = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public DateTime DataCrezione { get => dataCrezione; set => dataCrezione = value; }

        public Cliente(int _codiceFedelta, string _nome, string _cognome, string _email, string _telefono, DateTime _dataCrezione)
        {
            CodiceFedelta = _codiceFedelta;
            Nome = _nome;
            Cognome = _cognome;
            Email = _email;
            Telefono = _telefono;
            DataCrezione = _dataCrezione;
        }
        public string CodiceCartaFedeltaCensurato()
        {
            string codice = CodiceFedelta.ToString().PadLeft(6, '0');
            return $"{codice[0]}***{codice[codice.Length - 1]}";
        }

        public string StampaNumeroDiTelefono()
        {
            if (!string.IsNullOrEmpty(Telefono))
                return $"{Telefono.Substring(0, 3)} {Telefono.Substring(3, 3)} {Telefono.Substring(6, 4)}";
            return "";
        }
    }
}
