using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.Models
{
    public class Utente
    {
        private string username;
        private string nome;
        private string cognome;
        private string email;

        public string Username { get => username; set => username = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Email { get => email; set => email = value; }

        public Utente(string username, string nome, string cognome, string email)
        {
            Username = username;
            Nome = nome;
            Cognome = cognome;
            Email = email;
        }

    }
}
