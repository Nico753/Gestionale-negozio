namespace Negozio.View.UC
{
    partial class FrmModificaCliente
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnModifica = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbContattoTelefonico = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbEmail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbCognome = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtCognome = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbNome = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbCliente = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CmbClienti = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbContattoTelefonico.SuspendLayout();
            this.GbEmail.SuspendLayout();
            this.GbCognome.SuspendLayout();
            this.GbNome.SuspendLayout();
            this.GbCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModifica
            // 
            this.BtnModifica.BorderColor = System.Drawing.Color.White;
            this.BtnModifica.BorderRadius = 10;
            this.BtnModifica.BorderThickness = 2;
            this.BtnModifica.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnModifica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnModifica.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModifica.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModifica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnModifica.FillColor = System.Drawing.Color.Black;
            this.BtnModifica.FillColor2 = System.Drawing.Color.SlateGray;
            this.BtnModifica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifica.ForeColor = System.Drawing.Color.White;
            this.BtnModifica.Location = new System.Drawing.Point(0, 605);
            this.BtnModifica.Name = "BtnModifica";
            this.BtnModifica.Size = new System.Drawing.Size(703, 56);
            this.BtnModifica.TabIndex = 29;
            this.BtnModifica.Text = "MODIFICA CLIENTE";
            this.BtnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // GbContattoTelefonico
            // 
            this.GbContattoTelefonico.Controls.Add(this.TxtTelefono);
            this.GbContattoTelefonico.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.GbContattoTelefonico.Enabled = false;
            this.GbContattoTelefonico.FillColor = System.Drawing.Color.DimGray;
            this.GbContattoTelefonico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbContattoTelefonico.ForeColor = System.Drawing.Color.Black;
            this.GbContattoTelefonico.Location = new System.Drawing.Point(5, 496);
            this.GbContattoTelefonico.Name = "GbContattoTelefonico";
            this.GbContattoTelefonico.Size = new System.Drawing.Size(697, 92);
            this.GbContattoTelefonico.TabIndex = 32;
            this.GbContattoTelefonico.Text = "CONTATTO TELEFONICO";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTelefono.DefaultText = "";
            this.TxtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.Black;
            this.TxtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTelefono.Location = new System.Drawing.Point(2, 47);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTelefono.MaxLength = 10;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PlaceholderText = "";
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.Size = new System.Drawing.Size(689, 34);
            this.TxtTelefono.TabIndex = 2;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            // 
            // GbEmail
            // 
            this.GbEmail.Controls.Add(this.TxtEmail);
            this.GbEmail.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbEmail.Enabled = false;
            this.GbEmail.FillColor = System.Drawing.Color.DimGray;
            this.GbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEmail.ForeColor = System.Drawing.Color.Black;
            this.GbEmail.Location = new System.Drawing.Point(3, 371);
            this.GbEmail.Name = "GbEmail";
            this.GbEmail.Size = new System.Drawing.Size(697, 92);
            this.GbEmail.TabIndex = 31;
            this.GbEmail.Text = "EMAIL *";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmail.DefaultText = "";
            this.TxtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.Black;
            this.TxtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail.Location = new System.Drawing.Point(2, 47);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PlaceholderText = "";
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.Size = new System.Drawing.Size(689, 34);
            this.TxtEmail.TabIndex = 2;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // GbCognome
            // 
            this.GbCognome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbCognome.Controls.Add(this.TxtCognome);
            this.GbCognome.CustomBorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.GbCognome.Enabled = false;
            this.GbCognome.FillColor = System.Drawing.Color.DimGray;
            this.GbCognome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCognome.ForeColor = System.Drawing.Color.Black;
            this.GbCognome.Location = new System.Drawing.Point(3, 241);
            this.GbCognome.Name = "GbCognome";
            this.GbCognome.Size = new System.Drawing.Size(697, 92);
            this.GbCognome.TabIndex = 35;
            this.GbCognome.Text = "COGNOME";
            // 
            // TxtCognome
            // 
            this.TxtCognome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCognome.DefaultText = "";
            this.TxtCognome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCognome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCognome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCognome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCognome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCognome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCognome.ForeColor = System.Drawing.Color.Black;
            this.TxtCognome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCognome.Location = new System.Drawing.Point(3, 48);
            this.TxtCognome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCognome.Name = "TxtCognome";
            this.TxtCognome.PlaceholderText = "";
            this.TxtCognome.SelectedText = "";
            this.TxtCognome.Size = new System.Drawing.Size(689, 34);
            this.TxtCognome.TabIndex = 0;
            this.TxtCognome.TextChanged += new System.EventHandler(this.TxtCognome_TextChanged);
            // 
            // GbNome
            // 
            this.GbNome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbNome.Controls.Add(this.TxtNome);
            this.GbNome.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbNome.Enabled = false;
            this.GbNome.FillColor = System.Drawing.Color.DimGray;
            this.GbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbNome.ForeColor = System.Drawing.Color.Black;
            this.GbNome.Location = new System.Drawing.Point(3, 122);
            this.GbNome.Name = "GbNome";
            this.GbNome.Size = new System.Drawing.Size(697, 92);
            this.GbNome.TabIndex = 34;
            this.GbNome.Text = "NOME CLIENTE *";
            // 
            // TxtNome
            // 
            this.TxtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNome.DefaultText = "";
            this.TxtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.ForeColor = System.Drawing.Color.Black;
            this.TxtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNome.Location = new System.Drawing.Point(3, 48);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.PlaceholderText = "";
            this.TxtNome.SelectedText = "";
            this.TxtNome.Size = new System.Drawing.Size(689, 34);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // GbCliente
            // 
            this.GbCliente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbCliente.Controls.Add(this.CmbClienti);
            this.GbCliente.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbCliente.FillColor = System.Drawing.Color.DimGray;
            this.GbCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCliente.ForeColor = System.Drawing.Color.Black;
            this.GbCliente.Location = new System.Drawing.Point(3, 3);
            this.GbCliente.Name = "GbCliente";
            this.GbCliente.Size = new System.Drawing.Size(697, 92);
            this.GbCliente.TabIndex = 30;
            this.GbCliente.Text = "LISTA CLIENTI";
            // 
            // CmbClienti
            // 
            this.CmbClienti.BackColor = System.Drawing.Color.Transparent;
            this.CmbClienti.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbClienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClienti.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbClienti.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbClienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbClienti.ForeColor = System.Drawing.Color.Black;
            this.CmbClienti.ItemHeight = 30;
            this.CmbClienti.Location = new System.Drawing.Point(3, 46);
            this.CmbClienti.Name = "CmbClienti";
            this.CmbClienti.Size = new System.Drawing.Size(688, 36);
            this.CmbClienti.TabIndex = 12;
            // 
            // FrmModificaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.BtnModifica);
            this.Controls.Add(this.GbContattoTelefonico);
            this.Controls.Add(this.GbEmail);
            this.Controls.Add(this.GbCognome);
            this.Controls.Add(this.GbNome);
            this.Controls.Add(this.GbCliente);
            this.Name = "FrmModificaCliente";
            this.Size = new System.Drawing.Size(703, 664);
            this.GbContattoTelefonico.ResumeLayout(false);
            this.GbEmail.ResumeLayout(false);
            this.GbCognome.ResumeLayout(false);
            this.GbNome.ResumeLayout(false);
            this.GbCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton BtnModifica;
        private Guna.UI2.WinForms.Guna2GroupBox GbContattoTelefonico;
        private Guna.UI2.WinForms.Guna2TextBox TxtTelefono;
        private Guna.UI2.WinForms.Guna2GroupBox GbEmail;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmail;
        private Guna.UI2.WinForms.Guna2GroupBox GbCognome;
        private Guna.UI2.WinForms.Guna2TextBox TxtCognome;
        private Guna.UI2.WinForms.Guna2GroupBox GbNome;
        private Guna.UI2.WinForms.Guna2TextBox TxtNome;
        private Guna.UI2.WinForms.Guna2GroupBox GbCliente;
        private Guna.UI2.WinForms.Guna2ComboBox CmbClienti;
    }
}
