namespace Negozio.View
{
    partial class FrmReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReport));
            this.GbMeseAnno = new Guna.UI2.WinForms.Guna2GroupBox();
            this.NudAnno = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.CmbMesi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbPercorso = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnPath = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSalvaReport = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAnnulla = new Guna.UI2.WinForms.Guna2Button();
            this.GbMeseAnno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudAnno)).BeginInit();
            this.GbPercorso.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbMeseAnno
            // 
            this.GbMeseAnno.Controls.Add(this.NudAnno);
            this.GbMeseAnno.Controls.Add(this.CmbMesi);
            this.GbMeseAnno.CustomBorderColor = System.Drawing.Color.White;
            this.GbMeseAnno.FillColor = System.Drawing.Color.Black;
            this.GbMeseAnno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbMeseAnno.ForeColor = System.Drawing.Color.Black;
            this.GbMeseAnno.Location = new System.Drawing.Point(12, 21);
            this.GbMeseAnno.Name = "GbMeseAnno";
            this.GbMeseAnno.Size = new System.Drawing.Size(300, 200);
            this.GbMeseAnno.TabIndex = 0;
            this.GbMeseAnno.Text = "SELEZIONA MESE ANNO";
            // 
            // NudAnno
            // 
            this.NudAnno.BackColor = System.Drawing.Color.Transparent;
            this.NudAnno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NudAnno.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NudAnno.Location = new System.Drawing.Point(13, 138);
            this.NudAnno.Name = "NudAnno";
            this.NudAnno.Size = new System.Drawing.Size(267, 36);
            this.NudAnno.TabIndex = 1;
            this.NudAnno.UpDownButtonFillColor = System.Drawing.Color.Silver;
            // 
            // CmbMesi
            // 
            this.CmbMesi.BackColor = System.Drawing.Color.Transparent;
            this.CmbMesi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbMesi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbMesi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbMesi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbMesi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbMesi.ForeColor = System.Drawing.Color.Black;
            this.CmbMesi.ItemHeight = 30;
            this.CmbMesi.Location = new System.Drawing.Point(13, 74);
            this.CmbMesi.Name = "CmbMesi";
            this.CmbMesi.Size = new System.Drawing.Size(267, 36);
            this.CmbMesi.TabIndex = 0;
            // 
            // GbPercorso
            // 
            this.GbPercorso.Controls.Add(this.TxtPath);
            this.GbPercorso.Controls.Add(this.BtnPath);
            this.GbPercorso.CustomBorderColor = System.Drawing.Color.White;
            this.GbPercorso.FillColor = System.Drawing.Color.Black;
            this.GbPercorso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbPercorso.ForeColor = System.Drawing.Color.Black;
            this.GbPercorso.Location = new System.Drawing.Point(318, 21);
            this.GbPercorso.Name = "GbPercorso";
            this.GbPercorso.Size = new System.Drawing.Size(435, 200);
            this.GbPercorso.TabIndex = 1;
            this.GbPercorso.Text = "SELEZIONA IL PERCORSO";
            // 
            // TxtPath
            // 
            this.TxtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPath.DefaultText = "";
            this.TxtPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPath.DisabledState.FillColor = System.Drawing.Color.White;
            this.TxtPath.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.TxtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.TxtPath.Enabled = false;
            this.TxtPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPath.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPath.ForeColor = System.Drawing.Color.Black;
            this.TxtPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPath.Location = new System.Drawing.Point(13, 74);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.PlaceholderText = "";
            this.TxtPath.SelectedText = "";
            this.TxtPath.Size = new System.Drawing.Size(404, 36);
            this.TxtPath.TabIndex = 3;
            // 
            // BtnPath
            // 
            this.BtnPath.BorderRadius = 5;
            this.BtnPath.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPath.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPath.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPath.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPath.ForeColor = System.Drawing.Color.White;
            this.BtnPath.Location = new System.Drawing.Point(13, 138);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(145, 45);
            this.BtnPath.TabIndex = 2;
            this.BtnPath.Text = "...";
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // BtnSalvaReport
            // 
            this.BtnSalvaReport.BorderRadius = 5;
            this.BtnSalvaReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSalvaReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSalvaReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSalvaReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSalvaReport.Enabled = false;
            this.BtnSalvaReport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSalvaReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvaReport.ForeColor = System.Drawing.Color.White;
            this.BtnSalvaReport.Location = new System.Drawing.Point(12, 253);
            this.BtnSalvaReport.Name = "BtnSalvaReport";
            this.BtnSalvaReport.Size = new System.Drawing.Size(300, 45);
            this.BtnSalvaReport.TabIndex = 4;
            this.BtnSalvaReport.Text = "SALVA IL REPORT";
            this.BtnSalvaReport.Click += new System.EventHandler(this.BtnSalvaReport_Click);
            // 
            // BtnAnnulla
            // 
            this.BtnAnnulla.BorderRadius = 5;
            this.BtnAnnulla.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAnnulla.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAnnulla.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAnnulla.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAnnulla.FillColor = System.Drawing.Color.Maroon;
            this.BtnAnnulla.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulla.ForeColor = System.Drawing.Color.White;
            this.BtnAnnulla.Location = new System.Drawing.Point(318, 253);
            this.BtnAnnulla.Name = "BtnAnnulla";
            this.BtnAnnulla.Size = new System.Drawing.Size(300, 45);
            this.BtnAnnulla.TabIndex = 5;
            this.BtnAnnulla.Text = "ANNULLA";
            this.BtnAnnulla.Click += new System.EventHandler(this.BtnAnnulla_Click_1);
            // 
            // FrmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(765, 310);
            this.Controls.Add(this.BtnAnnulla);
            this.Controls.Add(this.BtnSalvaReport);
            this.Controls.Add(this.GbPercorso);
            this.Controls.Add(this.GbMeseAnno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALVA IL REPORT";
            this.GbMeseAnno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudAnno)).EndInit();
            this.GbPercorso.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GbMeseAnno;
        private Guna.UI2.WinForms.Guna2NumericUpDown NudAnno;
        private Guna.UI2.WinForms.Guna2ComboBox CmbMesi;
        private Guna.UI2.WinForms.Guna2GroupBox GbPercorso;
        private Guna.UI2.WinForms.Guna2TextBox TxtPath;
        private Guna.UI2.WinForms.Guna2Button BtnPath;
        private Guna.UI2.WinForms.Guna2Button BtnSalvaReport;
        private Guna.UI2.WinForms.Guna2Button BtnAnnulla;
    }
}