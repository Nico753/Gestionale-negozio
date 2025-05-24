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
    public partial class FrmEliminaAdmin : UserControl
    {
        GestoreDelegate gestoreDelegate;
        GestoreDbNegozio DbNegozio = new GestoreDbNegozio();
        public FrmEliminaAdmin(GestoreDelegate _gestoreDelegate)
        {
            InitializeComponent();
            gestoreDelegate = _gestoreDelegate;
            CaricaCmb();
        }

        private void CaricaCmb()
        {
            try
            {
                List<Admin> lstAdmin = DbNegozio.OttieniTuttiGliAmministratori();
                lstAdmin = lstAdmin.OrderBy(x => x.Username).ToList();
                CmbAdmin.DataSource = lstAdmin;
                CmbAdmin.DisplayMember = "Username";
                CmbAdmin.ValueMember = "Username";
                CmbAdmin.SelectedIndex = -1;
                CmbAdmin.DropDownStyle = ComboBoxStyle.DropDownList;
                CmbAdmin.SelectionChangeCommitted += (s, e) => this.ActiveControl = null;
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
                DbNegozio.EliminaAdmin(CmbAdmin.SelectedValue.ToString());
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
