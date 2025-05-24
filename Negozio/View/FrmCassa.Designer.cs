namespace Negozio.View
{
    partial class FrmCassa
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
            this.PanBar = new System.Windows.Forms.Panel();
            this.BtnNuovoCliente = new Guna.UI2.WinForms.Guna2Button();
            this.BtnReturn = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPagamento = new Guna.UI2.WinForms.Guna2Button();
            this.PanBody = new System.Windows.Forms.Panel();
            this.PanCarrello = new System.Windows.Forms.Panel();
            this.PanCliente = new System.Windows.Forms.Panel();
            this.PanBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanBar
            // 
            this.PanBar.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanBar.Controls.Add(this.BtnNuovoCliente);
            this.PanBar.Controls.Add(this.BtnReturn);
            this.PanBar.Controls.Add(this.BtnPagamento);
            this.PanBar.Location = new System.Drawing.Point(312, 12);
            this.PanBar.Name = "PanBar";
            this.PanBar.Size = new System.Drawing.Size(1495, 100);
            this.PanBar.TabIndex = 5;
            // 
            // BtnNuovoCliente
            // 
            this.BtnNuovoCliente.BorderColor = System.Drawing.Color.White;
            this.BtnNuovoCliente.BorderRadius = 6;
            this.BtnNuovoCliente.BorderThickness = 2;
            this.BtnNuovoCliente.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNuovoCliente.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNuovoCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNuovoCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNuovoCliente.FillColor = System.Drawing.Color.DimGray;
            this.BtnNuovoCliente.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuovoCliente.ForeColor = System.Drawing.Color.White;
            this.BtnNuovoCliente.Location = new System.Drawing.Point(641, 24);
            this.BtnNuovoCliente.Name = "BtnNuovoCliente";
            this.BtnNuovoCliente.Size = new System.Drawing.Size(200, 51);
            this.BtnNuovoCliente.TabIndex = 2;
            this.BtnNuovoCliente.Text = "NUOVO CLIENTE";
            this.BtnNuovoCliente.Click += new System.EventHandler(this.BtnNuovoCliente_Click);
            // 
            // BtnReturn
            // 
            this.BtnReturn.BorderColor = System.Drawing.Color.White;
            this.BtnReturn.BorderRadius = 6;
            this.BtnReturn.BorderThickness = 2;
            this.BtnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnReturn.FillColor = System.Drawing.Color.DarkRed;
            this.BtnReturn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReturn.ForeColor = System.Drawing.Color.White;
            this.BtnReturn.Location = new System.Drawing.Point(80, 24);
            this.BtnReturn.Name = "BtnReturn";
            this.BtnReturn.Size = new System.Drawing.Size(200, 51);
            this.BtnReturn.TabIndex = 1;
            this.BtnReturn.Text = "INDIETRO";
            this.BtnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // BtnPagamento
            // 
            this.BtnPagamento.BorderColor = System.Drawing.Color.DimGray;
            this.BtnPagamento.BorderRadius = 6;
            this.BtnPagamento.BorderThickness = 2;
            this.BtnPagamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPagamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPagamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPagamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPagamento.FillColor = System.Drawing.Color.Silver;
            this.BtnPagamento.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagamento.ForeColor = System.Drawing.Color.Black;
            this.BtnPagamento.Location = new System.Drawing.Point(360, 24);
            this.BtnPagamento.Name = "BtnPagamento";
            this.BtnPagamento.Size = new System.Drawing.Size(200, 51);
            this.BtnPagamento.TabIndex = 0;
            this.BtnPagamento.Text = "PAGAMENTO";
            this.BtnPagamento.Click += new System.EventHandler(this.BtnPagamento_Click);
            // 
            // PanBody
            // 
            this.PanBody.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanBody.Location = new System.Drawing.Point(312, 115);
            this.PanBody.Name = "PanBody";
            this.PanBody.Size = new System.Drawing.Size(1495, 803);
            this.PanBody.TabIndex = 6;
            // 
            // PanCarrello
            // 
            this.PanCarrello.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanCarrello.ForeColor = System.Drawing.SystemColors.Control;
            this.PanCarrello.Location = new System.Drawing.Point(12, 160);
            this.PanCarrello.Name = "PanCarrello";
            this.PanCarrello.Size = new System.Drawing.Size(294, 758);
            this.PanCarrello.TabIndex = 7;
            // 
            // PanCliente
            // 
            this.PanCliente.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanCliente.ForeColor = System.Drawing.SystemColors.Control;
            this.PanCliente.Location = new System.Drawing.Point(12, 12);
            this.PanCliente.Name = "PanCliente";
            this.PanCliente.Size = new System.Drawing.Size(294, 142);
            this.PanCliente.TabIndex = 8;
            // 
            // FrmCassa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1821, 931);
            this.Controls.Add(this.PanCliente);
            this.Controls.Add(this.PanCarrello);
            this.Controls.Add(this.PanBody);
            this.Controls.Add(this.PanBar);
            this.Name = "FrmCassa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCassa";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCassa_KeyDown);
            this.PanBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanBar;
        private System.Windows.Forms.Panel PanBody;
        private System.Windows.Forms.Panel PanCarrello;
        private System.Windows.Forms.Panel PanCliente;
        private Guna.UI2.WinForms.Guna2Button BtnPagamento;
        private Guna.UI2.WinForms.Guna2Button BtnReturn;
        private Guna.UI2.WinForms.Guna2Button BtnNuovoCliente;
    }
}