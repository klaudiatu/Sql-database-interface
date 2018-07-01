namespace SaveImagetoSQLServer
{
    partial class Obrazy
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txbTytul = new System.Windows.Forms.TextBox();
            this.labMobile = new System.Windows.Forms.Label();
            this.txbStatus = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.txbIdArtysty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIdObrazu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgObrazy = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgObrazy)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(820, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 114);
            this.button5.TabIndex = 7;
            this.button5.Text = "Załaduj tabelę";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(682, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 114);
            this.button4.TabIndex = 6;
            this.button4.Text = "Szukaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEdytuj
            // 
            this.btnEdytuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEdytuj.Location = new System.Drawing.Point(542, 31);
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.Size = new System.Drawing.Size(134, 114);
            this.btnEdytuj.TabIndex = 5;
            this.btnEdytuj.Text = "Edytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(403, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 114);
            this.button1.TabIndex = 4;
            this.button1.Text = "Usuń";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbTytul
            // 
            this.txbTytul.Location = new System.Drawing.Point(141, 128);
            this.txbTytul.Name = "txbTytul";
            this.txbTytul.Size = new System.Drawing.Size(169, 22);
            this.txbTytul.TabIndex = 3;
            // 
            // labMobile
            // 
            this.labMobile.AutoSize = true;
            this.labMobile.Location = new System.Drawing.Point(33, 128);
            this.labMobile.Name = "labMobile";
            this.labMobile.Size = new System.Drawing.Size(39, 17);
            this.labMobile.TabIndex = 53;
            this.labMobile.Text = "Tytuł";
            // 
            // txbStatus
            // 
            this.txbStatus.Location = new System.Drawing.Point(141, 100);
            this.txbStatus.Name = "txbStatus";
            this.txbStatus.Size = new System.Drawing.Size(169, 22);
            this.txbStatus.TabIndex = 2;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(33, 102);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(99, 17);
            this.labPhone.TabIndex = 49;
            this.labPhone.Text = "Status Obrazu";
            // 
            // txbIdArtysty
            // 
            this.txbIdArtysty.Location = new System.Drawing.Point(141, 72);
            this.txbIdArtysty.Name = "txbIdArtysty";
            this.txbIdArtysty.Size = new System.Drawing.Size(169, 22);
            this.txbIdArtysty.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Id Artysty";
            // 
            // txbIdObrazu
            // 
            this.txbIdObrazu.Location = new System.Drawing.Point(141, 44);
            this.txbIdObrazu.Name = "txbIdObrazu";
            this.txbIdObrazu.Size = new System.Drawing.Size(169, 22);
            this.txbIdObrazu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Id Obrazu";
            // 
            // dgObrazy
            // 
            this.dgObrazy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgObrazy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgObrazy.Location = new System.Drawing.Point(35, 190);
            this.dgObrazy.Name = "dgObrazy";
            this.dgObrazy.RowTemplate.Height = 24;
            this.dgObrazy.Size = new System.Drawing.Size(1019, 315);
            this.dgObrazy.TabIndex = 39;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 28);
            this.menuStrip1.TabIndex = 8;
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
            // Obrazy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 645);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbTytul);
            this.Controls.Add(this.labMobile);
            this.Controls.Add(this.txbStatus);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.txbIdArtysty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbIdObrazu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgObrazy);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Obrazy";
            this.Text = "Obrazy";
            this.Load += new System.EventHandler(this.Obrazy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgObrazy)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txbTytul;
        private System.Windows.Forms.Label labMobile;
        private System.Windows.Forms.TextBox txbStatus;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.TextBox txbIdArtysty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbIdObrazu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgObrazy;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
    }
}