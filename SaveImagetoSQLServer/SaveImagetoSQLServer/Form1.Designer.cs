namespace SaveImagetoSQLServer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdO = new System.Windows.Forms.TextBox();
            this.IdA = new System.Windows.Forms.TextBox();
            this.IdSO = new System.Windows.Forms.TextBox();
            this.Tytul = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.picObraz = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.artyściToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klienciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrazyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamówieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picObraz)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(32, 356);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(218, 71);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Obrazu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id Artysty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id Status Obrazu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tytuł";
            // 
            // IdO
            // 
            this.IdO.Location = new System.Drawing.Point(73, 94);
            this.IdO.Name = "IdO";
            this.IdO.Size = new System.Drawing.Size(100, 22);
            this.IdO.TabIndex = 0;
            // 
            // IdA
            // 
            this.IdA.Location = new System.Drawing.Point(73, 165);
            this.IdA.Name = "IdA";
            this.IdA.Size = new System.Drawing.Size(100, 22);
            this.IdA.TabIndex = 1;
            // 
            // IdSO
            // 
            this.IdSO.Location = new System.Drawing.Point(73, 249);
            this.IdSO.Name = "IdSO";
            this.IdSO.Size = new System.Drawing.Size(100, 22);
            this.IdSO.TabIndex = 2;
            // 
            // Tytul
            // 
            this.Tytul.Location = new System.Drawing.Point(73, 312);
            this.Tytul.Name = "Tytul";
            this.Tytul.Size = new System.Drawing.Size(100, 22);
            this.Tytul.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(32, 433);
            this.buttonSave.MinimumSize = new System.Drawing.Size(218, 60);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(218, 60);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // picObraz
            // 
            this.picObraz.Location = new System.Drawing.Point(328, 55);
            this.picObraz.Name = "picObraz";
            this.picObraz.Size = new System.Drawing.Size(672, 500);
            this.picObraz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picObraz.TabIndex = 11;
            this.picObraz.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(32, 499);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(218, 73);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artyściToolStripMenuItem,
            this.klienciToolStripMenuItem,
            this.obrazyToolStripMenuItem,
            this.zamówieniaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(1086, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1282, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // artyściToolStripMenuItem
            // 
            this.artyściToolStripMenuItem.Name = "artyściToolStripMenuItem";
            this.artyściToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.artyściToolStripMenuItem.Text = "Artyści";
            this.artyściToolStripMenuItem.Click += new System.EventHandler(this.artyściToolStripMenuItem_Click);
            // 
            // klienciToolStripMenuItem
            // 
            this.klienciToolStripMenuItem.Name = "klienciToolStripMenuItem";
            this.klienciToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.klienciToolStripMenuItem.Text = "Klienci";
            this.klienciToolStripMenuItem.Click += new System.EventHandler(this.klienciToolStripMenuItem_Click);
            // 
            // obrazyToolStripMenuItem
            // 
            this.obrazyToolStripMenuItem.Name = "obrazyToolStripMenuItem";
            this.obrazyToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.obrazyToolStripMenuItem.Text = "Obrazy";
            this.obrazyToolStripMenuItem.Click += new System.EventHandler(this.obrazyToolStripMenuItem_Click);
            // 
            // zamówieniaToolStripMenuItem
            // 
            this.zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            this.zamówieniaToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.zamówieniaToolStripMenuItem.Text = "Zamówienia";
            this.zamówieniaToolStripMenuItem.Click += new System.EventHandler(this.zamówieniaToolStripMenuItem_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(32, 578);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(218, 75);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Wyczyść";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.picObraz);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.Tytul);
            this.Controls.Add(this.IdSO);
            this.Controls.Add(this.IdA);
            this.Controls.Add(this.IdO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1300, 800);
            this.Name = "Form1";
            this.Text = "Galeria Sztuki";
            ((System.ComponentModel.ISupportInitialize)(this.picObraz)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IdO;
        private System.Windows.Forms.TextBox IdA;
        private System.Windows.Forms.TextBox IdSO;
        private System.Windows.Forms.TextBox Tytul;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox picObraz;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artyściToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klienciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrazyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamówieniaToolStripMenuItem;
        private System.Windows.Forms.Button btnClean;
    }
}

