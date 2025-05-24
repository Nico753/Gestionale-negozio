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
    public partial class FrmEliminaCommesso : UserControl
    {
        GestoreDelegate gestoreDelegate;
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        public FrmEliminaCommesso(GestoreDelegate _gestoreDelegate)
        {
            InitializeComponent();
            gestoreDelegate = _gestoreDelegate;
            CaricaCmb();
        }

        private void CaricaCmb()
        {
            try
            {
                List<Commesso> lstCommessi = DbNegozio.OttieniTuttiICommessi();
                lstCommessi.OrderBy(x => x.Username).ToList();
                CmbCommessi.DataSource = lstCommessi;
                CmbCommessi.DisplayMember = "Username";
                CmbCommessi.ValueMember = "Username";
                CmbCommessi.SelectedIndex = -1;
                CmbCommessi.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbCommessi.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
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
                if (MessageBox.Show("Sei sicuro di voler eliminare il commesso selezionato ?", "Attenzione", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    throw new Exception("Operazione annullata");
                DbNegozio.EliminaCommesso(CmbCommessi.SelectedValue.ToString());
                MessageBox.Show("Commesso eliminato con successo !", "Successo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CaricaCmb();
                gestoreDelegate.NotificaAggiornamentoDati();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
