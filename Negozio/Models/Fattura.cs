using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negozio.Models
{
    internal class Fattura
    {
        private string numeroFattura;
        private DateTime data;
        private double totaleComplessivo;
        private double pagamento;
        private double resto;
        private string metodoDiPagamento;
        private int codiceCartaFedelta;
        private double ivaTotale;

        public string NumeroFattura { get => numeroFattura; set => numeroFattura = value; }
        public DateTime Data { get => data; set => data = value; }
        public double TotaleComplessivo { get => totaleComplessivo; set => totaleComplessivo = value; }
        public double Pagamento { get => pagamento; set => pagamento = value; }
        public double Resto { get => resto; set => resto = value; }
        public string MetodoDiPagamento { get => metodoDiPagamento; set => metodoDiPagamento = value; }
        public int CodiceCartaFedelta { get => codiceCartaFedelta; set => codiceCartaFedelta = value; }
        public double IvaTotale { get => ivaTotale; set => ivaTotale = value; }

        public Fattura(string numeroFattura, DateTime data, double totaleComplessivo, double pagamento, double resto, string metodoDiPagamento, int codiceCartaFedelta, double ivaTotale)
        {
            NumeroFattura = numeroFattura;
            Data = data;
            TotaleComplessivo = totaleComplessivo;
            Pagamento = pagamento;
            Resto = resto;
            MetodoDiPagamento = metodoDiPagamento;
            CodiceCartaFedelta = codiceCartaFedelta;
            IvaTotale = ivaTotale;
        }
    }
}
