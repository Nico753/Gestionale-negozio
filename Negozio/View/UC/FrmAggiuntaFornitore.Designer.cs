namespace Negozio.View.UC
{
    partial class FrmAggiuntaFornitore
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
            this.GbNome = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtAzienda = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbCategoria = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtCategoria = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbEmail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbContattoTelefonico = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtTelefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.GbIndirizzo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.TxtIndirizzo = new Guna.UI2.WinForms.Guna2TextBox();
            this.BtnAggiungiFornitore = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GbNome.SuspendLayout();
            this.GbCategoria.SuspendLayout();
            this.GbEmail.SuspendLayout();
            this.GbContattoTelefonico.SuspendLayout();
            this.GbIndirizzo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GbNome
            // 
            this.GbNome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbNome.Controls.Add(this.TxtAzienda);
            this.GbNome.CustomBorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbNome.FillColor = System.Drawing.Color.DimGray;
            this.GbNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbNome.ForeColor = System.Drawing.Color.Black;
            this.GbNome.Location = new System.Drawing.Point(3, 3);
            this.GbNome.Name = "GbNome";
            this.GbNome.Size = new System.Drawing.Size(697, 92);
            this.GbNome.TabIndex = 8;
            this.GbNome.Text = "NOME AZIENDA *";
            // 
            // TxtAzienda
            // 
            this.TxtAzienda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtAzienda.DefaultText = "";
            this.TxtAzienda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtAzienda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtAzienda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAzienda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtAzienda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAzienda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAzienda.ForeColor = System.Drawing.Color.Black;
            this.TxtAzienda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtAzienda.Location = new System.Drawing.Point(3, 48);
            this.TxtAzienda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtAzienda.Name = "TxtAzienda";
            this.TxtAzienda.PlaceholderText = "";
            this.TxtAzienda.SelectedText = "";
            this.TxtAzienda.Size = new System.Drawing.Size(689, 34);
            this.TxtAzienda.TabIndex = 0;
            this.TxtAzienda.TextChanged += new System.EventHandler(this.TxtAzienda_TextChanged);
            // 
            // GbCategoria
            // 
            this.GbCategoria.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GbCategoria.Controls.Add(this.TxtCategoria);
            this.GbCategoria.CustomBorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.GbCategoria.FillColor = System.Drawing.Color.DimGray;
            this.GbCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbCategoria.ForeColor = System.Drawing.Color.Black;
            this.GbCategoria.Location = new System.Drawing.Point(3, 119);
            this.GbCategoria.Name = "GbCategoria";
            this.GbCategoria.Size = new System.Drawing.Size(697, 92);
            this.GbCategoria.TabIndex = 9;
            this.GbCategoria.Text = "CATEGORIA *";
            // 
            // TxtCategoria
            // 
            this.TxtCategoria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCategoria.DefaultText = "";
            this.TxtCategoria.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCategoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCategoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCategoria.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCategoria.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCategoria.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCategoria.ForeColor = System.Drawing.Color.Black;
            this.TxtCategoria.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCategoria.Location = new System.Drawing.Point(3, 48);
            this.TxtCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCategoria.Name = "TxtCategoria";
            this.TxtCategoria.PlaceholderText = "";
            this.TxtCategoria.SelectedText = "";
            this.TxtCategoria.Size = new System.Drawing.Size(689, 34);
            this.TxtCategoria.TabIndex = 0;
            this.TxtCategoria.TextChanged += new System.EventHandler(this.TxtCategoria_TextChanged);
            // 
            // GbEmail
            // 
            this.GbEmail.Controls.Add(this.TxtEmail);
            this.GbEmail.CustomBorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.GbEmail.FillColor = System.Drawing.Color.DimGray;
            this.GbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbEmail.ForeColor = System.Drawing.Color.Black;
            this.GbEmail.Location = new System.Drawing.Point(3, 233);
            this.GbEmail.Name = "GbEmail";
            this.GbEmail.Size = new System.Drawing.Size(697, 92);
            this.GbEmail.TabIndex = 3;
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
            this.TxtEmail.Location = new System.Drawing.Point(2, 47);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.PlaceholderText = "";
            this.TxtEmail.SelectedText = "";
            this.TxtEmail.Size = new System.Drawing.Size(689, 34);
            this.TxtEmail.TabIndex = 2;
            this.TxtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // GbContattoTelefonico
            // 
            this.GbContattoTelefonico.Controls.Add(this.TxtTelefono);
            this.GbContattoTelefonico.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.GbContattoTelefonico.FillColor = System.Drawing.Color.DimGray;
            this.GbContattoTelefonico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbContattoTelefonico.ForeColor = System.Drawing.Color.Black;
            this.GbContattoTelefonico.Location = new System.Drawing.Point(3, 349);
            this.GbContattoTelefonico.Name = "GbContattoTelefonico";
            this.GbContattoTelefonico.Size = new System.Drawing.Size(697, 92);
            this.GbContattoTelefonico.TabIndex = 4;
            this.GbContattoTelefonico.Text = "CONTATTO TELEFONICO";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtTelefono.DefaultText = "";
            this.TxtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.ForeColor = System.Drawing.Color.Black;
            this.TxtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtTelefono.Location = new System.Drawing.Point(2, 47);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtTelefono.MaxLength = 10;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.PlaceholderText = "";
            this.TxtTelefono.SelectedText = "";
            this.TxtTelefono.Size = new System.Drawing.Size(689, 34);
            this.TxtTelefono.TabIndex = 2;
            this.TxtTelefono.TextChanged += new System.EventHandler(this.TxtTelefono_TextChanged);
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTelefono_KeyPress);
            // 
            // GbIndirizzo
            // 
            this.GbIndirizzo.Controls.Add(this.TxtIndirizzo);
            this.GbIndirizzo.CustomBorderColor = System.Drawing.Color.LightSlateGray;
            this.GbIndirizzo.FillColor = System.Drawing.Color.DimGray;
            this.GbIndirizzo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbIndirizzo.ForeColor = System.Drawing.Color.Black;
            this.GbIndirizzo.Location = new System.Drawing.Point(3, 468);
            this.GbIndirizzo.Name = "GbIndirizzo";
            this.GbIndirizzo.Size = new System.Drawing.Size(697, 92);
            this.GbIndirizzo.TabIndex = 5;
            this.GbIndirizzo.Text = "INDIRIZZO";
            // 
            // TxtIndirizzo
            // 
            this.TxtIndirizzo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtIndirizzo.DefaultText = "";
            this.TxtIndirizzo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtIndirizzo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtIndirizzo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtIndirizzo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtIndirizzo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtIndirizzo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIndirizzo.ForeColor = System.Drawing.Color.Black;
            this.TxtIndirizzo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtIndirizzo.Location = new System.Drawing.Point(2, 47);
            this.TxtIndirizzo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtIndirizzo.Name = "TxtIndirizzo";
            this.TxtIndirizzo.PlaceholderText = "";
            this.TxtIndirizzo.SelectedText = "";
            this.TxtIndirizzo.Size = new System.Drawing.Size(689, 34);
            this.TxtIndirizzo.TabIndex = 2;
            this.TxtIndirizzo.TextChanged += new System.EventHandler(this.TxtIndirizzo_TextChanged);
            // 
            // BtnAggiungiFornitore
            // 
            this.BtnAggiungiFornitore.BorderColor = System.Drawing.Color.White;
            this.BtnAggiungiFornitore.BorderRadius = 10;
            this.BtnAggiungiFornitore.BorderThickness = 2;
            this.BtnAggiungiFornitore.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAggiungiFornitore.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAggiungiFornitore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAggiungiFornitore.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAggiungiFornitore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAggiungiFornitore.FillColor = System.Drawing.Color.Black;
            this.BtnAggiungiFornitore.FillColor2 = System.Drawing.Color.SlateGray;
            this.BtnAggiungiFornitore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAggiungiFornitore.ForeColor = System.Drawing.Color.White;
            this.BtnAggiungiFornitore.Location = new System.Drawing.Point(0, 589);
            this.BtnAggiungiFornitore.Name = "BtnAggiungiFornitore";
            this.BtnAggiungiFornitore.Size = new System.Drawing.Size(703, 56);
            this.BtnAggiungiFornitore.TabIndex = 12;
            this.BtnAggiungiFornitore.Text = "AGGIUNGI FORNITORE";
            this.BtnAggiungiFornitore.Click += new System.EventHandler(this.BtnAggiungiFornitore_Click);
            // 
            // FrmAggiuntaFornitore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.BtnAggiungiFornitore);
            this.Controls.Add(this.GbIndirizzo);
            this.Controls.Add(this.GbContattoTelefonico);
            this.Controls.Add(this.GbEmail);
            this.Controls.Add(this.GbCategoria);
            this.Controls.Add(this.GbNome);
            this.Name = "FrmAggiuntaFornitore";
            this.Size = new System.Drawing.Size(703, 664);
            this.GbNome.ResumeLayout(false);
            this.GbCategoria.ResumeLayout(false);
            this.GbEmail.ResumeLayout(false);
            this.GbContattoTelefonico.ResumeLayout(false);
            this.GbIndirizzo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox GbNome;
        private Guna.UI2.WinForms.Guna2TextBox TxtAzienda;
        private Guna.UI2.WinForms.Guna2GroupBox GbCategoria;
        private Guna.UI2.WinForms.Guna2TextBox TxtCategoria;
        private Guna.UI2.WinForms.Guna2GroupBox GbEmail;
        private Guna.UI2.WinForms.Guna2TextBox TxtEmail;
        private Guna.UI2.WinForms.Guna2GroupBox GbContattoTelefonico;
        private Guna.UI2.WinForms.Guna2TextBox TxtTelefono;
        private Guna.UI2.WinForms.Guna2GroupBox GbIndirizzo;
        private Guna.UI2.WinForms.Guna2TextBox TxtIndirizzo;
        private Guna.UI2.WinForms.Guna2GradientButton BtnAggiungiFornitore;
    }
}
