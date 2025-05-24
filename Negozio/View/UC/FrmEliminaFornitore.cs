using Negozio.Controllers;
using Negozio.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio.View.UC
{
    public partial class FrmEliminaFornitore : UserControl
    {
        GestoreDelegate gestoreDelegate;
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        public FrmEliminaFornitore(GestoreDelegate _gestoreDelegate)
        {
            InitializeComponent();
            gestoreDelegate = _gestoreDelegate;
            CaricaCmb();
        }

        private void CaricaCmb()
        {
            try
            {
                List<Fornitore> lstFornitore = DbNegozio.OttieniTuttiIFornitori();
                lstFornitore.OrderBy(x => x.NomeAzienda).ToList();
                CmbFornitori.DataSource = lstFornitore;
                CmbFornitori.DisplayMember = "NomeAzienda";
                CmbFornitori.ValueMember = "IdFornitore";
                CmbFornitori.SelectedIndex = -1;
                CmbFornitori.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbFornitori.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnElimina_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Sei sicuro di voler eliminare il fornitore selezionato ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    throw new Exception("Operazione annullata");
                DbNegozio.EliminaFornitore(CmbFornitori.SelectedValue.ToString());
                gestoreDelegate.NotificaAggiornamentoDati();
                CaricaCmb();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
