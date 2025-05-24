namespace Negozio.View.UC
{
    partial class FrmModificaArticolo
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
            this.GbFornitore = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbFornitori = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbInformazioniArticolo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.GbIva = new Guna.UI2.WinForms.Guna2GroupBox();
            this.NudIva = new System.Windows.Forms.NumericUpDown();
            this.GbPrezzo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.NudPrezzo = new System.Windows.Forms.NumericUpDown();
            this.GbImmagineProdotto = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnPath = new System.Windows.Forms.Button();
            this.TxtPath = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbDescrizioneArticolo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtDescrizione = new Guna.UI2.WinForms.Guna2TextBox();
            this.CmbArticoli = new Guna.UI2.WinForms.Guna2ComboBox();
            this.GbListaArticoli = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnModifica = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbRifornisciMagazzino = new Guna.UI2.WinForms.Guna2GroupBox();
            this.BtnRifornisci = new Guna.UI2.WinForms.Guna2GradientButton();
            this.NudQuantitaR = new System.Windows.Forms.NumericUpDown();
            this.GbFornitore.SuspendLayout();
            this.GbInformazioniArticolo.SuspendLayout();
            this.GbIva.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudIva)).BeginInit();
            this.GbPrezzo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudPrezzo)).BeginInit();
            this.GbImmagineProdotto.SuspendLayout();
            this.GbDescrizioneArticolo.SuspendLayout();
            this.GbListaArticoli.SuspendLayout();
            this.GbRifornisciMagazzino.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantitaR)).BeginInit();
            this.SuspendLayout();
            // 
            // GbFornitore
            // 
            this.GbFornitore.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbFornitore.Controls.Add(this.TxtCategoria);
            this.GbFornitore.Controls.Add(this.CmbFornitori);
            this.GbFornitore.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbFornitore.Enabled = false;
            this.GbFornitore.FillColor = System.Drawing.Color.DimGray;
            this.GbFornitore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbFornitore.ForeColor = System.Drawing.Color.Black;
            this.GbFornitore.Location = new System.Drawing.Point(3, 113);
            this.GbFornitore.Name = "GbFornitore";
            this.GbFornitore.Size = new System.Drawing.Size(697, 92);
            this.GbFornitore.TabIndex = 19;
            this.GbFornitore.Text = "FORNITORE ARTICOLO - CATEGORIA ARTICOLO*";
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
            this.TxtCategoria.Location = new System.Drawing.Point(357, 48);
            this.TxtCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.PlaceholderText = "";
            this.TxtCategoria.SelectedText = "";
            this.TxtCategoria.Size = new System.Drawing.Size(333, 34);
            this.TxtCategoria.TabIndex = 0;
            this.TxtCategoria.TextChanged += new System.EventHandler(this.TxtCategoria_TextChanged);
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
            this.CmbFornitori.Size = new System.Drawing.Size(347, 36);
            this.CmbFornitori.TabIndex = 12;
            // 
            // GbInformazioniArticolo
            // 
            this.GbInformazioniArticolo.Controls.Add(this.GbRifornisciMagazzino);
            this.GbInformazioniArticolo.Controls.Add(this.GbIva);
            this.GbInformazioniArticolo.Controls.Add(this.GbPrezzo);
            this.GbInformazioniArticolo.CustomBorderColor = System.Drawing.SystemColors.Desktop;
            this.GbInformazioniArticolo.Enabled = false;
            this.GbInformazioniArticolo.FillColor = System.Drawing.Color.DimGray;
            this.GbInformazioniArticolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbInformazioniArticolo.ForeColor = System.Drawing.Color.White;
            this.GbInformazioniArticolo.Location = new System.Drawing.Point(3, 433);
            this.GbInformazioniArticolo.Name = "GbInformazioniArticolo";
            this.GbInformazioniArticolo.Size = new System.Drawing.Size(697, 158);
            this.GbInformazioniArticolo.TabIndex = 29;
            this.GbInformazioniArticolo.Text = "INFORMAZIONI PREZZO";
            // 
            // GbIva
            // 
            this.GbIva.Controls.Add(this.NudIva);
            this.GbIva.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbIva.FillColor = System.Drawing.Color.DimGray;
            this.GbIva.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbIva.ForeColor = System.Drawing.Color.Black;
            this.GbIva.Location = new System.Drawing.Point(10, 52);
            this.GbIva.Name = "GbIva";
            this.GbIva.Size = new System.Drawing.Size(182, 93);
            this.GbIva.TabIndex = 16;
            this.GbIva.Text = "IVA";
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
            this.NudIva.Size = new System.Drawing.Size(176, 29);
            this.NudIva.TabIndex = 1;
            this.NudIva.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // GbPrezzo
            // 
            this.GbPrezzo.Controls.Add(this.NudPrezzo);
            this.GbPrezzo.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbPrezzo.FillColor = System.Drawing.Color.DimGray;
            this.GbPrezzo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbPrezzo.ForeColor = System.Drawing.Color.Black;
            this.GbPrezzo.Location = new System.Drawing.Point(198, 52);
            this.GbPrezzo.Name = "GbPrezzo";
            this.GbPrezzo.Size = new System.Drawing.Size(182, 93);
            this.GbPrezzo.TabIndex = 15;
            this.GbPrezzo.Text = "PREZZO";
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
            this.NudPrezzo.Size = new System.Drawing.Size(176, 29);
            this.NudPrezzo.TabIndex = 0;
            this.NudPrezzo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // GbImmagineProdotto
            // 
            this.GbImmagineProdotto.Controls.Add(this.BtnPath);
            this.GbImmagineProdotto.Controls.Add(this.TxtPath);
            this.GbImmagineProdotto.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.GbImmagineProdotto.Enabled = false;
            this.GbImmagineProdotto.FillColor = System.Drawing.Color.DimGray;
            this.GbImmagineProdotto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbImmagineProdotto.ForeColor = System.Drawing.Color.Black;
            this.GbImmagineProdotto.Location = new System.Drawing.Point(3, 329);
            this.GbImmagineProdotto.Name = "GbImmagineProdotto";
            this.GbImmagineProdotto.Size = new System.Drawing.Size(697, 92);
            this.GbImmagineProdotto.TabIndex = 30;
            this.GbImmagineProdotto.Text = "IMMAGINE PRODOTTO";
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
            // GbDescrizioneArticolo
            // 
            this.GbDescrizioneArticolo.Controls.Add(this.TxtDescrizione);
            this.GbDescrizioneArticolo.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbDescrizioneArticolo.Enabled = false;
            this.GbDescrizioneArticolo.FillColor = System.Drawing.Color.DimGray;
            this.GbDescrizioneArticolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbDescrizioneArticolo.ForeColor = System.Drawing.Color.Black;
            this.GbDescrizioneArticolo.Location = new System.Drawing.Point(3, 223);
            this.GbDescrizioneArticolo.Name = "GbDescrizioneArticolo";
            this.GbDescrizioneArticolo.Size = new System.Drawing.Size(697, 92);
            this.GbDescrizioneArticolo.TabIndex = 28;
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
            // CmbArticoli
            // 
            this.CmbArticoli.BackColor = System.Drawing.Color.Transparent;
            this.CmbArticoli.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbArticoli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbArticoli.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbArticoli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CmbArticoli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbArticoli.ForeColor = System.Drawing.Color.Black;
            this.CmbArticoli.ItemHeight = 30;
            this.CmbArticoli.Location = new System.Drawing.Point(3, 46);
            this.CmbArticoli.Name = "CmbArticoli";
            this.CmbArticoli.Size = new System.Drawing.Size(689, 36);
            this.CmbArticoli.TabIndex = 12;
            // 
            // GbListaArticoli
            // 
            this.GbListaArticoli.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbListaArticoli.Controls.Add(this.CmbArticoli);
            this.GbListaArticoli.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbListaArticoli.FillColor = System.Drawing.Color.DimGray;
            this.GbListaArticoli.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbListaArticoli.ForeColor = System.Drawing.Color.Black;
            this.GbListaArticoli.Location = new System.Drawing.Point(3, 5);
            this.GbListaArticoli.Name = "GbListaArticoli";
            this.GbListaArticoli.Size = new System.Drawing.Size(697, 92);
            this.GbListaArticoli.TabIndex = 26;
            this.GbListaArticoli.Text = "SELEZIONA L\'ARTICOLO*";
            // 
            // BtnModifica
            // 
            this.BtnModifica.BackColor = System.Drawing.Color.Transparent;
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
            this.BtnModifica.Location = new System.Drawing.Point(3, 607);
            this.BtnModifica.Name = "BtnModifica";
            this.BtnModifica.Size = new System.Drawing.Size(697, 45);
            this.BtnModifica.TabIndex = 18;
            this.BtnModifica.Text = "MODIFICA ARTICOLO";
            this.BtnModifica.Click += new System.EventHandler(this.BtnModifica_Click);
            // 
            // GbRifornisciMagazzino
            // 
            this.GbRifornisciMagazzino.Controls.Add(this.BtnRifornisci);
            this.GbRifornisciMagazzino.Controls.Add(this.NudQuantitaR);
            this.GbRifornisciMagazzino.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbRifornisciMagazzino.FillColor = System.Drawing.Color.DimGray;
            this.GbRifornisciMagazzino.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbRifornisciMagazzino.ForeColor = System.Drawing.Color.Black;
            this.GbRifornisciMagazzino.Location = new System.Drawing.Point(386, 52);
            this.GbRifornisciMagazzino.Name = "GbRifornisciMagazzino";
            this.GbRifornisciMagazzino.Size = new System.Drawing.Size(304, 93);
            this.GbRifornisciMagazzino.TabIndex = 19;
            this.GbRifornisciMagazzino.Text = "RIFORNISCI QUANTITA\' ARTICOLI";
            // 
            // BtnRifornisci
            // 
            this.BtnRifornisci.BorderRadius = 4;
            this.BtnRifornisci.BorderThickness = 1;
            this.BtnRifornisci.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnRifornisci.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnRifornisci.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRifornisci.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnRifornisci.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnRifornisci.FillColor = System.Drawing.Color.DimGray;
            this.BtnRifornisci.FillColor2 = System.Drawing.Color.Silver;
            this.BtnRifornisci.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRifornisci.ForeColor = System.Drawing.Color.Black;
            this.BtnRifornisci.Location = new System.Drawing.Point(128, 54);
            this.BtnRifornisci.Name = "BtnRifornisci";
            this.BtnRifornisci.Size = new System.Drawing.Size(173, 32);
            this.BtnRifornisci.TabIndex = 11;
            this.BtnRifornisci.Text = "RIFORNISCI";
            this.BtnRifornisci.Click += new System.EventHandler(this.BtnRifornisci_Click);
            // 
            // NudQuantitaR
            // 
            this.NudQuantitaR.Location = new System.Drawing.Point(3, 56);
            this.NudQuantitaR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudQuantitaR.Name = "NudQuantitaR";
            this.NudQuantitaR.Size = new System.Drawing.Size(119, 29);
            this.NudQuantitaR.TabIndex = 1;
            this.NudQuantitaR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudQuantitaR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmModificaArticolo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.BtnModifica);
            this.Controls.Add(this.GbInformazioniArticolo);
            this.Controls.Add(this.GbImmagineProdotto);
            this.Controls.Add(this.GbDescrizioneArticolo);
            this.Controls.Add(this.GbFornitore);
            this.Controls.Add(this.GbListaArticoli);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "FrmModificaArticolo";
            this.Size = new System.Drawing.Size(703, 655);
            this.GbFornitore.ResumeLayout(false);
            this.GbInformazioniArticolo.ResumeLayout(false);
            this.GbIva.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudIva)).EndInit();
            this.GbPrezzo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudPrezzo)).EndInit();
            this.GbImmagineProdotto.ResumeLayout(false);
            this.GbDescrizioneArticolo.ResumeLayout(false);
            this.GbListaArticoli.ResumeLayout(false);
            this.GbRifornisciMagazzino.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantitaR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox GbFornitore;
        private Guna.UI2.WinForms.Guna2ComboBox CmbFornitori;
        private Guna.UI2.WinForms.Guna2GroupBox GbInformazioniArticolo;
        private Guna.UI2.WinForms.Guna2GroupBox GbIva;
        private System.Windows.Forms.NumericUpDown NudIva;
        private Guna.UI2.WinForms.Guna2GroupBox GbPrezzo;
        private System.Windows.Forms.NumericUpDown NudPrezzo;
        private Guna.UI2.WinForms.Guna2GroupBox GbImmagineProdotto;
        private System.Windows.Forms.Button BtnPath;
        private Guna.UI2.WinForms.Guna2TextBox TxtPath;
        private Guna.UI2.WinForms.Guna2GroupBox GbDescrizioneArticolo;
        private Guna.UI2.WinForms.Guna2TextBox TxtDescrizione;
        private Guna.UI2.WinForms.Guna2TextBox TxtCategoria;
        private Guna.UI2.WinForms.Guna2ComboBox CmbArticoli;
        private Guna.UI2.WinForms.Guna2GroupBox GbListaArticoli;
        private Guna.UI2.WinForms.Guna2GradientButton BtnModifica;
        private Guna.UI2.WinForms.Guna2GroupBox GbRifornisciMagazzino;
        private Guna.UI2.WinForms.Guna2GradientButton BtnRifornisci;
        private System.Windows.Forms.NumericUpDown NudQuantitaR;
    }
}
