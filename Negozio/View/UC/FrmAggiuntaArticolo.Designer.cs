namespace Negozio.View.UC
{
    partial class FrmAggiuntaArticolo
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
            this.NudPrezzo = new System.Windows.Forms.NumericUpDown();
            this.NudQuantita = new System.Windows.Forms.NumericUpDown();
            this.NudIva = new System.Windows.Forms.NumericUpDown();
            this.BtnPath = new System.Windows.Forms.Button();
            this.GbFornitore = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbFornitori = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbDescrizioneArticolo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtDescrizione = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbImmagineProdotto = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbInformazioniArticolo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2GroupBox4 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GbIva = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GbPrezzo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnAggiungiArticolo = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrezzo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudIva)).BeginInit();
            this.GbFornitore.SuspendLayout();
            this.GbDescrizioneArticolo.SuspendLayout();
            this.GbImmagineProdotto.SuspendLayout();
            this.GbInformazioniArticolo.SuspendLayout();
            this.guna2GroupBox4.SuspendLayout();
            this.GbIva.SuspendLayout();
            this.GbPrezzo.SuspendLayout();
            this.SuspendLayout();
            // 
            // NudPrezzo
            // 
            this.NudPrezzo.DecimalPlaces = 2;
            this.NudPrezzo.Location = new System.Drawing.Point(3, 56);
            this.NudPrezzo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NudPrezzo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudPrezzo.Name = "NudPrezzo";
            this.NudPrezzo.Size = new System.Drawing.Size(214, 29);
            this.NudPrezzo.TabIndex = 0;
            this.NudPrezzo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudQuantita
            // 
            this.NudQuantita.Location = new System.Drawing.Point(3, 56);
            this.NudQuantita.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NudQuantita.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudQuantita.Name = "NudQuantita";
            this.NudQuantita.Size = new System.Drawing.Size(216, 29);
            this.NudQuantita.TabIndex = 4;
            this.NudQuantita.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudQuantita.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.NudQuantita.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudIva
            // 
            this.NudIva.Location = new System.Drawing.Point(3, 56);
            this.NudIva.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudIva.Name = "NudIva";
            this.NudIva.Size = new System.Drawing.Size(212, 29);
            this.NudIva.TabIndex = 1;
            this.NudIva.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // BtnPath
            // 
            this.BtnPath.Location = new System.Drawing.Point(574, 48);
            this.BtnPath.Name = "BtnPath";
            this.BtnPath.Size = new System.Drawing.Size(116, 34);
            this.BtnPath.TabIndex = 1;
            this.BtnPath.Text = "...";
            this.BtnPath.UseVisualStyleBackColor = true;
            this.BtnPath.Click += new System.EventHandler(this.BtnPath_Click);
            // 
            // GbFornitore
            // 
            this.GbFornitore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbFornitore.Controls.Add(this.TxtCategoria);
            this.GbFornitore.Controls.Add(this.CmbFornitori);
            this.GbFornitore.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbFornitore.FillColor = System.Drawing.Color.DimGray;
            this.GbFornitore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbFornitore.ForeColor = System.Drawing.Color.Black;
            this.GbFornitore.Location = new System.Drawing.Point(3, 31);
            this.GbFornitore.Name = "GbFornitore";
            this.GbFornitore.Size = new System.Drawing.Size(697, 92);
            this.GbFornitore.TabIndex = 12;
            this.GbFornitore.Text = "FORNITORE ARTICOLO *";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCategoria.DefaultText = "";
            this.TxtCategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCategoria.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.TxtCategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCategoria.Enabled = false;
            this.TxtCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoria.ForeColor = System.Drawing.Color.Black;
            this.TxtCategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCategoria.Location = new System.Drawing.Point(403, 48);
            this.TxtCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.PlaceholderText = "";
            this.TxtCategoria.SelectedText = "";
            this.TxtCategoria.Size = new System.Drawing.Size(289, 34);
            this.TxtCategoria.TabIndex = 0;
            // 
            // CmbFornitori
            // 
            this.CmbFornitori.BackColor = System.Drawing.Color.Transparent;
            this.CmbFornitori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbFornitori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbFornitori.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbFornitori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbFornitori.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbFornitori.ForeColor = System.Drawing.Color.Black;
            this.CmbFornitori.ItemHeight = 30;
            this.CmbFornitori.Location = new System.Drawing.Point(3, 46);
            this.CmbFornitori.Name = "CmbFornitori";
            this.CmbFornitori.Size = new System.Drawing.Size(393, 36);
            this.CmbFornitori.TabIndex = 12;
            // 
            // GbDescrizioneArticolo
            // 
            this.GbDescrizioneArticolo.Controls.Add(this.TxtDescrizione);
            this.GbDescrizioneArticolo.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbDescrizioneArticolo.FillColor = System.Drawing.Color.DimGray;
            this.GbDescrizioneArticolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDescrizioneArticolo.ForeColor = System.Drawing.Color.Black;
            this.GbDescrizioneArticolo.Location = new System.Drawing.Point(3, 161);
            this.GbDescrizioneArticolo.Name = "GbDescrizioneArticolo";
            this.GbDescrizioneArticolo.Size = new System.Drawing.Size(697, 92);
            this.GbDescrizioneArticolo.TabIndex = 13;
            this.GbDescrizioneArticolo.Text = "DESCRIZIONE ARTICOLO *";
            // 
            // TxtDescrizione
            // 
            this.TxtDescrizione.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtDescrizione.DefaultText = "";
            this.TxtDescrizione.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtDescrizione.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtDescrizione.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDescrizione.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtDescrizione.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDescrizione.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescrizione.ForeColor = System.Drawing.Color.Black;
            this.TxtDescrizione.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtDescrizione.Location = new System.Drawing.Point(3, 48);
            this.TxtDescrizione.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtDescrizione.Name = "TxtDescrizione";
            this.TxtDescrizione.PlaceholderText = "";
            this.TxtDescrizione.SelectedText = "";
            this.TxtDescrizione.Size = new System.Drawing.Size(689, 34);
            this.TxtDescrizione.TabIndex = 2;
            this.TxtDescrizione.TextChanged += new System.EventHandler(this.TxtDescrizione_TextChanged);
            // 
            // GbImmagineProdotto
            // 
            this.GbImmagineProdotto.Controls.Add(this.BtnPath);
            this.GbImmagineProdotto.Controls.Add(this.TxtPath);
            this.GbImmagineProdotto.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.GbImmagineProdotto.FillColor = System.Drawing.Color.DimGray;
            this.GbImmagineProdotto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbImmagineProdotto.ForeColor = System.Drawing.Color.Black;
            this.GbImmagineProdotto.Location = new System.Drawing.Point(3, 295);
            this.GbImmagineProdotto.Name = "GbImmagineProdotto";
            this.GbImmagineProdotto.Size = new System.Drawing.Size(697, 92);
            this.GbImmagineProdotto.TabIndex = 14;
            this.GbImmagineProdotto.Text = "IMMAGINE PRODOTTO";
            // 
            // TxtPath
            // 
            this.TxtPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPath.DefaultText = "";
            this.TxtPath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPath.Enabled = false;
            this.TxtPath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPath.ForeColor = System.Drawing.Color.Black;
            this.TxtPath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPath.Location = new System.Drawing.Point(3, 48);
            this.TxtPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPath.Name = "TxtPath";
            this.TxtPath.PlaceholderText = "";
            this.TxtPath.SelectedText = "";
            this.TxtPath.Size = new System.Drawing.Size(564, 34);
            this.TxtPath.TabIndex = 2;
            // 
            // GbInformazioniArticolo
            // 
            this.GbInformazioniArticolo.Controls.Add(this.guna2GroupBox4);
            this.GbInformazioniArticolo.Controls.Add(this.GbIva);
            this.GbInformazioniArticolo.Controls.Add(this.GbPrezzo);
            this.GbInformazioniArticolo.CustomBorderColor = System.Drawing.SystemColors.Desktop;
            this.GbInformazioniArticolo.FillColor = System.Drawing.Color.DimGray;
            this.GbInformazioniArticolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbInformazioniArticolo.ForeColor = System.Drawing.Color.White;
            this.GbInformazioniArticolo.Location = new System.Drawing.Point(3, 416);
            this.GbInformazioniArticolo.Name = "GbInformazioniArticolo";
            this.GbInformazioniArticolo.Size = new System.Drawing.Size(697, 158);
            this.GbInformazioniArticolo.TabIndex = 14;
            this.GbInformazioniArticolo.Text = "INFORMAZIONI PREZZO";
            // 
            // guna2GroupBox4
            // 
            this.guna2GroupBox4.Controls.Add(this.NudQuantita);
            this.guna2GroupBox4.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2GroupBox4.FillColor = System.Drawing.Color.DimGray;
            this.guna2GroupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox4.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox4.Location = new System.Drawing.Point(475, 52);
            this.guna2GroupBox4.Name = "guna2GroupBox4";
            this.guna2GroupBox4.Size = new System.Drawing.Size(213, 93);
            this.guna2GroupBox4.TabIndex = 16;
            this.guna2GroupBox4.Text = "QUANTITA\'";
            // 
            // GbIva
            // 
            this.GbIva.Controls.Add(this.NudIva);
            this.GbIva.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbIva.FillColor = System.Drawing.Color.DimGray;
            this.GbIva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbIva.ForeColor = System.Drawing.Color.Black;
            this.GbIva.Location = new System.Drawing.Point(243, 52);
            this.GbIva.Name = "GbIva";
            this.GbIva.Size = new System.Drawing.Size(218, 93);
            this.GbIva.TabIndex = 16;
            this.GbIva.Text = "IVA";
            // 
            // GbPrezzo
            // 
            this.GbPrezzo.Controls.Add(this.NudPrezzo);
            this.GbPrezzo.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbPrezzo.FillColor = System.Drawing.Color.DimGray;
            this.GbPrezzo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbPrezzo.ForeColor = System.Drawing.Color.Black;
            this.GbPrezzo.Location = new System.Drawing.Point(10, 52);
            this.GbPrezzo.Name = "GbPrezzo";
            this.GbPrezzo.Size = new System.Drawing.Size(220, 93);
            this.GbPrezzo.TabIndex = 15;
            this.GbPrezzo.Text = "PREZZO";
            // 
            // BtnAggiungiArticolo
            // 
            this.BtnAggiungiArticolo.BackColor = System.Drawing.Color.Transparent;
            this.BtnAggiungiArticolo.BorderColor = System.Drawing.Color.White;
            this.BtnAggiungiArticolo.BorderRadius = 10;
            this.BtnAggiungiArticolo.BorderThickness = 2;
            this.BtnAggiungiArticolo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAggiungiArticolo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAggiungiArticolo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAggiungiArticolo.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAggiungiArticolo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAggiungiArticolo.FillColor = System.Drawing.Color.Black;
            this.BtnAggiungiArticolo.FillColor2 = System.Drawing.Color.SlateGray;
            this.BtnAggiungiArticolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAggiungiArticolo.ForeColor = System.Drawing.Color.White;
            this.BtnAggiungiArticolo.Location = new System.Drawing.Point(3, 604);
            this.BtnAggiungiArticolo.Name = "BtnAggiungiArticolo";
            this.BtnAggiungiArticolo.Size = new System.Drawing.Size(697, 45);
            this.BtnAggiungiArticolo.TabIndex = 17;
            this.BtnAggiungiArticolo.Text = "AGGIUNGI ARTICOLO";
            this.BtnAggiungiArticolo.Click += new System.EventHandler(this.BtnAggiungiArticolo_Click);
            // 
            // FrmAggiuntaArticolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.BtnAggiungiArticolo);
            this.Controls.Add(this.GbInformazioniArticolo);
            this.Controls.Add(this.GbImmagineProdotto);
            this.Controls.Add(this.GbDescrizioneArticolo);
            this.Controls.Add(this.GbFornitore);
            this.Name = "FrmAggiuntaArticolo";
            this.Size = new System.Drawing.Size(703, 655);
            ((System.ComponentModel.ISupportInitialize)(this.NudPrezzo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudIva)).EndInit();
            this.GbFornitore.ResumeLayout(false);
            this.GbDescrizioneArticolo.ResumeLayout(false);
            this.GbImmagineProdotto.ResumeLayout(false);
            this.GbInformazioniArticolo.ResumeLayout(false);
            this.guna2GroupBox4.ResumeLayout(false);
            this.GbIva.ResumeLayout(false);
            this.GbPrezzo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NudPrezzo;
        private System.Windows.Forms.NumericUpDown NudIva;
        private System.Windows.Forms.NumericUpDown NudQuantita;
        private System.Windows.Forms.Button BtnPath;
        private Guna.UI2.WinForms.Guna2GroupBox GbFornitore;
        private Guna.UI2.WinForms.Guna2ComboBox CmbFornitori;
        private Guna.UI2.WinForms.Guna2TextBox TxtCategoria;
        private Guna.UI2.WinForms.Guna2GroupBox GbDescrizioneArticolo;
        private Guna.UI2.WinForms.Guna2TextBox TxtDescrizione;
        private Guna.UI2.WinForms.Guna2GroupBox GbImmagineProdotto;
        private Guna.UI2.WinForms.Guna2TextBox TxtPath;
        private Guna.UI2.WinForms.Guna2GroupBox GbInformazioniArticolo;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox4;
        private Guna.UI2.WinForms.Guna2GroupBox GbIva;
        private Guna.UI2.WinForms.Guna2GroupBox GbPrezzo;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAggiungiArticolo;
    }
}
