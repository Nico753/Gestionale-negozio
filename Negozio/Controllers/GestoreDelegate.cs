using Negozio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.Controllers
{
    public delegate void StampaFatturaHandler();
    public delegate void ScannerizzazioneHandler(string codiceScannerizzato, Panel panel);
    public delegate void AggiuntaArticoloAlCarrelloHandler(string codiceArticolo);
    public delegate void AggiuntaCartaFedelta();
    public delegate void ChiusuraFrmCommessoHandler();
    public delegate void PasswordResetHandler();
    public delegate void AggiornamentoDatiHandler();
    public delegate void EvidenziaCommessoHandler(string username);
    public delegate void EvidenziaAdminHandler(string username);
    public delegate void EvidenziaFornitoreHandler(string idFornitore);
    public delegate void EvidenziaArticoloHandler(string codiceArticolo);
    public delegate void EvidenziaClienteHandler(int codiceCliente);
    public delegate void ModificaListaCommessiHandler(List<Commesso> commessi);
    public delegate void ModificaListaFornitoriHandler(List<Fornitore> fornitori);
    public delegate void ModificaListaArticoliHandler(List<Articolo> articoli);
    public delegate void ModificaListaClientiHandler(List<Cliente> clienti);

    public class GestoreDelegate
    {
        public event EvidenziaAdminHandler OnAdminEvidenziato;
        public event ModificaListaClientiHandler OnClientiModificati;
        public event EvidenziaClienteHandler OnClienteEvidenziato;
        public event StampaFatturaHandler OnStampaFattura;
        public event ScannerizzazioneHandler OnScannerizzazione;
        public event AggiuntaCartaFedelta OnAggiuntaCarta;
        public event ChiusuraFrmCommessoHandler OnChiusuraFrmCommesso;
        public event AggiuntaArticoloAlCarrelloHandler OnArticoloAggiuntoAlCarrello;
        public event EvidenziaArticoloHandler OnArticoloEvidenziato;
        public event EvidenziaCommessoHandler OnCommessoEvidenziato;
        public event EvidenziaFornitoreHandler OnFornitoreEvidenziato;
        public event PasswordResetHandler OnPasswordReimpostata;
        public event AggiornamentoDatiHandler OnDatiAggiornati;
        public event ModificaListaCommessiHandler OnCommessiModificati;
        public event ModificaListaFornitoriHandler OnFornitoriModificati;
        public event ModificaListaArticoliHandler OnArticoliModificati;

        public void NotificaArticoliModificati(List<Articolo> articoli)
        {
            OnArticoliModificati?.Invoke(articoli);
        }

        public void NotificaAggiornamentoDati()
        {
            OnDatiAggiornati?.Invoke();
        }

        public void NotificaCommessiModificati(List<Commesso> commessi)
        {
            OnCommessiModificati?.Invoke(commessi);
        }

        public void NotificaFornitoriModificati(List<Fornitore> fornitori)
        {
            OnFornitoriModificati?.Invoke(fornitori);
        }

        public void NotificaPasswordReimpostata()
        {
            OnPasswordReimpostata?.Invoke();
        }

        public void NotificaCommessoEvidenziato(string username)
        {
            OnCommessoEvidenziato?.Invoke(username);
        }

        public void NotificaFornitoreEvidenziato(string idFornitore)
        {
            OnFornitoreEvidenziato?.Invoke(idFornitore);
        }

        public void NotificaArticoloEvidenziato(string codiceArticolo)
        {
            OnArticoloEvidenziato?.Invoke(codiceArticolo);
        }

        public void NotificaAggiuntaArticoloAlCarrello(string codiceArticolo)
        {
            OnArticoloAggiuntoAlCarrello?.Invoke(codiceArticolo);
        }

        public void NotificaChiusuraFrmCommesso()
        {
            OnChiusuraFrmCommesso?.Invoke();
        }

        public void NotificaAggiuntaCarta()
        {
            OnAggiuntaCarta?.Invoke();
        }

        public void NotificaScannerizzazione(string codice, Panel panel)
        {
            OnScannerizzazione?.Invoke(codice, panel);
        }

        public void NotificaStampaFattura()
        {
            OnStampaFattura?.Invoke();
        }

        public void NotificaClienteEvidenziato(int codiceCliente)
        {
            OnClienteEvidenziato?.Invoke(codiceCliente);
        }

        public void NotificaClientiModificati(List<Cliente> clienti)
        {
            OnClientiModificati?.Invoke(clienti);
        }

        public void NotificaAdminEvidenziato(string username)
        {
            OnAdminEvidenziato?.Invoke(username);
        }
    }
}

