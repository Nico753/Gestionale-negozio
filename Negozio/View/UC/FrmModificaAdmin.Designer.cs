namespace Negozio.View.UC
{
    partial class FrmModificaAdmin
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
            this.GbAdmin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CmbAdmin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbEmail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbCognome = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtCognome = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbNome = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnModificaAdmin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbLivello = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnLivello3 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn1 = new Guna.UI2.WinForms.Guna2Button();
            this.GbAdmin.SuspendLayout();
            this.GbEmail.SuspendLayout();
            this.GbCognome.SuspendLayout();
            this.GbNome.SuspendLayout();
            this.GbLivello.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbAdmin
            // 
            this.GbAdmin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbAdmin.Controls.Add(this.CmbAdmin);
            this.GbAdmin.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbAdmin.FillColor = System.Drawing.Color.DimGray;
            this.GbAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbAdmin.ForeColor = System.Drawing.Color.Black;
            this.GbAdmin.Location = new System.Drawing.Point(3, 3);
            this.GbAdmin.Name = "GbAdmin";
            this.GbAdmin.Size = new System.Drawing.Size(697, 92);
            this.GbAdmin.TabIndex = 30;
            this.GbAdmin.Text = "LISTA ADMIN";
            // 
            // CmbAdmin
            // 
            this.CmbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.CmbAdmin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAdmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbAdmin.ForeColor = System.Drawing.Color.Black;
            this.CmbAdmin.ItemHeight = 30;
            this.CmbAdmin.Location = new System.Drawing.Point(4, 46);
            this.CmbAdmin.Name = "CmbAdmin";
            this.CmbAdmin.Size = new System.Drawing.Size(687, 36);
            this.CmbAdmin.TabIndex = 12;
            // 
            // GbEmail
            // 
            this.GbEmail.Controls.Add(this.TxtEmail);
            this.GbEmail.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbEmail.Enabled = false;
            this.GbEmail.FillColor = System.Drawing.Color.DimGray;
            this.GbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEmail.ForeColor = System.Drawing.Color.Black;
            this.GbEmail.Location = new System.Drawing.Point(3, 341);
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
            this.TxtEmail.Location = new System.Drawing.Point(4, 47);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PlaceholderText = "";
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.Size = new System.Drawing.Size(687, 34);
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
            this.GbCognome.Location = new System.Drawing.Point(3, 230);
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
            this.TxtCognome.Location = new System.Drawing.Point(4, 48);
            this.TxtCognome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCognome.Name = "TxtCognome";
            this.TxtCognome.PlaceholderText = "";
            this.TxtCognome.SelectedText = "";
            this.TxtCognome.Size = new System.Drawing.Size(687, 34);
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
            this.GbNome.Location = new System.Drawing.Point(3, 113);
            this.GbNome.Name = "GbNome";
            this.GbNome.Size = new System.Drawing.Size(697, 92);
            this.GbNome.TabIndex = 34;
            this.GbNome.Text = "NOME";
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
            this.TxtNome.Location = new System.Drawing.Point(4, 48);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.PlaceholderText = "";
            this.TxtNome.SelectedText = "";
            this.TxtNome.Size = new System.Drawing.Size(687, 34);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // BtnModificaAdmin
            // 
            this.BtnModificaAdmin.BorderColor = System.Drawing.Color.White;
            this.BtnModificaAdmin.BorderRadius = 10;
            this.BtnModificaAdmin.BorderThickness = 2;
            this.BtnModificaAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnModificaAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnModificaAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModificaAdmin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModificaAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnModificaAdmin.FillColor = System.Drawing.Color.Black;
            this.BtnModificaAdmin.FillColor2 = System.Drawing.Color.SlateGray;
            this.BtnModificaAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificaAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnModificaAdmin.Location = new System.Drawing.Point(3, 596);
            this.BtnModificaAdmin.Name = "BtnModificaAdmin";
            this.BtnModificaAdmin.Size = new System.Drawing.Size(697, 56);
            this.BtnModificaAdmin.TabIndex = 29;
            this.BtnModificaAdmin.Text = "MODIFICA ADMIN";
            this.BtnModificaAdmin.Click += new System.EventHandler(this.BtnModificaAdmin_Click);
            // 
            // GbLivello
            // 
            this.GbLivello.Controls.Add(this.BtnLivello3);
            this.GbLivello.Controls.Add(this.Btn2);
            this.GbLivello.Controls.Add(this.Btn1);
            this.GbLivello.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbLivello.Enabled = false;
            this.GbLivello.FillColor = System.Drawing.Color.DimGray;
            this.GbLivello.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbLivello.ForeColor = System.Drawing.Color.Black;
            this.GbLivello.Location = new System.Drawing.Point(3, 462);
            this.GbLivello.Name = "GbLivello";
            this.GbLivello.Size = new System.Drawing.Size(697, 103);
            this.GbLivello.TabIndex = 32;
            this.GbLivello.Text = "LIVELLO";
            // 
            // BtnLivello3
            // 
            this.BtnLivello3.BorderColor = System.Drawing.Color.White;
            this.BtnLivello3.BorderRadius = 8;
            this.BtnLivello3.BorderThickness = 2;
            this.BtnLivello3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLivello3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLivello3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLivello3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLivello3.FillColor = System.Drawing.Color.Gray;
            this.BtnLivello3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLivello3.ForeColor = System.Drawing.Color.White;
            this.BtnLivello3.Location = new System.Drawing.Point(483, 47);
            this.BtnLivello3.Name = "BtnLivello3";
            this.BtnLivello3.Size = new System.Drawing.Size(180, 45);
            this.BtnLivello3.TabIndex = 2;
            this.BtnLivello3.Text = "LIVELLO 3";
            this.BtnLivello3.Click += new System.EventHandler(this.BtnLivello3_Click);
            // 
            // Btn2
            // 
            this.Btn2.BorderColor = System.Drawing.Color.White;
            this.Btn2.BorderRadius = 8;
            this.Btn2.BorderThickness = 2;
            this.Btn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn2.FillColor = System.Drawing.Color.Gray;
            this.Btn2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.Color.White;
            this.Btn2.Location = new System.Drawing.Point(262, 47);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(180, 45);
            this.Btn2.TabIndex = 1;
            this.Btn2.Text = "LIVELLO 2";
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.BorderColor = System.Drawing.Color.White;
            this.Btn1.BorderRadius = 8;
            this.Btn1.BorderThickness = 2;
            this.Btn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn1.FillColor = System.Drawing.Color.Gray;
            this.Btn1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.Color.White;
            this.Btn1.Location = new System.Drawing.Point(47, 47);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(180, 45);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "LIVELLO 1";
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // FrmModificaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.GbLivello);
            this.Controls.Add(this.GbAdmin);
            this.Controls.Add(this.GbEmail);
            this.Controls.Add(this.GbCognome);
            this.Controls.Add(this.GbNome);
            this.Controls.Add(this.BtnModificaAdmin);
            this.Name = "FrmModificaAdmin";
            this.Size = new System.Drawing.Size(703, 664);
            this.GbAdmin.ResumeLayout(false);
            this.GbEmail.ResumeLayout(false);
            this.GbCognome.ResumeLayout(false);
            this.GbNome.ResumeLayout(false);
            this.GbLivello.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GbAdmin;
        private Guna.UI2.WinForms.Guna2ComboBox CmbAdmin;
        private Guna.UI2.WinForms.Guna2GroupBox GbEmail;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmail;
        private Guna.UI2.WinForms.Guna2GroupBox GbCognome;
        private Guna.UI2.WinForms.Guna2TextBox TxtCognome;
        private Guna.UI2.WinForms.Guna2GroupBox GbNome;
        private Guna.UI2.WinForms.Guna2TextBox TxtNome;
        private Guna.UI2.WinForms.Guna2GradientButton BtnModificaAdmin;
        private Guna.UI2.WinForms.Guna2GroupBox GbLivello;
        private Guna.UI2.WinForms.Guna2Button Btn2;
        private Guna.UI2.WinForms.Guna2Button Btn1;
        private Guna.UI2.WinForms.Guna2Button BtnLivello3;
    }
}
