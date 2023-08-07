namespace HelpDesk
{
    partial class FrmUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNoviZahtjev = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.dgvAktivniZahtjevi = new System.Windows.Forms.DataGridView();
            this.btnPrethodniZahtjevi = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivniZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOsvjezi);
            this.groupBox1.Controls.Add(this.btnNoviZahtjev);
            this.groupBox1.Controls.Add(this.btnDetalji);
            this.groupBox1.Controls.Add(this.dgvAktivniZahtjevi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktivni zahtjevi";
            // 
            // btnNoviZahtjev
            // 
            this.btnNoviZahtjev.Location = new System.Drawing.Point(7, 377);
            this.btnNoviZahtjev.Name = "btnNoviZahtjev";
            this.btnNoviZahtjev.Size = new System.Drawing.Size(129, 39);
            this.btnNoviZahtjev.TabIndex = 2;
            this.btnNoviZahtjev.Text = "Novi zahtjev";
            this.btnNoviZahtjev.UseVisualStyleBackColor = true;
            this.btnNoviZahtjev.Click += new System.EventHandler(this.btnNoviZahtjev_Click);
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(646, 377);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(132, 39);
            this.btnDetalji.TabIndex = 1;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // dgvAktivniZahtjevi
            // 
            this.dgvAktivniZahtjevi.AllowUserToAddRows = false;
            this.dgvAktivniZahtjevi.AllowUserToDeleteRows = false;
            this.dgvAktivniZahtjevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAktivniZahtjevi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAktivniZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAktivniZahtjevi.Location = new System.Drawing.Point(6, 28);
            this.dgvAktivniZahtjevi.Name = "dgvAktivniZahtjevi";
            this.dgvAktivniZahtjevi.ReadOnly = true;
            this.dgvAktivniZahtjevi.Size = new System.Drawing.Size(772, 343);
            this.dgvAktivniZahtjevi.TabIndex = 0;
            // 
            // btnPrethodniZahtjevi
            // 
            this.btnPrethodniZahtjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrethodniZahtjevi.Location = new System.Drawing.Point(12, 440);
            this.btnPrethodniZahtjevi.Name = "btnPrethodniZahtjevi";
            this.btnPrethodniZahtjevi.Size = new System.Drawing.Size(149, 44);
            this.btnPrethodniZahtjevi.TabIndex = 1;
            this.btnPrethodniZahtjevi.Text = "Prethodni zahtjevi";
            this.btnPrethodniZahtjevi.UseVisualStyleBackColor = true;
            this.btnPrethodniZahtjevi.Click += new System.EventHandler(this.btnPrethodniZahtjevi_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(142, 377);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(123, 38);
            this.btnOsvjezi.TabIndex = 3;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 490);
            this.Controls.Add(this.btnPrethodniZahtjevi);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Korisnik";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAktivniZahtjevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.DataGridView dgvAktivniZahtjevi;
        private System.Windows.Forms.Button btnPrethodniZahtjevi;
        private System.Windows.Forms.Button btnNoviZahtjev;
        private System.Windows.Forms.Button btnOsvjezi;
    }
}