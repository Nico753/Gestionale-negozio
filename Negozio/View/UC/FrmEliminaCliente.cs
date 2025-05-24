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
    public partial class FrmEliminaCliente : UserControl
    {
        GestoreDelegate gestoreDelegate;
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        public FrmEliminaCliente(GestoreDelegate _gestoreDelegate)
        {
            InitializeComponent();
            gestoreDelegate = _gestoreDelegate;
            CaricaCmb();
        }

        private void CaricaCmb()
        {
            try
            {
                List<Cliente> lstCliente = DbNegozio.OttieniTuttiIClienti();
                lstCliente = lstCliente.OrderBy(x => x).ToList();
                CmbClienti.DataSource = lstCliente;
                CmbClienti.DisplayMember = "Cognome";
                CmbClienti.ValueMember = "CodiceFedelta";
                CmbClienti.SelectedIndex = -1;
                CmbClienti.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbClienti.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
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
                if (MessageBox.Show("Sei sicuro di voler eliminare il cliente selezionato ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    throw new Exception("Operazione annullata");
                DbNegozio.EliminaCliente((int)CmbClienti.SelectedValue);
                gestoreDelegate.NotificaAggiornamentoDati();
                CaricaCmb();
                MessageBox.Show("Cliente eliminato con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
