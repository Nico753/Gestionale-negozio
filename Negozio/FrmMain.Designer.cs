namespace Negozio
{
    partial class FrmMain
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.CbPassword = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PbUtente = new System.Windows.Forms.PictureBox();
            this.TxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAccedi = new Guna.UI2.WinForms.Guna2GradientButton();
            this.TxtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUtente)).BeginInit();
            this.SuspendLayout();
            // 
            // CbPassword
            // 
            this.CbPassword.AutoSize = true;
            this.CbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.CbPassword.Location = new System.Drawing.Point(431, 401);
            this.CbPassword.Name = "CbPassword";
            this.CbPassword.Size = new System.Drawing.Size(144, 20);
            this.CbPassword.TabIndex = 5;
            this.CbPassword.Text = "Mostra password";
            this.CbPassword.UseVisualStyleBackColor = true;
            this.CbPassword.CheckedChanged += new System.EventHandler(this.CbPassword_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 481);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PbUtente
            // 
            this.PbUtente.BackColor = System.Drawing.Color.Transparent;
            this.PbUtente.Image = ((System.Drawing.Image)(resources.GetObject("PbUtente.Image")));
            this.PbUtente.Location = new System.Drawing.Point(431, 43);
            this.PbUtente.Name = "PbUtente";
            this.PbUtente.Size = new System.Drawing.Size(317, 291);
            this.PbUtente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbUtente.TabIndex = 0;
            this.PbUtente.TabStop = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPassword.BorderRadius = 12;
            this.TxtPassword.BorderThickness = 2;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.DefaultText = "";
            this.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.FocusedState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.IconLeftSize = new System.Drawing.Size(32, 20);
            this.TxtPassword.IconRightSize = new System.Drawing.Size(33, 33);
            this.TxtPassword.Location = new System.Drawing.Point(431, 358);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtPassword.PlaceholderText = "Password";
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.Size = new System.Drawing.Size(317, 36);
            this.TxtPassword.TabIndex = 1;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // BtnAccedi
            // 
            this.BtnAccedi.BorderColor = System.Drawing.Color.White;
            this.BtnAccedi.BorderRadius = 7;
            this.BtnAccedi.BorderThickness = 2;
            this.BtnAccedi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAccedi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAccedi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAccedi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAccedi.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAccedi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAccedi.FillColor = System.Drawing.Color.Black;
            this.BtnAccedi.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.BtnAccedi.FocusedColor = System.Drawing.Color.DimGray;
            this.BtnAccedi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAccedi.ForeColor = System.Drawing.Color.White;
            this.BtnAccedi.Location = new System.Drawing.Point(431, 427);
            this.BtnAccedi.Name = "BtnAccedi";
            this.BtnAccedi.Size = new System.Drawing.Size(317, 45);
            this.BtnAccedi.TabIndex = 2;
            this.BtnAccedi.Text = "ACCEDI";
            this.BtnAccedi.Click += new System.EventHandler(this.BtnAccedi_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUsername.BorderRadius = 12;
            this.TxtUsername.BorderThickness = 2;
            this.TxtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUsername.DefaultText = "";
            this.TxtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUsername.FocusedState.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.Color.Black;
            this.TxtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUsername.IconLeftSize = new System.Drawing.Size(32, 20);
            this.TxtUsername.IconRightSize = new System.Drawing.Size(33, 33);
            this.TxtUsername.Location = new System.Drawing.Point(431, 314);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TxtUsername.PlaceholderText = "Username";
            this.TxtUsername.SelectedText = "";
            this.TxtUsername.Size = new System.Drawing.Size(317, 36);
            this.TxtUsername.TabIndex = 0;
            this.TxtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1168, 618);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.BtnAccedi);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.CbPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PbUtente);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BladeVerse Armory - LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUtente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PbUtente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox CbPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtPassword;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAccedi;
        private Guna.UI2.WinForms.Guna2TextBox TxtUsername;
    }
}

