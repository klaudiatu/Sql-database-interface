namespace SaveImagetoSQLServer
{
    partial class Artysta
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
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.btnZaladuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txbKraj = new System.Windows.Forms.TextBox();
            this.labMobile = new System.Windows.Forms.Label();
            this.txbImie = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.txbIdNurtu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIdArtysty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgArtysta = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txbRok = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtysta)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdytuj.Location = new System.Drawing.Point(809, 44);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(137, 93);
            this.btnEdytuj.TabIndex = 8;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.Location = new System.Drawing.Point(665, 44);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(138, 93);
            this.btnSzukaj.TabIndex = 7;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // btnZaladuj
            // 
            this.btnZaladuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaladuj.Location = new System.Drawing.Point(952, 44);
            this.btnZaladuj.Name = "btnZaladuj";
            this.btnZaladuj.Size = new System.Drawing.Size(133, 93);
            this.btnZaladuj.TabIndex = 9;
            this.btnZaladuj.Text = "Załaduj Tabelę";
            this.btnZaladuj.UseVisualStyleBackColor = true;
            this.btnZaladuj.Click += new System.EventHandler(this.btnZaladuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(503, 46);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(146, 93);
            this.btnUsun.TabIndex = 6;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(339, 46);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(147, 93);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txbKraj
            // 
            this.txbKraj.Location = new System.Drawing.Point(141, 130);
            this.txbKraj.Name = "txbKraj";
            this.txbKraj.Size = new System.Drawing.Size(169, 22);
            this.txbKraj.TabIndex = 3;
            // 
            // labMobile
            // 
            this.labMobile.AutoSize = true;
            this.labMobile.Location = new System.Drawing.Point(31, 130);
            this.labMobile.Name = "labMobile";
            this.labMobile.Size = new System.Drawing.Size(33, 17);
            this.labMobile.TabIndex = 65;
            this.labMobile.Text = "Kraj";
            // 
            // txbImie
            // 
            this.txbImie.Location = new System.Drawing.Point(141, 102);
            this.txbImie.Name = "txbImie";
            this.txbImie.Size = new System.Drawing.Size(169, 22);
            this.txbImie.TabIndex = 2;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(31, 105);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(103, 17);
            this.labPhone.TabIndex = 63;
            this.labPhone.Text = "Imie i Nazwisko";
            // 
            // txbIdNurtu
            // 
            this.txbIdNurtu.Location = new System.Drawing.Point(141, 74);
            this.txbIdNurtu.Name = "txbIdNurtu";
            this.txbIdNurtu.Size = new System.Drawing.Size(169, 22);
            this.txbIdNurtu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "IdNurtu";
            // 
            // txbIdArtysty
            // 
            this.txbIdArtysty.Location = new System.Drawing.Point(141, 46);
            this.txbIdArtysty.Name = "txbIdArtysty";
            this.txbIdArtysty.Size = new System.Drawing.Size(169, 22);
            this.txbIdArtysty.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "IdArtysty";
            // 
            // dgArtysta
            // 
            this.dgArtysta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgArtysta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArtysta.Location = new System.Drawing.Point(49, 229);
            this.dgArtysta.Name = "dgArtysta";
            this.dgArtysta.RowTemplate.Height = 24;
            this.dgArtysta.Size = new System.Drawing.Size(1019, 423);
            this.dgArtysta.TabIndex = 57;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1265, 28);
            this.menuStrip1.TabIndex = 10;
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Rok Urodzenia";
            // 
            // txbRok
            // 
            this.txbRok.Location = new System.Drawing.Point(141, 158);
            this.txbRok.Name = "txbRok";
            this.txbRok.Size = new System.Drawing.Size(169, 22);
            this.txbRok.TabIndex = 4;
            // 
            // Artysta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 660);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.btnZaladuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txbRok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbKraj);
            this.Controls.Add(this.labMobile);
            this.Controls.Add(this.txbImie);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.txbIdNurtu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIdArtysty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgArtysta);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Artysta";
            this.Text = "Artysta";
            this.Load += new System.EventHandler(this.Artysta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArtysta)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button btnZaladuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txbKraj;
        private System.Windows.Forms.Label labMobile;
        private System.Windows.Forms.TextBox txbImie;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.TextBox txbIdNurtu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIdArtysty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgArtysta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbRok;
    }
}