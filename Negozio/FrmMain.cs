using Negozio.Controllers;
using Negozio.Models;
using Negozio.View;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negozio
{
    public partial class FrmMain : Form
    {
        GestoreDbNegozio _dbNegozio = new GestoreDbNegozio();
        GestoreLoader loader = new GestoreLoader();
        public FrmMain()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(18, 18, 18);
        }

        private void CbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CbPassword.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;
                CbPassword.Text = "Nascondi password";
            }
            else
            {
                TxtPassword.UseSystemPasswordChar = true;
                CbPassword.Text = "Mostra password";
            }
        }

        private void BtnAccedi_Click(object sender, EventArgs e)
        {
            loader.MostraLoader(this);

            Thread t = new Thread(() =>
            {
                try
                {
                    string username = TxtUsername.Text.Trim(
                        );
                    string password = TxtPassword.Text.Trim();

                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        throw new Exception("Inserisci un username e una password");
                    }

                    Utente utenteLoggato = _dbNegozio.Login(username, password);

                    Invoke(new Action(() =>
                    {
                        TxtUsername.Clear();
                        TxtPassword.Clear();

                        this.Hide();

                        if (utenteLoggato is Admin)
                        {
                            FrmAdmin frm = new FrmAdmin(utenteLoggato);
                            frm.ShowDialog();
                        }
                        else
                        {
                            FrmCommesso frm = new FrmCommesso(utenteLoggato);
                            frm.ShowDialog();
                        }

                        this.Show();
                    }));
                }
                catch (Exception ex)
                {
                    Invoke(new Action(() =>
                    {
                        loader.NascondiLoader(this);
                        MessageBox.Show(ex.Message, "ERRORE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
                finally
                {
                    Invoke(new Action(() =>
                    {
                        loader.NascondiLoader(this);
                    }));
                }
            });

            t.Start();
        }
    }
}
