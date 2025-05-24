namespace Negozio.View.UC
{
    partial class FrmEliminaFornitore
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
            this.GbEliminaFornitore = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnElimina = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbListaFornitori = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CmbFornitori = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbEliminaFornitore.SuspendLayout();
            this.GbListaFornitori.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbEliminaFornitore
            // 
            this.GbEliminaFornitore.BorderRadius = 10;
            this.GbEliminaFornitore.Controls.Add(this.BtnElimina);
            this.GbEliminaFornitore.Controls.Add(this.GbListaFornitori);
            this.GbEliminaFornitore.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbEliminaFornitore.FillColor = System.Drawing.Color.DimGray;
            this.GbEliminaFornitore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEliminaFornitore.ForeColor = System.Drawing.Color.Black;
            this.GbEliminaFornitore.Location = new System.Drawing.Point(24, 158);
            this.GbEliminaFornitore.Name = "GbEliminaFornitore";
            this.GbEliminaFornitore.Size = new System.Drawing.Size(648, 311);
            this.GbEliminaFornitore.TabIndex = 1;
            this.GbEliminaFornitore.Text = "SELEZIONA IL FORNITORE DA ELIMINARE";
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
            this.BtnElimina.Location = new System.Drawing.Point(15, 231);
            this.BtnElimina.Name = "BtnElimina";
            this.BtnElimina.Size = new System.Drawing.Size(618, 45);
            this.BtnElimina.TabIndex = 11;
            this.BtnElimina.Text = "ELIMINA FORNITORE";
            this.BtnElimina.Click += new System.EventHandler(this.BtnElimina_Click);
            // 
            // GbListaFornitori
            // 
            this.GbListaFornitori.BorderRadius = 10;
            this.GbListaFornitori.Controls.Add(this.CmbFornitori);
            this.GbListaFornitori.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.GbListaFornitori.FillColor = System.Drawing.Color.DimGray;
            this.GbListaFornitori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbListaFornitori.ForeColor = System.Drawing.Color.Black;
            this.GbListaFornitori.Location = new System.Drawing.Point(15, 70);
            this.GbListaFornitori.Name = "GbListaFornitori";
            this.GbListaFornitori.Size = new System.Drawing.Size(618, 120);
            this.GbListaFornitori.TabIndex = 1;
            this.GbListaFornitori.Text = "Lista dei fornitori";
            // 
            // CmbFornitori
            // 
            this.CmbFornitori.BackColor = System.Drawing.Color.Transparent;
            this.CmbFornitori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbFornitori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFornitori.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbFornitori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbFornitori.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFornitori.ForeColor = System.Drawing.Color.Black;
            this.CmbFornitori.ItemHeight = 30;
            this.CmbFornitori.Location = new System.Drawing.Point(14, 62);
            this.CmbFornitori.Name = "CmbFornitori";
            this.CmbFornitori.Size = new System.Drawing.Size(590, 36);
            this.CmbFornitori.TabIndex = 0;
            // 
            // FrmEliminaFornitore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.GbEliminaFornitore);
            this.Name = "FrmEliminaFornitore";
            this.Size = new System.Drawing.Size(703, 664);
            this.GbEliminaFornitore.ResumeLayout(false);
            this.GbListaFornitori.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GbEliminaFornitore;
        private Guna.UI2.WinForms.Guna2GradientButton BtnElimina;
        private Guna.UI2.WinForms.Guna2GroupBox GbListaFornitori;
        private Guna.UI2.WinForms.Guna2ComboBox CmbFornitori;
    }
}
