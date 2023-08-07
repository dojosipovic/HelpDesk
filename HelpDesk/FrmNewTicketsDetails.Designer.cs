namespace HelpDesk
{
    partial class FrmNewTicketsDetails
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
            this.btnNatrag = new System.Windows.Forms.Button();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.tbVrijemeKreiranja = new System.Windows.Forms.TextBox();
            this.tbZahtjevBroj = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblVrijemeKreiranja = new System.Windows.Forms.Label();
            this.lblZahtjevBroj = new System.Windows.Forms.Label();
            this.lblDetaljiZahtjeva = new System.Windows.Forms.Label();
            this.lblZahtjevPodnio = new System.Windows.Forms.Label();
            this.tbZahtjevPodnio = new System.Windows.Forms.TextBox();
            this.btnPreuzmi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNatrag
            // 
            this.btnNatrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNatrag.Location = new System.Drawing.Point(413, 396);
            this.btnNatrag.Name = "btnNatrag";
            this.btnNatrag.Size = new System.Drawing.Size(137, 42);
            this.btnNatrag.TabIndex = 31;
            this.btnNatrag.Text = "Natrag";
            this.btnNatrag.UseVisualStyleBackColor = true;
            this.btnNatrag.Click += new System.EventHandler(this.btnNatrag_Click);
            // 
            // tbOpis
            // 
            this.tbOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOpis.Location = new System.Drawing.Point(291, 180);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.ReadOnly = true;
            this.tbOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOpis.Size = new System.Drawing.Size(380, 120);
            this.tbOpis.TabIndex = 26;
            // 
            // tbVrijemeKreiranja
            // 
            this.tbVrijemeKreiranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVrijemeKreiranja.Location = new System.Drawing.Point(291, 140);
            this.tbVrijemeKreiranja.Name = "tbVrijemeKreiranja";
            this.tbVrijemeKreiranja.ReadOnly = true;
            this.tbVrijemeKreiranja.Size = new System.Drawing.Size(169, 26);
            this.tbVrijemeKreiranja.TabIndex = 25;
            // 
            // tbZahtjevBroj
            // 
            this.tbZahtjevBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZahtjevBroj.Location = new System.Drawing.Point(291, 63);
            this.tbZahtjevBroj.Name = "tbZahtjevBroj";
            this.tbZahtjevBroj.ReadOnly = true;
            this.tbZahtjevBroj.Size = new System.Drawing.Size(100, 26);
            this.tbZahtjevBroj.TabIndex = 24;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(244, 180);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(41, 20);
            this.lblOpis.TabIndex = 19;
            this.lblOpis.Text = "Opis";
            // 
            // lblVrijemeKreiranja
            // 
            this.lblVrijemeKreiranja.AutoSize = true;
            this.lblVrijemeKreiranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijemeKreiranja.Location = new System.Drawing.Point(159, 140);
            this.lblVrijemeKreiranja.Name = "lblVrijemeKreiranja";
            this.lblVrijemeKreiranja.Size = new System.Drawing.Size(126, 20);
            this.lblVrijemeKreiranja.TabIndex = 18;
            this.lblVrijemeKreiranja.Text = "Vrijeme kreiranja";
            // 
            // lblZahtjevBroj
            // 
            this.lblZahtjevBroj.AutoSize = true;
            this.lblZahtjevBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZahtjevBroj.Location = new System.Drawing.Point(194, 63);
            this.lblZahtjevBroj.Name = "lblZahtjevBroj";
            this.lblZahtjevBroj.Size = new System.Drawing.Size(91, 20);
            this.lblZahtjevBroj.TabIndex = 17;
            this.lblZahtjevBroj.Text = "Zahtjev broj";
            // 
            // lblDetaljiZahtjeva
            // 
            this.lblDetaljiZahtjeva.AutoSize = true;
            this.lblDetaljiZahtjeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetaljiZahtjeva.Location = new System.Drawing.Point(115, 10);
            this.lblDetaljiZahtjeva.Name = "lblDetaljiZahtjeva";
            this.lblDetaljiZahtjeva.Size = new System.Drawing.Size(174, 29);
            this.lblDetaljiZahtjeva.TabIndex = 16;
            this.lblDetaljiZahtjeva.Text = "Detalji zahtjeva";
            // 
            // lblZahtjevPodnio
            // 
            this.lblZahtjevPodnio.AutoSize = true;
            this.lblZahtjevPodnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZahtjevPodnio.Location = new System.Drawing.Point(163, 103);
            this.lblZahtjevPodnio.Name = "lblZahtjevPodnio";
            this.lblZahtjevPodnio.Size = new System.Drawing.Size(113, 20);
            this.lblZahtjevPodnio.TabIndex = 32;
            this.lblZahtjevPodnio.Text = "Zahtjev podnio";
            // 
            // tbZahtjevPodnio
            // 
            this.tbZahtjevPodnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZahtjevPodnio.Location = new System.Drawing.Point(295, 103);
            this.tbZahtjevPodnio.Name = "tbZahtjevPodnio";
            this.tbZahtjevPodnio.ReadOnly = true;
            this.tbZahtjevPodnio.Size = new System.Drawing.Size(184, 26);
            this.tbZahtjevPodnio.TabIndex = 33;
            // 
            // btnPreuzmi
            // 
            this.btnPreuzmi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreuzmi.Location = new System.Drawing.Point(596, 396);
            this.btnPreuzmi.Name = "btnPreuzmi";
            this.btnPreuzmi.Size = new System.Drawing.Size(137, 42);
            this.btnPreuzmi.TabIndex = 34;
            this.btnPreuzmi.Text = "Preuzmi";
            this.btnPreuzmi.UseVisualStyleBackColor = true;
            this.btnPreuzmi.Click += new System.EventHandler(this.btnPreuzmi_Click);
            // 
            // FrmNewTicketsDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPreuzmi);
            this.Controls.Add(this.tbZahtjevPodnio);
            this.Controls.Add(this.lblZahtjevPodnio);
            this.Controls.Add(this.btnNatrag);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.tbVrijemeKreiranja);
            this.Controls.Add(this.tbZahtjevBroj);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblVrijemeKreiranja);
            this.Controls.Add(this.lblZahtjevBroj);
            this.Controls.Add(this.lblDetaljiZahtjeva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmNewTicketsDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi zahtjev";
            this.Load += new System.EventHandler(this.FrmNewTicketsDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNatrag;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.TextBox tbVrijemeKreiranja;
        private System.Windows.Forms.TextBox tbZahtjevBroj;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblVrijemeKreiranja;
        private System.Windows.Forms.Label lblZahtjevBroj;
        private System.Windows.Forms.Label lblDetaljiZahtjeva;
        private System.Windows.Forms.Label lblZahtjevPodnio;
        private System.Windows.Forms.TextBox tbZahtjevPodnio;
        private System.Windows.Forms.Button btnPreuzmi;
    }
}