namespace SaveImagetoSQLServer
{
    partial class Zamowienia
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
            this.TxbData = new System.Windows.Forms.TextBox();
            this.labMobile = new System.Windows.Forms.Label();
            this.txbObraz = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.TxbKlient = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbZamowienie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgZamowienia = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgZamowienia)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdytuj.Location = new System.Drawing.Point(809, 38);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(137, 93);
            this.btnEdytuj.TabIndex = 7;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.Location = new System.Drawing.Point(665, 38);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(138, 93);
            this.btnSzukaj.TabIndex = 6;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // btnZaladuj
            // 
            this.btnZaladuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaladuj.Location = new System.Drawing.Point(952, 38);
            this.btnZaladuj.Name = "btnZaladuj";
            this.btnZaladuj.Size = new System.Drawing.Size(133, 93);
            this.btnZaladuj.TabIndex = 8;
            this.btnZaladuj.Text = "Załaduj Tabelę";
            this.btnZaladuj.UseVisualStyleBackColor = true;
            this.btnZaladuj.Click += new System.EventHandler(this.btnZaladuj_Click);
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(503, 40);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(146, 93);
            this.btnUsun.TabIndex = 5;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(339, 40);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(147, 93);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // TxbData
            // 
            this.TxbData.Location = new System.Drawing.Point(141, 124);
            this.TxbData.Name = "TxbData";
            this.TxbData.Size = new System.Drawing.Size(169, 22);
            this.TxbData.TabIndex = 3;
            // 
            // labMobile
            // 
            this.labMobile.AutoSize = true;
            this.labMobile.Location = new System.Drawing.Point(31, 129);
            this.labMobile.Name = "labMobile";
            this.labMobile.Size = new System.Drawing.Size(38, 17);
            this.labMobile.TabIndex = 33;
            this.labMobile.Text = "Data";
            // 
            // txbObraz
            // 
            this.txbObraz.Location = new System.Drawing.Point(141, 96);
            this.txbObraz.Name = "txbObraz";
            this.txbObraz.Size = new System.Drawing.Size(169, 22);
            this.txbObraz.TabIndex = 2;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(31, 99);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(70, 17);
            this.labPhone.TabIndex = 31;
            this.labPhone.Text = "Id Obrazu";
            // 
            // TxbKlient
            // 
            this.TxbKlient.Location = new System.Drawing.Point(141, 68);
            this.TxbKlient.Name = "TxbKlient";
            this.TxbKlient.Size = new System.Drawing.Size(169, 22);
            this.TxbKlient.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Id Klienta";
            // 
            // txbZamowienie
            // 
            this.txbZamowienie.Location = new System.Drawing.Point(141, 40);
            this.txbZamowienie.Name = "txbZamowienie";
            this.txbZamowienie.Size = new System.Drawing.Size(169, 22);
            this.txbZamowienie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "IdZamówienia";
            // 
            // dgZamowienia
            // 
            this.dgZamowienia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgZamowienia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgZamowienia.Location = new System.Drawing.Point(34, 152);
            this.dgZamowienia.Name = "dgZamowienia";
            this.dgZamowienia.RowTemplate.Height = 24;
            this.dgZamowienia.Size = new System.Drawing.Size(1019, 315);
            this.dgZamowienia.TabIndex = 25;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1108, 28);
            this.menuStrip1.TabIndex = 9;
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
            // Zamowienia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 479);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.btnZaladuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.TxbData);
            this.Controls.Add(this.labMobile);
            this.Controls.Add(this.txbObraz);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.TxbKlient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbZamowienie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgZamowienia);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Zamowienia";
            this.Text = "Zamowienia";
            this.Load += new System.EventHandler(this.Zamowienia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgZamowienia)).EndInit();
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
        private System.Windows.Forms.TextBox TxbData;
        private System.Windows.Forms.Label labMobile;
        private System.Windows.Forms.TextBox txbObraz;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.TextBox TxbKlient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbZamowienie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgZamowienia;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}