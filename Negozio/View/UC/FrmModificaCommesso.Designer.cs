namespace Negozio.View.UC
{
    partial class FrmModificaCommesso
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
            this.GbCommessi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CmbCommessi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbEmail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbCognome = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtCognome = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbNome = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtNome = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnModifica = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbInformazioni = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GbOraFine = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DtoraFine = new System.Windows.Forms.DateTimePicker();
            this.GbOraInizio = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DtoraInizio = new System.Windows.Forms.DateTimePicker();
            this.GbAssunzione = new Guna.UI2.WinForms.Guna2GroupBox();
            this.DtpAssunzione = new System.Windows.Forms.DateTimePicker();
            this.GbTutno = new Guna.UI2.WinForms.Guna2GroupBox();
            this.CmbTurni = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbCommessi.SuspendLayout();
            this.GbEmail.SuspendLayout();
            this.GbCognome.SuspendLayout();
            this.GbNome.SuspendLayout();
            this.GbInformazioni.SuspendLayout();
            this.GbOraFine.SuspendLayout();
            this.GbOraInizio.SuspendLayout();
            this.GbAssunzione.SuspendLayout();
            this.GbTutno.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbCommessi
            // 
            this.GbCommessi.Controls.Add(this.CmbCommessi);
            this.GbCommessi.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbCommessi.FillColor = System.Drawing.Color.DimGray;
            this.GbCommessi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCommessi.ForeColor = System.Drawing.Color.Black;
            this.GbCommessi.Location = new System.Drawing.Point(3, 3);
            this.GbCommessi.Name = "GbCommessi";
            this.GbCommessi.Size = new System.Drawing.Size(697, 87);
            this.GbCommessi.TabIndex = 5;
            this.GbCommessi.Text = "Seleziona il commesso";
            // 
            // CmbCommessi
            // 
            this.CmbCommessi.BackColor = System.Drawing.Color.Transparent;
            this.CmbCommessi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbCommessi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCommessi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbCommessi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbCommessi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCommessi.ForeColor = System.Drawing.Color.Black;
            this.CmbCommessi.ItemHeight = 30;
            this.CmbCommessi.Location = new System.Drawing.Point(3, 43);
            this.CmbCommessi.Name = "CmbCommessi";
            this.CmbCommessi.Size = new System.Drawing.Size(691, 36);
            this.CmbCommessi.TabIndex = 3;
            // 
            // GbEmail
            // 
            this.GbEmail.Controls.Add(this.TxtEmail);
            this.GbEmail.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.GbEmail.Enabled = false;
            this.GbEmail.FillColor = System.Drawing.Color.DimGray;
            this.GbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEmail.ForeColor = System.Drawing.Color.Black;
            this.GbEmail.Location = new System.Drawing.Point(3, 292);
            this.GbEmail.Name = "GbEmail";
            this.GbEmail.Size = new System.Drawing.Size(697, 92);
            this.GbEmail.TabIndex = 22;
            this.GbEmail.Text = "EMAIL *";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtEmail.DefaultText = "";
            this.TxtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.Black;
            this.TxtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtEmail.Location = new System.Drawing.Point(3, 48);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PlaceholderText = "";
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.Size = new System.Drawing.Size(689, 34);
            this.TxtEmail.TabIndex = 3;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // GbCognome
            // 
            this.GbCognome.Controls.Add(this.TxtCognome);
            this.GbCognome.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbCognome.Enabled = false;
            this.GbCognome.FillColor = System.Drawing.Color.DimGray;
            this.GbCognome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCognome.ForeColor = System.Drawing.Color.Black;
            this.GbCognome.Location = new System.Drawing.Point(3, 194);
            this.GbCognome.Name = "GbCognome";
            this.GbCognome.Size = new System.Drawing.Size(697, 92);
            this.GbCognome.TabIndex = 23;
            this.GbCognome.Text = "COGNOME";
            // 
            // TxtCognome
            // 
            this.TxtCognome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCognome.DefaultText = "";
            this.TxtCognome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCognome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCognome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCognome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCognome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCognome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCognome.ForeColor = System.Drawing.Color.Black;
            this.TxtCognome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCognome.Location = new System.Drawing.Point(3, 48);
            this.TxtCognome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCognome.Name = "TxtCognome";
            this.TxtCognome.PlaceholderText = "";
            this.TxtCognome.SelectedText = "";
            this.TxtCognome.Size = new System.Drawing.Size(689, 34);
            this.TxtCognome.TabIndex = 2;
            this.TxtCognome.TextChanged += new System.EventHandler(this.TxtCognome_TextChanged);
            // 
            // GbNome
            // 
            this.GbNome.Controls.Add(this.TxtNome);
            this.GbNome.CustomBorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.GbNome.Enabled = false;
            this.GbNome.FillColor = System.Drawing.Color.DimGray;
            this.GbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbNome.ForeColor = System.Drawing.Color.Black;
            this.GbNome.Location = new System.Drawing.Point(3, 96);
            this.GbNome.Name = "GbNome";
            this.GbNome.Size = new System.Drawing.Size(697, 92);
            this.GbNome.TabIndex = 21;
            this.GbNome.Text = "NOME";
            // 
            // TxtNome
            // 
            this.TxtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNome.DefaultText = "";
            this.TxtNome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.ForeColor = System.Drawing.Color.Black;
            this.TxtNome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNome.Location = new System.Drawing.Point(3, 49);
            this.TxtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.PlaceholderText = "";
            this.TxtNome.SelectedText = "";
            this.TxtNome.Size = new System.Drawing.Size(689, 34);
            this.TxtNome.TabIndex = 1;
            this.TxtNome.TextChanged += new System.EventHandler(this.TxtNome_TextChanged);
            // 
            // BtnModifica
            // 
            this.BtnModifica.BorderColor = System.Drawing.Color.White;
            this.BtnModifica.BorderRadius = 10;
            this.BtnModifica.BorderThickness = 2;
            this.BtnModifica.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnModifica.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnModifica.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModifica.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModifica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnModifica.FillColor = System.Drawing.Color.Black;
            this.BtnModifica.FillColor2 = System.Drawing.Color.SlateGray;
            this.BtnModifica.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifica.ForeColor = System.Drawing.Color.White;
            this.BtnModifica.Location = new System.Drawing.Point(3, 615);
            this.BtnModifica.Name = "BtnModifica";
            this.BtnModifica.Size = new System.Drawing.Size(697, 45);
            this.BtnModifica.TabIndex = 16;
            this.BtnModifica.Text = "MODIFICA COMMESSO";
            this.BtnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // GbInformazioni
            // 
            this.GbInformazioni.Controls.Add(this.GbOraFine);
            this.GbInformazioni.Controls.Add(this.GbOraInizio);
            this.GbInformazioni.Controls.Add(this.GbAssunzione);
            this.GbInformazioni.Controls.Add(this.GbTutno);
            this.GbInformazioni.CustomBorderColor = System.Drawing.Color.Black;
            this.GbInformazioni.Enabled = false;
            this.GbInformazioni.FillColor = System.Drawing.Color.DimGray;
            this.GbInformazioni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbInformazioni.ForeColor = System.Drawing.Color.White;
            this.GbInformazioni.Location = new System.Drawing.Point(3, 390);
            this.GbInformazioni.Name = "GbInformazioni";
            this.GbInformazioni.Size = new System.Drawing.Size(697, 219);
            this.GbInformazioni.TabIndex = 24;
            this.GbInformazioni.Text = "INFORMAZIONI *";
            // 
            // GbOraFine
            // 
            this.GbOraFine.Controls.Add(this.DtoraFine);
            this.GbOraFine.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.GbOraFine.FillColor = System.Drawing.Color.DimGray;
            this.GbOraFine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbOraFine.ForeColor = System.Drawing.Color.Black;
            this.GbOraFine.Location = new System.Drawing.Point(352, 128);
            this.GbOraFine.Name = "GbOraFine";
            this.GbOraFine.Size = new System.Drawing.Size(339, 82);
            this.GbOraFine.TabIndex = 15;
            this.GbOraFine.Text = "Orario fine";
            // 
            // DtoraFine
            // 
            this.DtoraFine.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtoraFine.Location = new System.Drawing.Point(3, 47);
            this.DtoraFine.Name = "DtoraFine";
            this.DtoraFine.ShowUpDown = true;
            this.DtoraFine.Size = new System.Drawing.Size(332, 27);
            this.DtoraFine.TabIndex = 1;
            // 
            // GbOraInizio
            // 
            this.GbOraInizio.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GbOraInizio.Controls.Add(this.DtoraInizio);
            this.GbOraInizio.CustomBorderColor = System.Drawing.SystemColors.AppWorkspace;
            this.GbOraInizio.FillColor = System.Drawing.Color.DimGray;
            this.GbOraInizio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbOraInizio.ForeColor = System.Drawing.Color.Black;
            this.GbOraInizio.Location = new System.Drawing.Point(352, 43);
            this.GbOraInizio.Name = "GbOraInizio";
            this.GbOraInizio.Size = new System.Drawing.Size(339, 82);
            this.GbOraInizio.TabIndex = 15;
            this.GbOraInizio.Text = "Orario inizio";
            // 
            // DtoraInizio
            // 
            this.DtoraInizio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DtoraInizio.Location = new System.Drawing.Point(3, 48);
            this.DtoraInizio.Name = "DtoraInizio";
            this.DtoraInizio.ShowUpDown = true;
            this.DtoraInizio.Size = new System.Drawing.Size(332, 27);
            this.DtoraInizio.TabIndex = 0;
            // 
            // GbAssunzione
            // 
            this.GbAssunzione.Controls.Add(this.DtpAssunzione);
            this.GbAssunzione.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.GbAssunzione.FillColor = System.Drawing.Color.DimGray;
            this.GbAssunzione.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbAssunzione.ForeColor = System.Drawing.Color.Black;
            this.GbAssunzione.Location = new System.Drawing.Point(6, 128);
            this.GbAssunzione.Name = "GbAssunzione";
            this.GbAssunzione.Size = new System.Drawing.Size(338, 82);
            this.GbAssunzione.TabIndex = 15;
            this.GbAssunzione.Text = "Data assunzione";
            // 
            // DtpAssunzione
            // 
            this.DtpAssunzione.Location = new System.Drawing.Point(3, 47);
            this.DtpAssunzione.Name = "DtpAssunzione";
            this.DtpAssunzione.Size = new System.Drawing.Size(331, 27);
            this.DtpAssunzione.TabIndex = 2;
            // 
            // GbTutno
            // 
            this.GbTutno.Controls.Add(this.CmbTurni);
            this.GbTutno.CustomBorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.GbTutno.FillColor = System.Drawing.Color.DimGray;
            this.GbTutno.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbTutno.ForeColor = System.Drawing.Color.Black;
            this.GbTutno.Location = new System.Drawing.Point(6, 43);
            this.GbTutno.Name = "GbTutno";
            this.GbTutno.Size = new System.Drawing.Size(338, 82);
            this.GbTutno.TabIndex = 4;
            this.GbTutno.Text = "Turno";
            // 
            // CmbTurni
            // 
            this.CmbTurni.BackColor = System.Drawing.Color.Transparent;
            this.CmbTurni.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbTurni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTurni.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbTurni.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbTurni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbTurni.ForeColor = System.Drawing.Color.Black;
            this.CmbTurni.ItemHeight = 30;
            this.CmbTurni.Location = new System.Drawing.Point(3, 43);
            this.CmbTurni.Name = "CmbTurni";
            this.CmbTurni.Size = new System.Drawing.Size(331, 36);
            this.CmbTurni.TabIndex = 3;
            // 
            // FrmModificaCommesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.GbInformazioni);
            this.Controls.Add(this.BtnModifica);
            this.Controls.Add(this.GbEmail);
            this.Controls.Add(this.GbCognome);
            this.Controls.Add(this.GbNome);
            this.Controls.Add(this.GbCommessi);
            this.Name = "FrmModificaCommesso";
            this.Size = new System.Drawing.Size(703, 664);
            this.GbCommessi.ResumeLayout(false);
            this.GbEmail.ResumeLayout(false);
            this.GbCognome.ResumeLayout(false);
            this.GbNome.ResumeLayout(false);
            this.GbInformazioni.ResumeLayout(false);
            this.GbOraFine.ResumeLayout(false);
            this.GbOraInizio.ResumeLayout(false);
            this.GbAssunzione.ResumeLayout(false);
            this.GbTutno.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox GbCommessi;
        private Guna.UI2.WinForms.Guna2ComboBox CmbCommessi;
        private Guna.UI2.WinForms.Guna2GroupBox GbEmail;
        private Guna.UI2.WinForms.Guna2GroupBox GbCognome;
        private Guna.UI2.WinForms.Guna2GroupBox GbNome;
        private Guna.UI2.WinForms.Guna2GradientButton BtnModifica;
        private Guna.UI2.WinForms.Guna2TextBox TxtNome;
        private Guna.UI2.WinForms.Guna2TextBox TxtCognome;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmail;
        private Guna.UI2.WinForms.Guna2GroupBox GbInformazioni;
        private Guna.UI2.WinForms.Guna2GroupBox GbOraFine;
        private System.Windows.Forms.DateTimePicker DtoraFine;
        private Guna.UI2.WinForms.Guna2GroupBox GbOraInizio;
        private System.Windows.Forms.DateTimePicker DtoraInizio;
        private Guna.UI2.WinForms.Guna2GroupBox GbAssunzione;
        private System.Windows.Forms.DateTimePicker DtpAssunzione;
        private Guna.UI2.WinForms.Guna2GroupBox GbTutno;
        private Guna.UI2.WinForms.Guna2ComboBox CmbTurni;
    }
}
