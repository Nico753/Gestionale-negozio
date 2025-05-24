using System;

namespace Negozio.View.UC
{
    partial class FrmReimpostaPassword
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
            this.components = new System.ComponentModel.Container();
            this.GbDati = new System.Windows.Forms.GroupBox();
            this.GbConferma = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CbConferma = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TxtConferma = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbNuovaPassword = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CbNuova = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TxtNuovaPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbPasswordPrecedente = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CbPrecedente = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TxtPrecedente = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.BtnModificaPassword = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbDati.SuspendLayout();
            this.GbConferma.SuspendLayout();
            this.GbNuovaPassword.SuspendLayout();
            this.GbPasswordPrecedente.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbDati
            // 
            this.GbDati.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GbDati.Controls.Add(this.BtnModificaPassword);
            this.GbDati.Controls.Add(this.GbConferma);
            this.GbDati.Controls.Add(this.GbNuovaPassword);
            this.GbDati.Controls.Add(this.GbPasswordPrecedente);
            this.GbDati.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GbDati.Location = new System.Drawing.Point(351, 117);
            this.GbDati.Name = "GbDati";
            this.GbDati.Size = new System.Drawing.Size(924, 540);
            this.GbDati.TabIndex = 0;
            this.GbDati.TabStop = false;
            // 
            // GbConferma
            // 
            this.GbConferma.BorderRadius = 10;
            this.GbConferma.Controls.Add(this.CbConferma);
            this.GbConferma.Controls.Add(this.TxtConferma);
            this.GbConferma.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GbConferma.FillColor = System.Drawing.Color.DimGray;
            this.GbConferma.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbConferma.ForeColor = System.Drawing.Color.Black;
            this.GbConferma.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GbConferma.Location = new System.Drawing.Point(32, 314);
            this.GbConferma.Name = "GbConferma";
            this.GbConferma.Size = new System.Drawing.Size(856, 130);
            this.GbConferma.TabIndex = 5;
            this.GbConferma.Text = "CONFERMA NUOVA PASSWORD";
            this.GbConferma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbConferma
            // 
            this.CbConferma.AutoSize = true;
            this.CbConferma.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbConferma.CheckedState.BorderRadius = 0;
            this.CbConferma.CheckedState.BorderThickness = 0;
            this.CbConferma.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbConferma.Location = new System.Drawing.Point(6, 97);
            this.CbConferma.Name = "CbConferma";
            this.CbConferma.Size = new System.Drawing.Size(195, 25);
            this.CbConferma.TabIndex = 1;
            this.CbConferma.Text = "MOSTRA PASSWORD";
            this.CbConferma.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CbConferma.UncheckedState.BorderRadius = 0;
            this.CbConferma.UncheckedState.BorderThickness = 0;
            this.CbConferma.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CbConferma.CheckedChanged += new System.EventHandler(this.CbConferma_CheckedChanged);
            // 
            // TxtConferma
            // 
            this.TxtConferma.BorderColor = System.Drawing.Color.Black;
            this.TxtConferma.BorderRadius = 10;
            this.TxtConferma.BorderThickness = 2;
            this.TxtConferma.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtConferma.DefaultText = "";
            this.TxtConferma.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtConferma.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtConferma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtConferma.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtConferma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtConferma.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConferma.ForeColor = System.Drawing.Color.Black;
            this.TxtConferma.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtConferma.Location = new System.Drawing.Point(6, 54);
            this.TxtConferma.Name = "TxtConferma";
            this.TxtConferma.PlaceholderText = "";
            this.TxtConferma.SelectedText = "";
            this.TxtConferma.Size = new System.Drawing.Size(844, 36);
            this.TxtConferma.TabIndex = 0;
            this.TxtConferma.UseSystemPasswordChar = true;
            this.TxtConferma.TextChanged += new System.EventHandler(this.TxtConferma_TextChanged);
            // 
            // GbNuovaPassword
            // 
            this.GbNuovaPassword.BorderRadius = 10;
            this.GbNuovaPassword.Controls.Add(this.CbNuova);
            this.GbNuovaPassword.Controls.Add(this.TxtNuovaPassword);
            this.GbNuovaPassword.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GbNuovaPassword.FillColor = System.Drawing.Color.DimGray;
            this.GbNuovaPassword.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbNuovaPassword.ForeColor = System.Drawing.Color.Black;
            this.GbNuovaPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GbNuovaPassword.Location = new System.Drawing.Point(32, 165);
            this.GbNuovaPassword.Name = "GbNuovaPassword";
            this.GbNuovaPassword.Size = new System.Drawing.Size(856, 130);
            this.GbNuovaPassword.TabIndex = 4;
            this.GbNuovaPassword.Text = "NUOVA PASSWORD";
            this.GbNuovaPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbNuova
            // 
            this.CbNuova.AutoSize = true;
            this.CbNuova.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbNuova.CheckedState.BorderRadius = 0;
            this.CbNuova.CheckedState.BorderThickness = 0;
            this.CbNuova.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbNuova.Location = new System.Drawing.Point(6, 97);
            this.CbNuova.Name = "CbNuova";
            this.CbNuova.Size = new System.Drawing.Size(195, 25);
            this.CbNuova.TabIndex = 1;
            this.CbNuova.Text = "MOSTRA PASSWORD";
            this.CbNuova.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CbNuova.UncheckedState.BorderRadius = 0;
            this.CbNuova.UncheckedState.BorderThickness = 0;
            this.CbNuova.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CbNuova.CheckedChanged += new System.EventHandler(this.CbNuova_CheckedChanged);
            // 
            // TxtNuovaPassword
            // 
            this.TxtNuovaPassword.BorderColor = System.Drawing.Color.Black;
            this.TxtNuovaPassword.BorderRadius = 10;
            this.TxtNuovaPassword.BorderThickness = 2;
            this.TxtNuovaPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNuovaPassword.DefaultText = "";
            this.TxtNuovaPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNuovaPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNuovaPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNuovaPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNuovaPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNuovaPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNuovaPassword.ForeColor = System.Drawing.Color.Black;
            this.TxtNuovaPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNuovaPassword.Location = new System.Drawing.Point(6, 54);
            this.TxtNuovaPassword.Name = "TxtNuovaPassword";
            this.TxtNuovaPassword.PlaceholderText = "";
            this.TxtNuovaPassword.SelectedText = "";
            this.TxtNuovaPassword.Size = new System.Drawing.Size(844, 36);
            this.TxtNuovaPassword.TabIndex = 0;
            this.TxtNuovaPassword.UseSystemPasswordChar = true;
            this.TxtNuovaPassword.TextChanged += new System.EventHandler(this.TxtNuovaPassword_TextChanged);
            // 
            // GbPasswordPrecedente
            // 
            this.GbPasswordPrecedente.BorderRadius = 10;
            this.GbPasswordPrecedente.Controls.Add(this.CbPrecedente);
            this.GbPasswordPrecedente.Controls.Add(this.TxtPrecedente);
            this.GbPasswordPrecedente.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GbPasswordPrecedente.FillColor = System.Drawing.Color.DimGray;
            this.GbPasswordPrecedente.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbPasswordPrecedente.ForeColor = System.Drawing.Color.Black;
            this.GbPasswordPrecedente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GbPasswordPrecedente.Location = new System.Drawing.Point(32, 19);
            this.GbPasswordPrecedente.Name = "GbPasswordPrecedente";
            this.GbPasswordPrecedente.Size = new System.Drawing.Size(856, 130);
            this.GbPasswordPrecedente.TabIndex = 3;
            this.GbPasswordPrecedente.Text = "PASSWORD PRECEDENTE";
            this.GbPasswordPrecedente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CbPrecedente
            // 
            this.CbPrecedente.AutoSize = true;
            this.CbPrecedente.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbPrecedente.CheckedState.BorderRadius = 0;
            this.CbPrecedente.CheckedState.BorderThickness = 0;
            this.CbPrecedente.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbPrecedente.Location = new System.Drawing.Point(6, 97);
            this.CbPrecedente.Name = "CbPrecedente";
            this.CbPrecedente.Size = new System.Drawing.Size(195, 25);
            this.CbPrecedente.TabIndex = 1;
            this.CbPrecedente.Text = "MOSTRA PASSWORD";
            this.CbPrecedente.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CbPrecedente.UncheckedState.BorderRadius = 0;
            this.CbPrecedente.UncheckedState.BorderThickness = 0;
            this.CbPrecedente.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.CbPrecedente.CheckedChanged += new System.EventHandler(this.CbPrecedente_CheckedChanged);
            // 
            // TxtPrecedente
            // 
            this.TxtPrecedente.BorderColor = System.Drawing.Color.Black;
            this.TxtPrecedente.BorderRadius = 10;
            this.TxtPrecedente.BorderThickness = 2;
            this.TxtPrecedente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPrecedente.DefaultText = "";
            this.TxtPrecedente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPrecedente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPrecedente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrecedente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPrecedente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrecedente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecedente.ForeColor = System.Drawing.Color.Black;
            this.TxtPrecedente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPrecedente.Location = new System.Drawing.Point(6, 54);
            this.TxtPrecedente.Name = "TxtPrecedente";
            this.TxtPrecedente.PlaceholderText = "";
            this.TxtPrecedente.SelectedText = "";
            this.TxtPrecedente.Size = new System.Drawing.Size(844, 36);
            this.TxtPrecedente.TabIndex = 0;
            this.TxtPrecedente.UseSystemPasswordChar = true;
            // 
            // BtnModificaPassword
            // 
            this.BtnModificaPassword.BorderColor = System.Drawing.Color.White;
            this.BtnModificaPassword.BorderRadius = 10;
            this.BtnModificaPassword.BorderThickness = 2;
            this.BtnModificaPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificaPassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnModificaPassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnModificaPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModificaPassword.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModificaPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnModificaPassword.FillColor = System.Drawing.Color.Black;
            this.BtnModificaPassword.FillColor2 = System.Drawing.Color.DimGray;
            this.BtnModificaPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificaPassword.ForeColor = System.Drawing.Color.White;
            this.BtnModificaPassword.Location = new System.Drawing.Point(32, 478);
            this.BtnModificaPassword.Name = "BtnModificaPassword";
            this.BtnModificaPassword.Size = new System.Drawing.Size(856, 45);
            this.BtnModificaPassword.TabIndex = 6;
            this.BtnModificaPassword.Text = "REIMPOSTA PASSWORD";
            this.BtnModificaPassword.Click += new System.EventHandler(this.BtnModificaPassword_Click);
            // 
            // FrmReimpostaPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.GbDati);
            this.Name = "FrmReimpostaPassword";
            this.Size = new System.Drawing.Size(1614, 803);
            this.GbDati.ResumeLayout(false);
            this.GbConferma.ResumeLayout(false);
            this.GbConferma.PerformLayout();
            this.GbNuovaPassword.ResumeLayout(false);
            this.GbNuovaPassword.PerformLayout();
            this.GbPasswordPrecedente.ResumeLayout(false);
            this.GbPasswordPrecedente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDati;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2GroupBox GbPasswordPrecedente;
        private Guna.UI2.WinForms.Guna2CheckBox CbPrecedente;
        private Guna.UI2.WinForms.Guna2TextBox TxtPrecedente;
        private Guna.UI2.WinForms.Guna2GroupBox GbConferma;
        private Guna.UI2.WinForms.Guna2CheckBox CbConferma;
        private Guna.UI2.WinForms.Guna2TextBox TxtConferma;
        private Guna.UI2.WinForms.Guna2GroupBox GbNuovaPassword;
        private Guna.UI2.WinForms.Guna2CheckBox CbNuova;
        private Guna.UI2.WinForms.Guna2TextBox TxtNuovaPassword;
        private Guna.UI2.WinForms.Guna2GradientButton BtnModificaPassword;
    }
}
