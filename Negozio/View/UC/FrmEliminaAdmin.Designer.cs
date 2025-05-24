namespace Negozio.View.UC
{
    partial class FrmEliminaAdmin
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
            this.GbEliminaAdmin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnElimina = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbListaAdmin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CmbAdmin = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbEliminaAdmin.SuspendLayout();
            this.GbListaAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbEliminaAdmin
            // 
            this.GbEliminaAdmin.BorderRadius = 10;
            this.GbEliminaAdmin.Controls.Add(this.BtnElimina);
            this.GbEliminaAdmin.Controls.Add(this.GbListaAdmin);
            this.GbEliminaAdmin.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbEliminaAdmin.FillColor = System.Drawing.Color.DimGray;
            this.GbEliminaAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEliminaAdmin.ForeColor = System.Drawing.Color.Black;
            this.GbEliminaAdmin.Location = new System.Drawing.Point(28, 172);
            this.GbEliminaAdmin.Name = "GbEliminaAdmin";
            this.GbEliminaAdmin.Size = new System.Drawing.Size(646, 311);
            this.GbEliminaAdmin.TabIndex = 3;
            this.GbEliminaAdmin.Text = "SELEZIONA L\'ADMIN DA ELIMINARE";
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
            this.BtnElimina.Text = "ELIMINA ADMIN";
            this.BtnElimina.Click += new System.EventHandler(this.BtnElimina_Click);
            // 
            // GbListaAdmin
            // 
            this.GbListaAdmin.BorderRadius = 10;
            this.GbListaAdmin.Controls.Add(this.CmbAdmin);
            this.GbListaAdmin.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.GbListaAdmin.FillColor = System.Drawing.Color.DimGray;
            this.GbListaAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbListaAdmin.ForeColor = System.Drawing.Color.Black;
            this.GbListaAdmin.Location = new System.Drawing.Point(12, 89);
            this.GbListaAdmin.Name = "GbListaAdmin";
            this.GbListaAdmin.Size = new System.Drawing.Size(618, 120);
            this.GbListaAdmin.TabIndex = 1;
            this.GbListaAdmin.Text = "Lista dei admin";
            // 
            // CmbAdmin
            // 
            this.CmbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.CmbAdmin.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbAdmin.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbAdmin.ForeColor = System.Drawing.Color.Black;
            this.CmbAdmin.ItemHeight = 30;
            this.CmbAdmin.Location = new System.Drawing.Point(14, 62);
            this.CmbAdmin.Name = "CmbAdmin";
            this.CmbAdmin.Size = new System.Drawing.Size(590, 36);
            this.CmbAdmin.TabIndex = 0;
            // 
            // FrmEliminaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.GbEliminaAdmin);
            this.Name = "FrmEliminaAdmin";
            this.Size = new System.Drawing.Size(703, 655);
            this.GbEliminaAdmin.ResumeLayout(false);
            this.GbListaAdmin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GbEliminaAdmin;
        private Guna.UI2.WinForms.Guna2GradientButton BtnElimina;
        private Guna.UI2.WinForms.Guna2GroupBox GbListaAdmin;
        private Guna.UI2.WinForms.Guna2ComboBox CmbAdmin;
    }
}
