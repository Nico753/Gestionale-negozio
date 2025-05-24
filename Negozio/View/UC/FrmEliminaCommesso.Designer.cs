namespace Negozio.View.UC
{
    partial class FrmEliminaCommesso
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
            this.GbEliminaCommesso = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnElimina = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbListaCommessi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CmbCommessi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbEliminaCommesso.SuspendLayout();
            this.GbListaCommessi.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbEliminaCommesso
            // 
            this.GbEliminaCommesso.BorderRadius = 10;
            this.GbEliminaCommesso.Controls.Add(this.BtnElimina);
            this.GbEliminaCommesso.Controls.Add(this.GbListaCommessi);
            this.GbEliminaCommesso.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbEliminaCommesso.FillColor = System.Drawing.Color.DimGray;
            this.GbEliminaCommesso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEliminaCommesso.ForeColor = System.Drawing.Color.Black;
            this.GbEliminaCommesso.Location = new System.Drawing.Point(27, 161);
            this.GbEliminaCommesso.Name = "GbEliminaCommesso";
            this.GbEliminaCommesso.Size = new System.Drawing.Size(650, 311);
            this.GbEliminaCommesso.TabIndex = 0;
            this.GbEliminaCommesso.Text = "SLELEZIONA IL COMMESSO DA ELIMINARE";
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
            this.BtnElimina.Location = new System.Drawing.Point(20, 238);
            this.BtnElimina.Name = "BtnElimina";
            this.BtnElimina.Size = new System.Drawing.Size(613, 45);
            this.BtnElimina.TabIndex = 11;
            this.BtnElimina.Text = "ELIMINA COMMESSO";
            this.BtnElimina.Click += new System.EventHandler(this.BtnElimina_Click);
            // 
            // GbListaCommessi
            // 
            this.GbListaCommessi.BorderRadius = 10;
            this.GbListaCommessi.Controls.Add(this.CmbCommessi);
            this.GbListaCommessi.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.GbListaCommessi.FillColor = System.Drawing.Color.DimGray;
            this.GbListaCommessi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbListaCommessi.ForeColor = System.Drawing.Color.Black;
            this.GbListaCommessi.Location = new System.Drawing.Point(15, 82);
            this.GbListaCommessi.Name = "GbListaCommessi";
            this.GbListaCommessi.Size = new System.Drawing.Size(618, 120);
            this.GbListaCommessi.TabIndex = 1;
            this.GbListaCommessi.Text = "Lista dei commessi";
            // 
            // CmbCommessi
            // 
            this.CmbCommessi.BackColor = System.Drawing.Color.Transparent;
            this.CmbCommessi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbCommessi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCommessi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbCommessi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbCommessi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCommessi.ForeColor = System.Drawing.Color.Black;
            this.CmbCommessi.ItemHeight = 30;
            this.CmbCommessi.Location = new System.Drawing.Point(14, 62);
            this.CmbCommessi.Name = "CmbCommessi";
            this.CmbCommessi.Size = new System.Drawing.Size(590, 36);
            this.CmbCommessi.TabIndex = 0;
            // 
            // FrmEliminaCommesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.GbEliminaCommesso);
            this.Name = "FrmEliminaCommesso";
            this.Size = new System.Drawing.Size(703, 664);
            this.GbEliminaCommesso.ResumeLayout(false);
            this.GbListaCommessi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GbEliminaCommesso;
        private Guna.UI2.WinForms.Guna2GroupBox GbListaCommessi;
        private Guna.UI2.WinForms.Guna2ComboBox CmbCommessi;
        private Guna.UI2.WinForms.Guna2GradientButton BtnElimina;
    }
}
