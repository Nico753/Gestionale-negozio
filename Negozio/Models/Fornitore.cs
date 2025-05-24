using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.Models
{
    public class Fornitore
    {
        private string idFornitore;
        private string nomeAzienda;
        private string indirizzo;
        private string telefonoAzienda;
        private string email;
        private string tipoFornimento;

        public string IdFornitore { get => idFornitore; set => idFornitore = value; }
        public string NomeAzienda { get => nomeAzienda; set => nomeAzienda = value; }
        public string Indirizzo { get => indirizzo; set => indirizzo = value; }
        public string Email { get => email; set => email = value; }
        public string TipoFornimento { get => tipoFornimento; set => tipoFornimento = value; }
        public string TelefonoAzienda { get => telefonoAzienda; set => telefonoAzienda = value; }

        public Fornitore(string idFornitore, string nomeAzienda, string indirizzo, string telefono, string email, string tipoFornimento)
        {
            IdFornitore = idFornitore;
            NomeAzienda = nomeAzienda;
            Indirizzo = indirizzo;
            Email = email;
            TelefonoAzienda = telefono;
            TipoFornimento = tipoFornimento;
        }

        public override string ToString()
        {
            return $"ID Fornitore: {IdFornitore},\nNome Azienda: {NomeAzienda},\nIndirizzo: {Indirizzo},\n" +
          $"Telefono: {TelefonoAzienda},\nEmail: {Email},\nTipo Fornimento: {TipoFornimento}";
        }

        internal string StampaNumeroDiTelefono()
        {
            return $"{TelefonoAzienda.Substring(0, 3)} {TelefonoAzienda.Substring(3, 3)} {TelefonoAzienda.Substring(6, 4)}";
        }
    }
}

