using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.Models
{
    public class Admin : Utente
    {
        private int livello;
        public int Livello { get => livello; set => livello = value; }
        public Admin(string username, string nome, string cognome, string email, int livello)
        : base(username, nome, cognome, email)
        {
            Livello = livello;
        }
    }
}
