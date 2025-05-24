namespace Negozio.View.UC
{
    partial class FrmGestioneClienti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbRicercaCliente = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtRicerca = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbDgv = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DgvClienti = new System.Windows.Forms.DataGridView();
            this.PanelEdit = new System.Windows.Forms.Panel();
            this.GbCognome = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtCognome = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAggiungi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbContattoTelefonico = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbEmail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbNome = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbRicercaCliente.SuspendLayout();
            this.GbDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClienti)).BeginInit();
            this.PanelEdit.SuspendLayout();
            this.GbCognome.SuspendLayout();
            this.GbContattoTelefonico.SuspendLayout();
            this.GbEmail.SuspendLayout();
            this.GbNome.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbRicercaCliente
            // 
            this.GbRicercaCliente.Controls.Add(this.TxtRicerca);
            this.GbRicercaCliente.CustomBorderColor = System.Drawing.Color.DimGray;
            this.GbRicercaCliente.FillColor = System.Drawing.Color.DimGray;
            this.GbRicercaCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbRicercaCliente.ForeColor = System.Drawing.Color.White;
            this.GbRicercaCliente.Location = new System.Drawing.Point(829, 21);
            this.GbRicercaCliente.Name = "GbRicercaCliente";
            this.GbRicercaCliente.Size = new System.Drawing.Size(644, 96);
            this.GbRicercaCliente.TabIndex = 10;
            this.GbRicercaCliente.Text = "RICERCA CLIENTE";
            // 
            // TxtRicerca
            // 
            this.TxtRicerca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRicerca.DefaultText = "";
            this.TxtRicerca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRicerca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRicerca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRicerca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRicerca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRicerca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRicerca.ForeColor = System.Drawing.Color.Black;
            this.TxtRicerca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRicerca.Location = new System.Drawing.Point(15, 43);
            this.TxtRicerca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRicerca.Name = "TxtRicerca";
            this.TxtRicerca.PlaceholderText = "";
            this.TxtRicerca.SelectedText = "";
            this.TxtRicerca.Size = new System.Drawing.Size(614, 35);
            this.TxtRicerca.TabIndex = 0;
            this.TxtRicerca.TextChanged += new System.EventHandler(this.TxtCliente_TextChanged);
            // 
            // GbDgv
            // 
            this.GbDgv.BackColor = System.Drawing.SystemColors.Desktop;
            this.GbDgv.BorderColor = System.Drawing.Color.White;
            this.GbDgv.BorderRadius = 10;
            this.GbDgv.BorderThickness = 0;
            this.GbDgv.Controls.Add(this.DgvClienti);
            this.GbDgv.CustomBorderColor = System.Drawing.Color.DimGray;
            this.GbDgv.FillColor = System.Drawing.Color.DimGray;
            this.GbDgv.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDgv.ForeColor = System.Drawing.Color.White;
            this.GbDgv.Location = new System.Drawing.Point(19, 21);
            this.GbDgv.Name = "GbDgv";
            this.GbDgv.Size = new System.Drawing.Size(783, 766);
            this.GbDgv.TabIndex = 9;
            this.GbDgv.Text = "LISTA CLIENTI";
            // 
            // DgvClienti
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DgvClienti.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvClienti.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvClienti.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvClienti.Location = new System.Drawing.Point(3, 43);
            this.DgvClienti.Name = "DgvClienti";
            this.DgvClienti.Size = new System.Drawing.Size(777, 720);
            this.DgvClienti.TabIndex = 0;
            // 
            // PanelEdit
            // 
            this.PanelEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelEdit.Controls.Add(this.GbCognome);
            this.PanelEdit.Controls.Add(this.BtnAggiungi);
            this.PanelEdit.Controls.Add(this.GbContattoTelefonico);
            this.PanelEdit.Controls.Add(this.GbEmail);
            this.PanelEdit.Controls.Add(this.GbNome);
            this.PanelEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelEdit.Location = new System.Drawing.Point(829, 123);
            this.PanelEdit.Name = "PanelEdit";
            this.PanelEdit.Size = new System.Drawing.Size(644, 664);
            this.PanelEdit.TabIndex = 8;
            // 
            // GbCognome
            // 
            this.GbCognome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbCognome.Controls.Add(this.TxtCognome);
            this.GbCognome.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbCognome.FillColor = System.Drawing.Color.DimGray;
            this.GbCognome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCognome.ForeColor = System.Drawing.Color.Black;
            this.GbCognome.Location = new System.Drawing.Point(15, 156);
            this.GbCognome.Name = "GbCognome";
            this.GbCognome.Size = new System.Drawing.Size(614, 92);
            this.GbCognome.TabIndex = 9;
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
            this.TxtCognome.Location = new System.Drawing.Point(8, 47);
            this.TxtCognome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCognome.Name = "TxtCognome";
            this.TxtCognome.PlaceholderText = "";
            this.TxtCognome.SelectedText = "";
            this.TxtCognome.Size = new System.Drawing.Size(596, 34);
            this.TxtCognome.TabIndex = 1;
            this.TxtCognome.TextChanged += new System.EventHandler(this.TxtCognome_TextChanged);
            // 
            // BtnAggiungi
            // 
            this.BtnAggiungi.BackColor = System.Drawing.Color.Transparent;
            this.BtnAggiungi.BorderColor = System.Drawing.Color.White;
            this.BtnAggiungi.BorderRadius = 10;
            this.BtnAggiungi.BorderThickness = 2;
            this.BtnAggiungi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAggiungi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAggiungi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAggiungi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAggiungi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAggiungi.FillColor = System.Drawing.Color.Black;
            this.BtnAggiungi.FillColor2 = System.Drawing.Color.SlateGray;
            this.BtnAggiungi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAggiungi.ForeColor = System.Drawing.Color.White;
            this.BtnAggiungi.Location = new System.Drawing.Point(15, 583);
            this.BtnAggiungi.Name = "BtnAggiungi";
            this.BtnAggiungi.Size = new System.Drawing.Size(614, 56);
            this.BtnAggiungi.TabIndex = 18;
            this.BtnAggiungi.Text = "AGGIUNGI CLIENTE";
            this.BtnAggiungi.Click += new System.EventHandler(this.BtnAggiungi_Click);
            // 
            // GbContattoTelefonico
            // 
            this.GbContattoTelefonico.Controls.Add(this.TxtTelefono);
            this.GbContattoTelefonico.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.GbContattoTelefonico.FillColor = System.Drawing.Color.DimGray;
            this.GbContattoTelefonico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbContattoTelefonico.ForeColor = System.Drawing.Color.Black;
            this.GbContattoTelefonico.Location = new System.Drawing.Point(15, 461);
            this.GbContattoTelefonico.Name = "GbContattoTelefonico";
            this.GbContattoTelefonico.Size = new System.Drawing.Size(614, 92);
            this.GbContattoTelefonico.TabIndex = 11;
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
            this.TxtTelefono.Location = new System.Drawing.Point(8, 48);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTelefono.MaxLength = 10;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PlaceholderText = "";
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.Size = new System.Drawing.Size(596, 34);
            this.TxtTelefono.TabIndex = 2;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // GbEmail
            // 
            this.GbEmail.Controls.Add(this.TxtEmail);
            this.GbEmail.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbEmail.FillColor = System.Drawing.Color.DimGray;
            this.GbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEmail.ForeColor = System.Drawing.Color.Black;
            this.GbEmail.Location = new System.Drawing.Point(15, 307);
            this.GbEmail.Name = "GbEmail";
            this.GbEmail.Size = new System.Drawing.Size(614, 92);
            this.GbEmail.TabIndex = 10;
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
            this.TxtEmail.Location = new System.Drawing.Point(8, 48);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PlaceholderText = "";
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.Size = new System.Drawing.Size(596, 34);
            this.TxtEmail.TabIndex = 2;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // GbNome
            // 
            this.GbNome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbNome.Controls.Add(this.TxtNome);
            this.GbNome.CustomBorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.GbNome.FillColor = System.Drawing.Color.DimGray;
            this.GbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbNome.ForeColor = System.Drawing.Color.Black;
            this.GbNome.Location = new System.Drawing.Point(15, 19);
            this.GbNome.Name = "GbNome";
            this.GbNome.Size = new System.Drawing.Size(614, 92);
            this.GbNome.TabIndex = 13;
            this.GbNome.Text = "NOME *";
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
            this.TxtNome.Location = new System.Drawing.Point(8, 49);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.PlaceholderText = "";
            this.TxtNome.SelectedText = "";
            this.TxtNome.Size = new System.Drawing.Size(596, 34);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // FrmGestioneClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.GbRicercaCliente);
            this.Controls.Add(this.PanelEdit);
            this.Controls.Add(this.GbDgv);
            this.Name = "FrmGestioneClienti";
            this.Size = new System.Drawing.Size(1495, 803);
            this.GbRicercaCliente.ResumeLayout(false);
            this.GbDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvClienti)).EndInit();
            this.PanelEdit.ResumeLayout(false);
            this.GbCognome.ResumeLayout(false);
            this.GbContattoTelefonico.ResumeLayout(false);
            this.GbEmail.ResumeLayout(false);
            this.GbNome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GbRicercaCliente;
        private Guna.UI2.WinForms.Guna2GroupBox GbDgv;
        private System.Windows.Forms.DataGridView DgvClienti;
        private System.Windows.Forms.Panel PanelEdit;
        private Guna.UI2.WinForms.Guna2TextBox TxtRicerca;
        private Guna.UI2.WinForms.Guna2GroupBox GbEmail;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmail;
        private Guna.UI2.WinForms.Guna2GroupBox GbNome;
        private Guna.UI2.WinForms.Guna2TextBox TxtNome;
        private Guna.UI2.WinForms.Guna2GroupBox GbContattoTelefonico;
        private Guna.UI2.WinForms.Guna2TextBox TxtTelefono;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAggiungi;
        private Guna.UI2.WinForms.Guna2GroupBox GbCognome;
        private Guna.UI2.WinForms.Guna2TextBox TxtCognome;
    }
}
