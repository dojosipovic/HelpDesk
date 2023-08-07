namespace HelpDesk
{
    partial class FrmTakenTicketDetails
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
            this.tbVrijemePreuzimanja = new System.Windows.Forms.TextBox();
            this.lblVrijemePreuzimanja = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.tbKomentar = new System.Windows.Forms.TextBox();
            this.tbOpis = new System.Windows.Forms.TextBox();
            this.tbVrijemeKreiranja = new System.Windows.Forms.TextBox();
            this.tbZahtjevBroj = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrioritet = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.lblOpis = new System.Windows.Forms.Label();
            this.lblVrijemeKreiranja = new System.Windows.Forms.Label();
            this.lblZahtjevBroj = new System.Windows.Forms.Label();
            this.lblDetaljiZahtjeva = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cbPrioritet = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tbVrijemePreuzimanja
            // 
            this.tbVrijemePreuzimanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVrijemePreuzimanja.Location = new System.Drawing.Point(276, 288);
            this.tbVrijemePreuzimanja.Name = "tbVrijemePreuzimanja";
            this.tbVrijemePreuzimanja.ReadOnly = true;
            this.tbVrijemePreuzimanja.Size = new System.Drawing.Size(169, 26);
            this.tbVrijemePreuzimanja.TabIndex = 35;
            // 
            // lblVrijemePreuzimanja
            // 
            this.lblVrijemePreuzimanja.AutoSize = true;
            this.lblVrijemePreuzimanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijemePreuzimanja.Location = new System.Drawing.Point(122, 291);
            this.lblVrijemePreuzimanja.Name = "lblVrijemePreuzimanja";
            this.lblVrijemePreuzimanja.Size = new System.Drawing.Size(152, 20);
            this.lblVrijemePreuzimanja.TabIndex = 34;
            this.lblVrijemePreuzimanja.Text = "Vrijeme preuzimanja";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpremi.Location = new System.Drawing.Point(699, 575);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(137, 42);
            this.btnSpremi.TabIndex = 33;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // tbKomentar
            // 
            this.tbKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKomentar.Location = new System.Drawing.Point(272, 334);
            this.tbKomentar.Multiline = true;
            this.tbKomentar.Name = "tbKomentar";
            this.tbKomentar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbKomentar.Size = new System.Drawing.Size(380, 120);
            this.tbKomentar.TabIndex = 30;
            // 
            // tbOpis
            // 
            this.tbOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOpis.Location = new System.Drawing.Point(276, 152);
            this.tbOpis.Multiline = true;
            this.tbOpis.Name = "tbOpis";
            this.tbOpis.ReadOnly = true;
            this.tbOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOpis.Size = new System.Drawing.Size(380, 120);
            this.tbOpis.TabIndex = 28;
            // 
            // tbVrijemeKreiranja
            // 
            this.tbVrijemeKreiranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVrijemeKreiranja.Location = new System.Drawing.Point(276, 112);
            this.tbVrijemeKreiranja.Name = "tbVrijemeKreiranja";
            this.tbVrijemeKreiranja.ReadOnly = true;
            this.tbVrijemeKreiranja.Size = new System.Drawing.Size(169, 26);
            this.tbVrijemeKreiranja.TabIndex = 27;
            // 
            // tbZahtjevBroj
            // 
            this.tbZahtjevBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbZahtjevBroj.Location = new System.Drawing.Point(276, 62);
            this.tbZahtjevBroj.Name = "tbZahtjevBroj";
            this.tbZahtjevBroj.ReadOnly = true;
            this.tbZahtjevBroj.Size = new System.Drawing.Size(100, 26);
            this.tbZahtjevBroj.TabIndex = 26;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(210, 509);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Status";
            // 
            // lblPrioritet
            // 
            this.lblPrioritet.AutoSize = true;
            this.lblPrioritet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrioritet.Location = new System.Drawing.Point(203, 473);
            this.lblPrioritet.Name = "lblPrioritet";
            this.lblPrioritet.Size = new System.Drawing.Size(63, 20);
            this.lblPrioritet.TabIndex = 24;
            this.lblPrioritet.Text = "Prioritet";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKomentar.Location = new System.Drawing.Point(188, 334);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(78, 20);
            this.lblKomentar.TabIndex = 23;
            this.lblKomentar.Text = "Komentar";
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpis.Location = new System.Drawing.Point(229, 152);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(41, 20);
            this.lblOpis.TabIndex = 21;
            this.lblOpis.Text = "Opis";
            // 
            // lblVrijemeKreiranja
            // 
            this.lblVrijemeKreiranja.AutoSize = true;
            this.lblVrijemeKreiranja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVrijemeKreiranja.Location = new System.Drawing.Point(144, 112);
            this.lblVrijemeKreiranja.Name = "lblVrijemeKreiranja";
            this.lblVrijemeKreiranja.Size = new System.Drawing.Size(126, 20);
            this.lblVrijemeKreiranja.TabIndex = 20;
            this.lblVrijemeKreiranja.Text = "Vrijeme kreiranja";
            // 
            // lblZahtjevBroj
            // 
            this.lblZahtjevBroj.AutoSize = true;
            this.lblZahtjevBroj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZahtjevBroj.Location = new System.Drawing.Point(179, 62);
            this.lblZahtjevBroj.Name = "lblZahtjevBroj";
            this.lblZahtjevBroj.Size = new System.Drawing.Size(91, 20);
            this.lblZahtjevBroj.TabIndex = 19;
            this.lblZahtjevBroj.Text = "Zahtjev broj";
            // 
            // lblDetaljiZahtjeva
            // 
            this.lblDetaljiZahtjeva.AutoSize = true;
            this.lblDetaljiZahtjeva.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetaljiZahtjeva.Location = new System.Drawing.Point(100, 9);
            this.lblDetaljiZahtjeva.Name = "lblDetaljiZahtjeva";
            this.lblDetaljiZahtjeva.Size = new System.Drawing.Size(174, 29);
            this.lblDetaljiZahtjeva.TabIndex = 18;
            this.lblDetaljiZahtjeva.Text = "Detalji zahtjeva";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(515, 575);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(137, 42);
            this.btnOdustani.TabIndex = 36;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cbPrioritet
            // 
            this.cbPrioritet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrioritet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrioritet.FormattingEnabled = true;
            this.cbPrioritet.Location = new System.Drawing.Point(272, 470);
            this.cbPrioritet.Name = "cbPrioritet";
            this.cbPrioritet.Size = new System.Drawing.Size(121, 28);
            this.cbPrioritet.TabIndex = 37;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(272, 504);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 28);
            this.cbStatus.TabIndex = 38;
            // 
            // FrmTakenTicketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 629);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbPrioritet);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.tbVrijemePreuzimanja);
            this.Controls.Add(this.lblVrijemePreuzimanja);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.tbKomentar);
            this.Controls.Add(this.tbOpis);
            this.Controls.Add(this.tbVrijemeKreiranja);
            this.Controls.Add(this.tbZahtjevBroj);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPrioritet);
            this.Controls.Add(this.lblKomentar);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.lblVrijemeKreiranja);
            this.Controls.Add(this.lblZahtjevBroj);
            this.Controls.Add(this.lblDetaljiZahtjeva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTakenTicketDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preuzet zahtjev";
            this.Load += new System.EventHandler(this.FrmTakenTicketDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbVrijemePreuzimanja;
        private System.Windows.Forms.Label lblVrijemePreuzimanja;
        private System.Windows.Forms.Button btnSpremi;
        private System.Windows.Forms.TextBox tbKomentar;
        private System.Windows.Forms.TextBox tbOpis;
        private System.Windows.Forms.TextBox tbVrijemeKreiranja;
        private System.Windows.Forms.TextBox tbZahtjevBroj;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrioritet;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Label lblVrijemeKreiranja;
        private System.Windows.Forms.Label lblZahtjevBroj;
        private System.Windows.Forms.Label lblDetaljiZahtjeva;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cbPrioritet;
        private System.Windows.Forms.ComboBox cbStatus;
    }
}