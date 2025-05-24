namespace Negozio.View
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.PanMenu = new System.Windows.Forms.Panel();
            this.BtnClienti = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnAdmin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnReport = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnCommessi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnFornitori = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnMagazzino = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanBar = new System.Windows.Forms.Panel();
            this.TxtRicerca = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnReimpostaPassword = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.PanBody = new System.Windows.Forms.Panel();
            this.PanMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanMenu
            // 
            this.PanMenu.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanMenu.Controls.Add(this.BtnClienti);
            this.PanMenu.Controls.Add(this.BtnAdmin);
            this.PanMenu.Controls.Add(this.BtnReport);
            this.PanMenu.Controls.Add(this.BtnCommessi);
            this.PanMenu.Controls.Add(this.BtnFornitori);
            this.PanMenu.Controls.Add(this.BtnMagazzino);
            this.PanMenu.Controls.Add(this.pictureBox1);
            this.PanMenu.Location = new System.Drawing.Point(12, 9);
            this.PanMenu.Name = "PanMenu";
            this.PanMenu.Size = new System.Drawing.Size(176, 906);
            this.PanMenu.TabIndex = 0;
            // 
            // BtnClienti
            // 
            this.BtnClienti.BorderColor = System.Drawing.Color.DimGray;
            this.BtnClienti.BorderRadius = 6;
            this.BtnClienti.BorderThickness = 2;
            this.BtnClienti.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClienti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClienti.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClienti.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClienti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClienti.FillColor = System.Drawing.Color.Black;
            this.BtnClienti.FillColor2 = System.Drawing.Color.DimGray;
            this.BtnClienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClienti.ForeColor = System.Drawing.Color.White;
            this.BtnClienti.Location = new System.Drawing.Point(7, 432);
            this.BtnClienti.Name = "BtnClienti";
            this.BtnClienti.Size = new System.Drawing.Size(162, 62);
            this.BtnClienti.TabIndex = 10;
            this.BtnClienti.Text = "CLIENTI";
            this.BtnClienti.Click += new System.EventHandler(this.BtnClienti_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.BorderColor = System.Drawing.Color.DimGray;
            this.BtnAdmin.BorderRadius = 6;
            this.BtnAdmin.BorderThickness = 2;
            this.BtnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdmin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdmin.Enabled = false;
            this.BtnAdmin.FillColor = System.Drawing.Color.Black;
            this.BtnAdmin.FillColor2 = System.Drawing.Color.DimGray;
            this.BtnAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin.Location = new System.Drawing.Point(7, 262);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(162, 62);
            this.BtnAdmin.TabIndex = 9;
            this.BtnAdmin.Text = "ADMIN";
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnReport
            // 
            this.BtnReport.BorderColor = System.Drawing.Color.DimGray;
            this.BtnReport.BorderRadius = 6;
            this.BtnReport.BorderThickness = 2;
            this.BtnReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReport.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReport.FillColor = System.Drawing.Color.Black;
            this.BtnReport.FillColor2 = System.Drawing.Color.DimGray;
            this.BtnReport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Location = new System.Drawing.Point(7, 604);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(162, 62);
            this.BtnReport.TabIndex = 6;
            this.BtnReport.Text = "REPORT";
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnCommessi
            // 
            this.BtnCommessi.BorderColor = System.Drawing.Color.White;
            this.BtnCommessi.BorderRadius = 6;
            this.BtnCommessi.BorderThickness = 2;
            this.BtnCommessi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCommessi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCommessi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCommessi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCommessi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCommessi.Enabled = false;
            this.BtnCommessi.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCommessi.FillColor2 = System.Drawing.Color.DimGray;
            this.BtnCommessi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCommessi.ForeColor = System.Drawing.Color.White;
            this.BtnCommessi.Location = new System.Drawing.Point(7, 177);
            this.BtnCommessi.Name = "BtnCommessi";
            this.BtnCommessi.Size = new System.Drawing.Size(162, 62);
            this.BtnCommessi.TabIndex = 0;
            this.BtnCommessi.Text = "COMMESSI";
            this.BtnCommessi.Click += new System.EventHandler(this.BtnCommessi_Click);
            // 
            // BtnFornitori
            // 
            this.BtnFornitori.BorderColor = System.Drawing.Color.DimGray;
            this.BtnFornitori.BorderRadius = 6;
            this.BtnFornitori.BorderThickness = 2;
            this.BtnFornitori.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFornitori.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFornitori.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFornitori.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFornitori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFornitori.FillColor = System.Drawing.Color.Black;
            this.BtnFornitori.FillColor2 = System.Drawing.Color.DimGray;
            this.BtnFornitori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFornitori.ForeColor = System.Drawing.Color.White;
            this.BtnFornitori.Location = new System.Drawing.Point(7, 347);
            this.BtnFornitori.Name = "BtnFornitori";
            this.BtnFornitori.Size = new System.Drawing.Size(162, 62);
            this.BtnFornitori.TabIndex = 7;
            this.BtnFornitori.Text = "FORNITORI";
            this.BtnFornitori.Click += new System.EventHandler(this.BtnFornitori_Click);
            // 
            // BtnMagazzino
            // 
            this.BtnMagazzino.BorderColor = System.Drawing.Color.DimGray;
            this.BtnMagazzino.BorderRadius = 6;
            this.BtnMagazzino.BorderThickness = 2;
            this.BtnMagazzino.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMagazzino.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMagazzino.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMagazzino.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMagazzino.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMagazzino.FillColor = System.Drawing.Color.Black;
            this.BtnMagazzino.FillColor2 = System.Drawing.Color.DimGray;
            this.BtnMagazzino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMagazzino.ForeColor = System.Drawing.Color.White;
            this.BtnMagazzino.Location = new System.Drawing.Point(7, 518);
            this.BtnMagazzino.Name = "BtnMagazzino";
            this.BtnMagazzino.Size = new System.Drawing.Size(162, 62);
            this.BtnMagazzino.TabIndex = 8;
            this.BtnMagazzino.Text = "MAGAZZINO";
            this.BtnMagazzino.Click += new System.EventHandler(this.BtnMagazzino_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanBar
            // 
            this.PanBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanBar.Controls.Add(this.TxtRicerca);
            this.PanBar.Controls.Add(this.BtnLogout);
            this.PanBar.Controls.Add(this.BtnReimpostaPassword);
            this.PanBar.Controls.Add(this.lblUsername);
            this.PanBar.Location = new System.Drawing.Point(191, 9);
            this.PanBar.Name = "PanBar";
            this.PanBar.Size = new System.Drawing.Size(1614, 100);
            this.PanBar.TabIndex = 1;
            // 
            // TxtRicerca
            // 
            this.TxtRicerca.BorderRadius = 9;
            this.TxtRicerca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtRicerca.DefaultText = "";
            this.TxtRicerca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtRicerca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtRicerca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRicerca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtRicerca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRicerca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRicerca.ForeColor = System.Drawing.Color.Black;
            this.TxtRicerca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtRicerca.Location = new System.Drawing.Point(888, 34);
            this.TxtRicerca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRicerca.Name = "TxtRicerca";
            this.TxtRicerca.PlaceholderText = "RICERCA 🔍 ";
            this.TxtRicerca.SelectedText = "";
            this.TxtRicerca.Size = new System.Drawing.Size(272, 35);
            this.TxtRicerca.TabIndex = 11;
            this.TxtRicerca.TextChanged += new System.EventHandler(this.TxtRicerca_TextChanged);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BorderColor = System.Drawing.Color.DimGray;
            this.BtnLogout.BorderRadius = 6;
            this.BtnLogout.BorderThickness = 2;
            this.BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogout.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogout.FillColor = System.Drawing.Color.Black;
            this.BtnLogout.FillColor2 = System.Drawing.Color.DimGray;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.White;
            this.BtnLogout.Location = new System.Drawing.Point(1465, 30);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(128, 43);
            this.BtnLogout.TabIndex = 10;
            this.BtnLogout.Text = "LOGOUT";
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnReimpostaPassword
            // 
            this.BtnReimpostaPassword.BorderColor = System.Drawing.Color.DimGray;
            this.BtnReimpostaPassword.BorderRadius = 6;
            this.BtnReimpostaPassword.BorderThickness = 2;
            this.BtnReimpostaPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReimpostaPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReimpostaPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReimpostaPassword.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReimpostaPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReimpostaPassword.FillColor = System.Drawing.Color.Black;
            this.BtnReimpostaPassword.FillColor2 = System.Drawing.Color.DimGray;
            this.BtnReimpostaPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReimpostaPassword.ForeColor = System.Drawing.Color.White;
            this.BtnReimpostaPassword.Location = new System.Drawing.Point(1216, 30);
            this.BtnReimpostaPassword.Name = "BtnReimpostaPassword";
            this.BtnReimpostaPassword.Size = new System.Drawing.Size(232, 43);
            this.BtnReimpostaPassword.TabIndex = 9;
            this.BtnReimpostaPassword.Text = "REIMPOSTA PASSWORD";
            this.BtnReimpostaPassword.Click += new System.EventHandler(this.BtnReimpostaPassword_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(12, 38);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(123, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "USERNAME";
            // 
            // PanBody
            // 
            this.PanBody.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanBody.Location = new System.Drawing.Point(191, 112);
            this.PanBody.Name = "PanBody";
            this.PanBody.Size = new System.Drawing.Size(1614, 803);
            this.PanBody.TabIndex = 3;
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1817, 927);
            this.Controls.Add(this.PanBody);
            this.Controls.Add(this.PanBar);
            this.Controls.Add(this.PanMenu);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BladeVerse Armory - Gestione Negozio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAdmin_FormClosing);
            this.PanMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanBar.ResumeLayout(false);
            this.PanBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanMenu;
        private System.Windows.Forms.Panel PanBar;
        private System.Windows.Forms.Panel PanBody;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton BtnCommessi;
        private Guna.UI2.WinForms.Guna2GradientButton BtnReport;
        private Guna.UI2.WinForms.Guna2GradientButton BtnFornitori;
        private Guna.UI2.WinForms.Guna2GradientButton BtnMagazzino;
        private Guna.UI2.WinForms.Guna2GradientButton BtnReimpostaPassword;
        private Guna.UI2.WinForms.Guna2GradientButton BtnLogout;
        private Guna.UI2.WinForms.Guna2TextBox TxtRicerca;
        private Guna.UI2.WinForms.Guna2GradientButton BtnClienti;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAdmin;
    }
}