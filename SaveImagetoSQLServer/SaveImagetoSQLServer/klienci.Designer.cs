namespace SaveImagetoSQLServer
{
    partial class klienci
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
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txbImie = new System.Windows.Forms.TextBox();
            this.labMobile = new System.Windows.Forms.Label();
            this.txbIdPlatnosci = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.txbIdZamowienia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIdKlienta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgKlienci = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.txbAdres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbKraj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTelefon = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgKlienci)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(585, 31);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 70);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txbImie
            // 
            this.txbImie.Location = new System.Drawing.Point(120, 115);
            this.txbImie.Name = "txbImie";
            this.txbImie.Size = new System.Drawing.Size(169, 22);
            this.txbImie.TabIndex = 3;
            // 
            // labMobile
            // 
            this.labMobile.AutoSize = true;
            this.labMobile.Location = new System.Drawing.Point(12, 115);
            this.labMobile.Name = "labMobile";
            this.labMobile.Size = new System.Drawing.Size(103, 17);
            this.labMobile.TabIndex = 30;
            this.labMobile.Text = "Imie i Nazwisko";
            // 
            // txbIdPlatnosci
            // 
            this.txbIdPlatnosci.Location = new System.Drawing.Point(120, 87);
            this.txbIdPlatnosci.Name = "txbIdPlatnosci";
            this.txbIdPlatnosci.Size = new System.Drawing.Size(169, 22);
            this.txbIdPlatnosci.TabIndex = 2;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(12, 89);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(80, 17);
            this.labPhone.TabIndex = 27;
            this.labPhone.Text = "Id Płatności";
            // 
            // txbIdZamowienia
            // 
            this.txbIdZamowienia.Location = new System.Drawing.Point(120, 59);
            this.txbIdZamowienia.Name = "txbIdZamowienia";
            this.txbIdZamowienia.Size = new System.Drawing.Size(169, 22);
            this.txbIdZamowienia.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Id Zamówienia";
            // 
            // txbIdKlienta
            // 
            this.txbIdKlienta.Location = new System.Drawing.Point(120, 31);
            this.txbIdKlienta.Name = "txbIdKlienta";
            this.txbIdKlienta.Size = new System.Drawing.Size(169, 22);
            this.txbIdKlienta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Id Klienta";
            // 
            // dgKlienci
            // 
            this.dgKlienci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgKlienci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKlienci.Location = new System.Drawing.Point(14, 177);
            this.dgKlienci.Name = "dgKlienci";
            this.dgKlienci.RowTemplate.Height = 24;
            this.dgKlienci.Size = new System.Drawing.Size(1019, 315);
            this.dgKlienci.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Adres";
            // 
            // txbAdres
            // 
            this.txbAdres.Location = new System.Drawing.Point(386, 32);
            this.txbAdres.Name = "txbAdres";
            this.txbAdres.Size = new System.Drawing.Size(169, 22);
            this.txbAdres.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kraj";
            // 
            // txbKraj
            // 
            this.txbKraj.Location = new System.Drawing.Point(386, 60);
            this.txbKraj.Name = "txbKraj";
            this.txbKraj.Size = new System.Drawing.Size(169, 22);
            this.txbKraj.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Telefon";
            // 
            // txbTelefon
            // 
            this.txbTelefon.Location = new System.Drawing.Point(386, 88);
            this.txbTelefon.Name = "txbTelefon";
            this.txbTelefon.Size = new System.Drawing.Size(169, 22);
            this.txbTelefon.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(386, 116);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(169, 22);
            this.txbEmail.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(691, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 70);
            this.button1.TabIndex = 9;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 21);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 8);
            this.button2.TabIndex = 35;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(780, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 70);
            this.button3.TabIndex = 10;
            this.button3.Text = "Edytuj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(873, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 70);
            this.button4.TabIndex = 11;
            this.button4.Text = "Szukaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(958, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 70);
            this.button5.TabIndex = 12;
            this.button5.Text = "Załaduj tabelę";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // klienci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 503);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.txbImie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labMobile);
            this.Controls.Add(this.txbTelefon);
            this.Controls.Add(this.txbIdPlatnosci);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.txbKraj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbIdZamowienia);
            this.Controls.Add(this.txbAdres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbIdKlienta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgKlienci);
            this.Controls.Add(this.menuStrip1);
            this.Name = "klienci";
            this.Text = "klienci";
            this.Load += new System.EventHandler(this.klienci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKlienci)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txbImie;
        private System.Windows.Forms.Label labMobile;
        private System.Windows.Forms.TextBox txbIdPlatnosci;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.TextBox txbIdZamowienia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIdKlienta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgKlienci;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbAdres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbKraj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTelefon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}