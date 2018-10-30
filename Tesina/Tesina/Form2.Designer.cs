namespace Tesina
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_nomeaccount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ricercaConnessioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classificheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_recordPersonale = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_recordTotale = new System.Windows.Forms.Label();
            this.lbl_punteggioCorrente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nomeaccount
            // 
            this.lbl_nomeaccount.AutoSize = true;
            this.lbl_nomeaccount.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomeaccount.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbl_nomeaccount.Location = new System.Drawing.Point(15, 36);
            this.lbl_nomeaccount.Name = "lbl_nomeaccount";
            this.lbl_nomeaccount.Size = new System.Drawing.Size(150, 27);
            this.lbl_nomeaccount.TabIndex = 9;
            this.lbl_nomeaccount.Text = "Nome_Account";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(512, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 102);
            this.textBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "AVVIA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ricercaConnessioniToolStripMenuItem,
            this.classificheToolStripMenuItem,
            this.guidaToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ricercaConnessioniToolStripMenuItem
            // 
            this.ricercaConnessioniToolStripMenuItem.Name = "ricercaConnessioniToolStripMenuItem";
            this.ricercaConnessioniToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ricercaConnessioniToolStripMenuItem.Text = "Ricerca Connessioni";
            this.ricercaConnessioniToolStripMenuItem.Click += new System.EventHandler(this.ricercaConnessioniToolStripMenuItem_Click);
            // 
            // classificheToolStripMenuItem
            // 
            this.classificheToolStripMenuItem.Name = "classificheToolStripMenuItem";
            this.classificheToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.classificheToolStripMenuItem.Text = "Classifiche";
            this.classificheToolStripMenuItem.Click += new System.EventHandler(this.classificheToolStripMenuItem_Click);
            // 
            // guidaToolStripMenuItem
            // 
            this.guidaToolStripMenuItem.Name = "guidaToolStripMenuItem";
            this.guidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.guidaToolStripMenuItem.Text = "Guida";
            this.guidaToolStripMenuItem.Click += new System.EventHandler(this.guidaToolStripMenuItem_Click);
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempo.Location = new System.Drawing.Point(288, 38);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(72, 26);
            this.lbl_tempo.TabIndex = 11;
            this.lbl_tempo.Text = "Tempo";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_recordPersonale);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_recordTotale);
            this.panel1.Controls.Add(this.lbl_punteggioCorrente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 155);
            this.panel1.TabIndex = 12;
            // 
            // lbl_recordPersonale
            // 
            this.lbl_recordPersonale.AutoSize = true;
            this.lbl_recordPersonale.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recordPersonale.Location = new System.Drawing.Point(239, 65);
            this.lbl_recordPersonale.Name = "lbl_recordPersonale";
            this.lbl_recordPersonale.Size = new System.Drawing.Size(22, 24);
            this.lbl_recordPersonale.TabIndex = 17;
            this.lbl_recordPersonale.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "Record Personale:";
            // 
            // lbl_recordTotale
            // 
            this.lbl_recordTotale.AutoSize = true;
            this.lbl_recordTotale.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_recordTotale.Location = new System.Drawing.Point(239, 111);
            this.lbl_recordTotale.Name = "lbl_recordTotale";
            this.lbl_recordTotale.Size = new System.Drawing.Size(22, 24);
            this.lbl_recordTotale.TabIndex = 15;
            this.lbl_recordTotale.Text = "0";
            // 
            // lbl_punteggioCorrente
            // 
            this.lbl_punteggioCorrente.AutoSize = true;
            this.lbl_punteggioCorrente.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_punteggioCorrente.Location = new System.Drawing.Point(239, 21);
            this.lbl_punteggioCorrente.Name = "lbl_punteggioCorrente";
            this.lbl_punteggioCorrente.Size = new System.Drawing.Size(22, 24);
            this.lbl_punteggioCorrente.TabIndex = 14;
            this.lbl_punteggioCorrente.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Record Mondiale:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 12;
            this.label1.Text = "Punteggio:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(173, 91);
            this.progressBar1.Maximum = 3600;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(310, 40);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 14;
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 326);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.lbl_nomeaccount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Bask-Tech";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nomeaccount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guidaToolStripMenuItem;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_recordTotale;
        private System.Windows.Forms.Label lbl_punteggioCorrente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_recordPersonale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem ricercaConnessioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
    }
}