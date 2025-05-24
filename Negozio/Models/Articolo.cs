using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.Models
{
    public class Articolo
    {
        private string codiceArticolo;
        private string idFornitore;
        private string descrizioneArticolo;
        private double prezzoArticolo;
        private int quantita;
        private int iva;
        private string categoria;
        private string immagine;
        public string CodiceArticolo { get => codiceArticolo; set => codiceArticolo = value; }
        public string IdFornitore { get => idFornitore; set => idFornitore = value; }
        public string DescrizioneArticolo { get => descrizioneArticolo; set => descrizioneArticolo = value; }
        public double PrezzoArticolo { get => prezzoArticolo; set => prezzoArticolo = value; }
        public int Quantita { get => quantita; set => quantita = value; }
        public int Iva { get => iva; set => iva = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Immagine { get => immagine; set => immagine = value; }

        public Articolo(string codiceArticolo, string idFornitore, string descrizioneArticolo, double prezzoArticolo, int quantita, int iva, string categoria, string immagine)
        {
            CodiceArticolo = codiceArticolo;
            IdFornitore = idFornitore;
            DescrizioneArticolo = descrizioneArticolo;
            PrezzoArticolo = prezzoArticolo;
            Quantita = quantita;
            Iva = iva;
            Categoria = categoria;
            Immagine = immagine;
        }

        public double PrezzoConIva()
        {
            return PrezzoArticolo + (PrezzoArticolo * Iva / 100);
        }
    }
}
