namespace Negozio.View.UC
{
    partial class FrmEliminaCliente
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
            this.GbEliminaCliente = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnElimina = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbListaClienti = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CmbClienti = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbEliminaCliente.SuspendLayout();
            this.GbListaClienti.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbEliminaCliente
            // 
            this.GbEliminaCliente.BorderRadius = 10;
            this.GbEliminaCliente.Controls.Add(this.BtnElimina);
            this.GbEliminaCliente.Controls.Add(this.GbListaClienti);
            this.GbEliminaCliente.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbEliminaCliente.FillColor = System.Drawing.Color.DimGray;
            this.GbEliminaCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEliminaCliente.ForeColor = System.Drawing.Color.Black;
            this.GbEliminaCliente.Location = new System.Drawing.Point(32, 177);
            this.GbEliminaCliente.Name = "GbEliminaCliente";
            this.GbEliminaCliente.Size = new System.Drawing.Size(646, 311);
            this.GbEliminaCliente.TabIndex = 2;
            this.GbEliminaCliente.Text = "SELEZIONA IL CLIENTE DA ELIMINARE";
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
            this.BtnElimina.Location = new System.Drawing.Point(12, 245);
            this.BtnElimina.Name = "BtnElimina";
            this.BtnElimina.Size = new System.Drawing.Size(618, 45);
            this.BtnElimina.TabIndex = 11;
            this.BtnElimina.Text = "ELIMINA CLIENTE";
            this.BtnElimina.Click += new System.EventHandler(this.BtnElimina_Click);
            // 
            // GbListaClienti
            // 
            this.GbListaClienti.BorderRadius = 10;
            this.GbListaClienti.Controls.Add(this.CmbClienti);
            this.GbListaClienti.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.GbListaClienti.FillColor = System.Drawing.Color.DimGray;
            this.GbListaClienti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbListaClienti.ForeColor = System.Drawing.Color.Black;
            this.GbListaClienti.Location = new System.Drawing.Point(12, 89);
            this.GbListaClienti.Name = "GbListaClienti";
            this.GbListaClienti.Size = new System.Drawing.Size(618, 120);
            this.GbListaClienti.TabIndex = 1;
            this.GbListaClienti.Text = "Lista dei clienti";
            // 
            // CmbClienti
            // 
            this.CmbClienti.BackColor = System.Drawing.Color.Transparent;
            this.CmbClienti.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbClienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbClienti.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbClienti.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbClienti.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbClienti.ForeColor = System.Drawing.Color.Black;
            this.CmbClienti.ItemHeight = 30;
            this.CmbClienti.Location = new System.Drawing.Point(14, 62);
            this.CmbClienti.Name = "CmbClienti";
            this.CmbClienti.Size = new System.Drawing.Size(590, 36);
            this.CmbClienti.TabIndex = 0;
            // 
            // FrmEliminaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.GbEliminaCliente);
            this.Name = "FrmEliminaCliente";
            this.Size = new System.Drawing.Size(703, 664);
            this.GbEliminaCliente.ResumeLayout(false);
            this.GbListaClienti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GbEliminaCliente;
        private Guna.UI2.WinForms.Guna2GradientButton BtnElimina;
        private Guna.UI2.WinForms.Guna2GroupBox GbListaClienti;
        private Guna.UI2.WinForms.Guna2ComboBox CmbClienti;
    }
}
