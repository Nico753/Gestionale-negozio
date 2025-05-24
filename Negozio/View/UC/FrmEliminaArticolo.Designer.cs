namespace Negozio.View.UC
{
    partial class FrmEliminaArticolo
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
            this.BtnMAX = new System.Windows.Forms.Button();
            this.NudQuantita = new System.Windows.Forms.NumericUpDown();
            this.GbRimuovi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GbQuantita = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnElimina = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbListaArticoli = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CmbArticoli = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantita)).BeginInit();
            this.GbRimuovi.SuspendLayout();
            this.GbQuantita.SuspendLayout();
            this.GbListaArticoli.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnMAX
            // 
            this.BtnMAX.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BtnMAX.Location = new System.Drawing.Point(415, 52);
            this.BtnMAX.Name = "BtnMAX";
            this.BtnMAX.Size = new System.Drawing.Size(178, 37);
            this.BtnMAX.TabIndex = 27;
            this.BtnMAX.Text = "MAX";
            this.BtnMAX.UseVisualStyleBackColor = false;
            this.BtnMAX.Click += new System.EventHandler(this.BtnMAX_Click);
            // 
            // NudQuantita
            // 
            this.NudQuantita.Location = new System.Drawing.Point(12, 58);
            this.NudQuantita.Name = "NudQuantita";
            this.NudQuantita.Size = new System.Drawing.Size(378, 29);
            this.NudQuantita.TabIndex = 1;
            this.NudQuantita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GbRimuovi
            // 
            this.GbRimuovi.BorderRadius = 10;
            this.GbRimuovi.Controls.Add(this.GbQuantita);
            this.GbRimuovi.Controls.Add(this.BtnElimina);
            this.GbRimuovi.Controls.Add(this.GbListaArticoli);
            this.GbRimuovi.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbRimuovi.FillColor = System.Drawing.Color.DimGray;
            this.GbRimuovi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbRimuovi.ForeColor = System.Drawing.Color.Black;
            this.GbRimuovi.Location = new System.Drawing.Point(31, 113);
            this.GbRimuovi.Name = "GbRimuovi";
            this.GbRimuovi.Size = new System.Drawing.Size(640, 381);
            this.GbRimuovi.TabIndex = 27;
            this.GbRimuovi.Text = "RIMUOVI QUANTITA\'";
            // 
            // GbQuantita
            // 
            this.GbQuantita.BackColor = System.Drawing.Color.Transparent;
            this.GbQuantita.BorderRadius = 10;
            this.GbQuantita.Controls.Add(this.BtnMAX);
            this.GbQuantita.Controls.Add(this.NudQuantita);
            this.GbQuantita.CustomBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.GbQuantita.FillColor = System.Drawing.Color.Transparent;
            this.GbQuantita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbQuantita.ForeColor = System.Drawing.Color.Black;
            this.GbQuantita.Location = new System.Drawing.Point(18, 188);
            this.GbQuantita.Name = "GbQuantita";
            this.GbQuantita.Size = new System.Drawing.Size(606, 106);
            this.GbQuantita.TabIndex = 2;
            this.GbQuantita.Text = "Quantita";
            // 
            // BtnElimina
            // 
            this.BtnElimina.BorderColor = System.Drawing.Color.White;
            this.BtnElimina.BorderRadius = 10;
            this.BtnElimina.BorderThickness = 2;
            this.BtnElimina.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnElimina.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnElimina.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnElimina.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnElimina.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnElimina.FillColor = System.Drawing.Color.Black;
            this.BtnElimina.FillColor2 = System.Drawing.Color.SlateGray;
            this.BtnElimina.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimina.ForeColor = System.Drawing.Color.White;
            this.BtnElimina.Location = new System.Drawing.Point(18, 304);
            this.BtnElimina.Name = "BtnElimina";
            this.BtnElimina.Size = new System.Drawing.Size(606, 45);
            this.BtnElimina.TabIndex = 11;
            this.BtnElimina.Text = "RIMUOVI QUANTITA";
            this.BtnElimina.Click += new System.EventHandler(this.BtnElimina_Click);
            // 
            // GbListaArticoli
            // 
            this.GbListaArticoli.BorderRadius = 10;
            this.GbListaArticoli.Controls.Add(this.CmbArticoli);
            this.GbListaArticoli.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.GbListaArticoli.FillColor = System.Drawing.Color.DimGray;
            this.GbListaArticoli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbListaArticoli.ForeColor = System.Drawing.Color.Black;
            this.GbListaArticoli.Location = new System.Drawing.Point(18, 72);
            this.GbListaArticoli.Name = "GbListaArticoli";
            this.GbListaArticoli.Size = new System.Drawing.Size(606, 106);
            this.GbListaArticoli.TabIndex = 1;
            this.GbListaArticoli.Text = "Lista articoli";
            // 
            // CmbArticoli
            // 
            this.CmbArticoli.BackColor = System.Drawing.Color.Transparent;
            this.CmbArticoli.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbArticoli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbArticoli.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbArticoli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbArticoli.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbArticoli.ForeColor = System.Drawing.Color.Black;
            this.CmbArticoli.ItemHeight = 30;
            this.CmbArticoli.Location = new System.Drawing.Point(12, 56);
            this.CmbArticoli.Name = "CmbArticoli";
            this.CmbArticoli.Size = new System.Drawing.Size(581, 36);
            this.CmbArticoli.TabIndex = 0;
            // 
            // FrmEliminaArticolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.GbRimuovi);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FrmEliminaArticolo";
            this.Size = new System.Drawing.Size(703, 655);
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantita)).EndInit();
            this.GbRimuovi.ResumeLayout(false);
            this.GbQuantita.ResumeLayout(false);
            this.GbListaArticoli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NudQuantita;
        private System.Windows.Forms.Button BtnMAX;
        private Guna.UI2.WinForms.Guna2GroupBox GbRimuovi;
        private Guna.UI2.WinForms.Guna2GradientButton BtnElimina;
        private Guna.UI2.WinForms.Guna2GroupBox GbListaArticoli;
        private Guna.UI2.WinForms.Guna2ComboBox CmbArticoli;
        private Guna.UI2.WinForms.Guna2GroupBox GbQuantita;
    }
}
