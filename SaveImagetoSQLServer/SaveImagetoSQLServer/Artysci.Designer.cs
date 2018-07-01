namespace SaveImagetoSQLServer
{
    partial class FArtysci
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
            this.TxbNurt = new System.Windows.Forms.TextBox();
            this.labMobile = new System.Windows.Forms.Label();
            this.txbRok = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.TxbKraj = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgArtysci = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbId = new System.Windows.Forms.TextBox();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnZaladuj = new System.Windows.Forms.Button();
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgArtysci)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxbNurt
            // 
            this.TxbNurt.Location = new System.Drawing.Point(366, 78);
            this.TxbNurt.Name = "TxbNurt";
            this.TxbNurt.Size = new System.Drawing.Size(169, 22);
            this.TxbNurt.TabIndex = 4;
            // 
            // labMobile
            // 
            this.labMobile.AutoSize = true;
            this.labMobile.Location = new System.Drawing.Point(258, 78);
            this.labMobile.Name = "labMobile";
            this.labMobile.Size = new System.Drawing.Size(54, 17);
            this.labMobile.TabIndex = 18;
            this.labMobile.Text = "IdNurtu";
            // 
            // txbRok
            // 
            this.txbRok.Location = new System.Drawing.Point(366, 48);
            this.txbRok.Name = "txbRok";
            this.txbRok.Size = new System.Drawing.Size(169, 22);
            this.txbRok.TabIndex = 3;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(258, 50);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(102, 17);
            this.labPhone.TabIndex = 16;
            this.labPhone.Text = "Rok Urodzenia";
            // 
            // TxbKraj
            // 
            this.TxbKraj.Location = new System.Drawing.Point(68, 78);
            this.TxbKraj.Name = "TxbKraj";
            this.TxbKraj.Size = new System.Drawing.Size(169, 22);
            this.TxbKraj.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Kraj";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(68, 50);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(169, 22);
            this.txbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // dgArtysci
            // 
            this.dgArtysci.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgArtysci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgArtysci.Location = new System.Drawing.Point(14, 149);
            this.dgArtysci.Name = "dgArtysci";
            this.dgArtysci.RowTemplate.Height = 24;
            this.dgArtysci.Size = new System.Drawing.Size(1019, 315);
            this.dgArtysci.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 28);
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
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.Location = new System.Drawing.Point(541, 48);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(98, 93);
            this.btnDodaj.TabIndex = 5;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Id Artysty";
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(89, 103);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(169, 22);
            this.txbId.TabIndex = 2;
            // 
            // btnUsun
            // 
            this.btnUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsun.Location = new System.Drawing.Point(645, 48);
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.Size = new System.Drawing.Size(94, 93);
            this.btnUsun.TabIndex = 6;
            this.btnUsun.Text = "Usuń";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnZaladuj
            // 
            this.btnZaladuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaladuj.Location = new System.Drawing.Point(933, 48);
            this.btnZaladuj.Name = "btnZaladuj";
            this.btnZaladuj.Size = new System.Drawing.Size(100, 93);
            this.btnZaladuj.TabIndex = 9;
            this.btnZaladuj.Text = "Załaduj Tabelę";
            this.btnZaladuj.UseVisualStyleBackColor = true;
            this.btnZaladuj.Click += new System.EventHandler(this.btnZaladuj_Click);
            // 
            // btnSzukaj
            // 
            this.btnSzukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSzukaj.Location = new System.Drawing.Point(745, 48);
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.Size = new System.Drawing.Size(85, 93);
            this.btnSzukaj.TabIndex = 7;
            this.btnSzukaj.Text = "Szukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdytuj.Location = new System.Drawing.Point(836, 48);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(91, 93);
            this.btnEdytuj.TabIndex = 8;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // FArtysci
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 486);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.btnZaladuj);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.TxbNurt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labMobile);
            this.Controls.Add(this.txbRok);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.TxbKraj);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgArtysci);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FArtysci";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Artyści";
            this.Load += new System.EventHandler(this.FArtysci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgArtysci)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxbNurt;
        private System.Windows.Forms.Label labMobile;
        private System.Windows.Forms.TextBox txbRok;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.TextBox TxbKraj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgArtysci;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnZaladuj;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.Button btnEdytuj;
    }
}