namespace Negozio.View
{
    partial class FrmCommesso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommesso));
            this.PanBody = new System.Windows.Forms.Panel();
            this.PanBar = new System.Windows.Forms.Panel();
            this.TxtRicerca = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnLogout = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnReimpostaPassword = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.PanCarrello = new System.Windows.Forms.Panel();
            this.PanCategorie = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanBtnCassa = new System.Windows.Forms.Panel();
            this.BtnCassa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.PanTotale = new System.Windows.Forms.Panel();
            this.LblTotale = new System.Windows.Forms.Label();
            this.PanBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanBtnCassa.SuspendLayout();
            this.PanTotale.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanBody
            // 
            this.PanBody.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanBody.Location = new System.Drawing.Point(208, 113);
            this.PanBody.Name = "PanBody";
            this.PanBody.Size = new System.Drawing.Size(1354, 803);
            this.PanBody.TabIndex = 100;
            // 
            // PanBar
            // 
            this.PanBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanBar.Controls.Add(this.TxtRicerca);
            this.PanBar.Controls.Add(this.BtnLogout);
            this.PanBar.Controls.Add(this.BtnReimpostaPassword);
            this.PanBar.Controls.Add(this.lblUsername);
            this.PanBar.Location = new System.Drawing.Point(208, 10);
            this.PanBar.Name = "PanBar";
            this.PanBar.Size = new System.Drawing.Size(1354, 100);
            this.PanBar.TabIndex = 5;
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
            this.TxtRicerca.Location = new System.Drawing.Point(613, 34);
            this.TxtRicerca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtRicerca.Name = "TxtRicerca";
            this.TxtRicerca.PlaceholderText = "RICERCA 🔍 ";
            this.TxtRicerca.SelectedText = "";
            this.TxtRicerca.Size = new System.Drawing.Size(272, 35);
            this.TxtRicerca.TabIndex = 14;
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
            this.BtnLogout.Location = new System.Drawing.Point(1190, 30);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(128, 43);
            this.BtnLogout.TabIndex = 13;
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
            this.BtnReimpostaPassword.Location = new System.Drawing.Point(941, 30);
            this.BtnReimpostaPassword.Name = "BtnReimpostaPassword";
            this.BtnReimpostaPassword.Size = new System.Drawing.Size(232, 43);
            this.BtnReimpostaPassword.TabIndex = 12;
            this.BtnReimpostaPassword.Text = "REIMPOSTA PASSWORD";
            this.BtnReimpostaPassword.Click += new System.EventHandler(this.BtnReimpostaPassword_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(12, 38);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(123, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "USERNAME";
            // 
            // PanCarrello
            // 
            this.PanCarrello.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanCarrello.ForeColor = System.Drawing.SystemColors.Control;
            this.PanCarrello.Location = new System.Drawing.Point(1568, 10);
            this.PanCarrello.Name = "PanCarrello";
            this.PanCarrello.Size = new System.Drawing.Size(294, 711);
            this.PanCarrello.TabIndex = 6;
            // 
            // PanCategorie
            // 
            this.PanCategorie.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanCategorie.Location = new System.Drawing.Point(12, 193);
            this.PanCategorie.Name = "PanCategorie";
            this.PanCategorie.Size = new System.Drawing.Size(190, 722);
            this.PanCategorie.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanBtnCassa
            // 
            this.PanBtnCassa.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanBtnCassa.Controls.Add(this.BtnCassa);
            this.PanBtnCassa.Location = new System.Drawing.Point(1568, 824);
            this.PanBtnCassa.Name = "PanBtnCassa";
            this.PanBtnCassa.Size = new System.Drawing.Size(294, 91);
            this.PanBtnCassa.TabIndex = 7;
            // 
            // BtnCassa
            // 
            this.BtnCassa.BorderColor = System.Drawing.Color.White;
            this.BtnCassa.BorderRadius = 6;
            this.BtnCassa.BorderThickness = 2;
            this.BtnCassa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnCassa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnCassa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCassa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnCassa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnCassa.FillColor = System.Drawing.Color.Black;
            this.BtnCassa.FillColor2 = System.Drawing.Color.DimGray;
            this.BtnCassa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCassa.ForeColor = System.Drawing.Color.White;
            this.BtnCassa.Location = new System.Drawing.Point(15, 14);
            this.BtnCassa.Name = "BtnCassa";
            this.BtnCassa.Size = new System.Drawing.Size(265, 64);
            this.BtnCassa.TabIndex = 13;
            this.BtnCassa.Text = "CASSA";
            this.BtnCassa.Click += new System.EventHandler(this.BtnCassa_Click);
            // 
            // PanTotale
            // 
            this.PanTotale.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanTotale.Controls.Add(this.LblTotale);
            this.PanTotale.Location = new System.Drawing.Point(1568, 727);
            this.PanTotale.Name = "PanTotale";
            this.PanTotale.Size = new System.Drawing.Size(294, 91);
            this.PanTotale.TabIndex = 8;
            // 
            // LblTotale
            // 
            this.LblTotale.AutoSize = true;
            this.LblTotale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotale.ForeColor = System.Drawing.SystemColors.Control;
            this.LblTotale.Location = new System.Drawing.Point(10, 32);
            this.LblTotale.Name = "LblTotale";
            this.LblTotale.Size = new System.Drawing.Size(88, 25);
            this.LblTotale.TabIndex = 0;
            this.LblTotale.Text = "TOTALE :";
            // 
            // FrmCommesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1874, 927);
            this.Controls.Add(this.PanTotale);
            this.Controls.Add(this.PanBtnCassa);
            this.Controls.Add(this.PanCategorie);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanCarrello);
            this.Controls.Add(this.PanBody);
            this.Controls.Add(this.PanBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCommesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CASSA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCommesso_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCommesso_KeyDown);
            this.PanBar.ResumeLayout(false);
            this.PanBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanBtnCassa.ResumeLayout(false);
            this.PanTotale.ResumeLayout(false);
            this.PanTotale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanBody;
        private System.Windows.Forms.Panel PanBar;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel PanCarrello;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanCategorie;
        private System.Windows.Forms.Panel PanBtnCassa;
        private System.Windows.Forms.Panel PanTotale;
        private System.Windows.Forms.Label LblTotale;
        private Guna.UI2.WinForms.Guna2TextBox TxtRicerca;
        private Guna.UI2.WinForms.Guna2GradientButton BtnLogout;
        private Guna.UI2.WinForms.Guna2GradientButton BtnReimpostaPassword;
        private Guna.UI2.WinForms.Guna2GradientButton BtnCassa;
    }
}