namespace Negozio.View.UC
{
    partial class FrmArticoli
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
            this.PanelProdotti = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // PanelProdotti
            // 
            this.PanelProdotti.AutoScroll = true;
            this.PanelProdotti.BackColor = System.Drawing.Color.Black;
            this.PanelProdotti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelProdotti.Location = new System.Drawing.Point(0, 0);
            this.PanelProdotti.Name = "PanelProdotti";
            this.PanelProdotti.Padding = new System.Windows.Forms.Padding(10);
            this.PanelProdotti.Size = new System.Drawing.Size(1351, 803);
            this.PanelProdotti.TabIndex = 0;
            // 
            // FrmArticoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.PanelProdotti);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "FrmArticoli";
            this.Size = new System.Drawing.Size(1351, 803);
            this.Load += new System.EventHandler(this.FrmArticoli_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelProdotti;
    }
}
