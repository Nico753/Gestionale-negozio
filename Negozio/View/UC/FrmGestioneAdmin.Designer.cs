namespace Negozio.View.UC
{
    partial class FrmGestioneAdmin
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
            this.GbPulsanti = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnElimina = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnModifica = new Guna.UI2.WinForms.Guna2GradientButton();
            this.BtnNuovo = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbDgv = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Dgv = new System.Windows.Forms.DataGridView();
            this.PanelEdit = new System.Windows.Forms.Panel();
            this.GbPulsanti.SuspendLayout();
            this.GbDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // GbPulsanti
            // 
            this.GbPulsanti.Controls.Add(this.BtnElimina);
            this.GbPulsanti.Controls.Add(this.BtnModifica);
            this.GbPulsanti.Controls.Add(this.BtnNuovo);
            this.GbPulsanti.CustomBorderColor = System.Drawing.Color.DimGray;
            this.GbPulsanti.FillColor = System.Drawing.Color.DimGray;
            this.GbPulsanti.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbPulsanti.ForeColor = System.Drawing.Color.White;
            this.GbPulsanti.Location = new System.Drawing.Point(885, 18);
            this.GbPulsanti.Name = "GbPulsanti";
            this.GbPulsanti.Size = new System.Drawing.Size(703, 96);
            this.GbPulsanti.TabIndex = 7;
            this.GbPulsanti.Text = "GESTIONE COMMESSO";
            // 
            // BtnElimina
            // 
            this.BtnElimina.BackColor = System.Drawing.Color.Transparent;
            this.BtnElimina.BorderRadius = 6;
            this.BtnElimina.BorderThickness = 2;
            this.BtnElimina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnElimina.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnElimina.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnElimina.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnElimina.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnElimina.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnElimina.FillColor = System.Drawing.Color.Gray;
            this.BtnElimina.FillColor2 = System.Drawing.Color.Gray;
            this.BtnElimina.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElimina.ForeColor = System.Drawing.Color.Black;
            this.BtnElimina.Location = new System.Drawing.Point(491, 38);
            this.BtnElimina.Name = "BtnElimina";
            this.BtnElimina.Size = new System.Drawing.Size(209, 50);
            this.BtnElimina.TabIndex = 4;
            this.BtnElimina.Text = "ELIMINA COMMESSO";
            // 
            // BtnModifica
            // 
            this.BtnModifica.BackColor = System.Drawing.Color.Transparent;
            this.BtnModifica.BorderRadius = 6;
            this.BtnModifica.BorderThickness = 2;
            this.BtnModifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModifica.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnModifica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnModifica.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModifica.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModifica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnModifica.FillColor = System.Drawing.Color.Gray;
            this.BtnModifica.FillColor2 = System.Drawing.Color.Gray;
            this.BtnModifica.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifica.ForeColor = System.Drawing.Color.Black;
            this.BtnModifica.Location = new System.Drawing.Point(250, 38);
            this.BtnModifica.Name = "BtnModifica";
            this.BtnModifica.Size = new System.Drawing.Size(209, 50);
            this.BtnModifica.TabIndex = 3;
            this.BtnModifica.Text = "MODIFICA COMMESSO";
            // 
            // BtnNuovo
            // 
            this.BtnNuovo.BackColor = System.Drawing.Color.Transparent;
            this.BtnNuovo.BorderRadius = 6;
            this.BtnNuovo.BorderThickness = 2;
            this.BtnNuovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnNuovo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNuovo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNuovo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNuovo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNuovo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNuovo.FillColor = System.Drawing.Color.Silver;
            this.BtnNuovo.FillColor2 = System.Drawing.Color.Silver;
            this.BtnNuovo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuovo.ForeColor = System.Drawing.Color.Black;
            this.BtnNuovo.Location = new System.Drawing.Point(3, 38);
            this.BtnNuovo.Name = "BtnNuovo";
            this.BtnNuovo.Size = new System.Drawing.Size(209, 50);
            this.BtnNuovo.TabIndex = 0;
            this.BtnNuovo.Text = "AGGIUNGI COMMESSO";
            // 
            // GbDgv
            // 
            this.GbDgv.BackColor = System.Drawing.SystemColors.Desktop;
            this.GbDgv.BorderColor = System.Drawing.Color.White;
            this.GbDgv.BorderRadius = 10;
            this.GbDgv.BorderThickness = 0;
            this.GbDgv.Controls.Add(this.Dgv);
            this.GbDgv.CustomBorderColor = System.Drawing.Color.DimGray;
            this.GbDgv.FillColor = System.Drawing.Color.DimGray;
            this.GbDgv.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDgv.ForeColor = System.Drawing.Color.White;
            this.GbDgv.Location = new System.Drawing.Point(26, 18);
            this.GbDgv.Name = "GbDgv";
            this.GbDgv.Size = new System.Drawing.Size(834, 766);
            this.GbDgv.TabIndex = 6;
            this.GbDgv.Text = "LISTA DEI COMMESSI";
            // 
            // Dgv
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.Dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv.Location = new System.Drawing.Point(3, 43);
            this.Dgv.Name = "Dgv";
            this.Dgv.Size = new System.Drawing.Size(828, 720);
            this.Dgv.TabIndex = 0;
            // 
            // PanelEdit
            // 
            this.PanelEdit.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelEdit.Location = new System.Drawing.Point(885, 120);
            this.PanelEdit.Name = "PanelEdit";
            this.PanelEdit.Size = new System.Drawing.Size(703, 664);
            this.PanelEdit.TabIndex = 5;
            // 
            // FrmGestioneAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.GbPulsanti);
            this.Controls.Add(this.GbDgv);
            this.Controls.Add(this.PanelEdit);
            this.Name = "FrmGestioneAdmin";
            this.Size = new System.Drawing.Size(1614, 803);
            this.GbPulsanti.ResumeLayout(false);
            this.GbDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GbPulsanti;
        private Guna.UI2.WinForms.Guna2GradientButton BtnElimina;
        private Guna.UI2.WinForms.Guna2GradientButton BtnModifica;
        private Guna.UI2.WinForms.Guna2GradientButton BtnNuovo;
        private Guna.UI2.WinForms.Guna2GroupBox GbDgv;
        private System.Windows.Forms.DataGridView Dgv;
        private System.Windows.Forms.Panel PanelEdit;
    }
}
