namespace HelpDesk
{
    partial class FrmEmployee
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
            this.dgvPreuzetiZahtjevi = new System.Windows.Forms.DataGridView();
            this.dgvNoviZahtjevi = new System.Windows.Forms.DataGridView();
            this.btnDetaljiPreuzeti = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDetaljiNovi = new System.Windows.Forms.Button();
            this.btnZavrseniZahtjevi = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.tbPretrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreuzetiZahtjevi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoviZahtjevi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPreuzetiZahtjevi
            // 
            this.dgvPreuzetiZahtjevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPreuzetiZahtjevi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPreuzetiZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPreuzetiZahtjevi.Location = new System.Drawing.Point(6, 28);
            this.dgvPreuzetiZahtjevi.Name = "dgvPreuzetiZahtjevi";
            this.dgvPreuzetiZahtjevi.ReadOnly = true;
            this.dgvPreuzetiZahtjevi.Size = new System.Drawing.Size(905, 297);
            this.dgvPreuzetiZahtjevi.TabIndex = 0;
            // 
            // dgvNoviZahtjevi
            // 
            this.dgvNoviZahtjevi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNoviZahtjevi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNoviZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNoviZahtjevi.Location = new System.Drawing.Point(6, 28);
            this.dgvNoviZahtjevi.Name = "dgvNoviZahtjevi";
            this.dgvNoviZahtjevi.ReadOnly = true;
            this.dgvNoviZahtjevi.Size = new System.Drawing.Size(905, 297);
            this.dgvNoviZahtjevi.TabIndex = 3;
            // 
            // btnDetaljiPreuzeti
            // 
            this.btnDetaljiPreuzeti.Location = new System.Drawing.Point(962, 131);
            this.btnDetaljiPreuzeti.Name = "btnDetaljiPreuzeti";
            this.btnDetaljiPreuzeti.Size = new System.Drawing.Size(119, 47);
            this.btnDetaljiPreuzeti.TabIndex = 4;
            this.btnDetaljiPreuzeti.Text = "Detalji";
            this.btnDetaljiPreuzeti.UseVisualStyleBackColor = true;
            this.btnDetaljiPreuzeti.Click += new System.EventHandler(this.btnDetaljiPreuzeti_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(987, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPreuzetiZahtjevi);
            this.groupBox1.Controls.Add(this.btnDetaljiPreuzeti);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1130, 331);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preuzeti zahtjevi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbPretrazi);
            this.groupBox2.Controls.Add(this.btnDetaljiNovi);
            this.groupBox2.Controls.Add(this.dgvNoviZahtjevi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1130, 331);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Novi zahtjevi";
            // 
            // btnDetaljiNovi
            // 
            this.btnDetaljiNovi.Location = new System.Drawing.Point(962, 160);
            this.btnDetaljiNovi.Name = "btnDetaljiNovi";
            this.btnDetaljiNovi.Size = new System.Drawing.Size(119, 47);
            this.btnDetaljiNovi.TabIndex = 4;
            this.btnDetaljiNovi.Text = "Detalji";
            this.btnDetaljiNovi.UseVisualStyleBackColor = true;
            this.btnDetaljiNovi.Click += new System.EventHandler(this.btnDetaljiNovi_Click);
            // 
            // btnZavrseniZahtjevi
            // 
            this.btnZavrseniZahtjevi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZavrseniZahtjevi.Location = new System.Drawing.Point(12, 686);
            this.btnZavrseniZahtjevi.Name = "btnZavrseniZahtjevi";
            this.btnZavrseniZahtjevi.Size = new System.Drawing.Size(200, 42);
            this.btnZavrseniZahtjevi.TabIndex = 8;
            this.btnZavrseniZahtjevi.Text = "Završeni zahtjevi";
            this.btnZavrseniZahtjevi.UseVisualStyleBackColor = true;
            this.btnZavrseniZahtjevi.Click += new System.EventHandler(this.btnZavrseniZahtjevi_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOsvjezi.Location = new System.Drawing.Point(218, 686);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(107, 42);
            this.btnOsvjezi.TabIndex = 9;
            this.btnOsvjezi.Text = "Osvježi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // tbPretrazi
            // 
            this.tbPretrazi.Location = new System.Drawing.Point(937, 96);
            this.tbPretrazi.Name = "tbPretrazi";
            this.tbPretrazi.Size = new System.Drawing.Size(173, 29);
            this.tbPretrazi.TabIndex = 5;
            this.tbPretrazi.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbPretrazi_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(933, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Pretraži prema opisu:";
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 733);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnZavrseniZahtjevi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Djelatnik CIP-a";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPreuzetiZahtjevi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNoviZahtjevi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPreuzetiZahtjevi;
        private System.Windows.Forms.DataGridView dgvNoviZahtjevi;
        private System.Windows.Forms.Button btnDetaljiPreuzeti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDetaljiNovi;
        private System.Windows.Forms.Button btnZavrseniZahtjevi;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.TextBox tbPretrazi;
        private System.Windows.Forms.Label label1;
    }
}