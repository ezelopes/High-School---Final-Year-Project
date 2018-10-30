namespace Tesina
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_accedi = new System.Windows.Forms.Button();
            this.txt_pswdacc = new System.Windows.Forms.TextBox();
            this.txt_nomeacc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btn_accedi);
            this.groupBox1.Controls.Add(this.txt_pswdacc);
            this.groupBox1.Controls.Add(this.txt_nomeacc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 122);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACCEDI";
            // 
            // btn_accedi
            // 
            this.btn_accedi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accedi.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_accedi.Location = new System.Drawing.Point(312, 85);
            this.btn_accedi.Name = "btn_accedi";
            this.btn_accedi.Size = new System.Drawing.Size(111, 31);
            this.btn_accedi.TabIndex = 4;
            this.btn_accedi.Text = "ACCEDI";
            this.btn_accedi.UseVisualStyleBackColor = true;
            this.btn_accedi.Click += new System.EventHandler(this.btn_accedi_Click);
            // 
            // txt_pswdacc
            // 
            this.txt_pswdacc.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pswdacc.Location = new System.Drawing.Point(126, 63);
            this.txt_pswdacc.Name = "txt_pswdacc";
            this.txt_pswdacc.PasswordChar = '*';
            this.txt_pswdacc.Size = new System.Drawing.Size(134, 28);
            this.txt_pswdacc.TabIndex = 3;
            this.txt_pswdacc.Text = "12345678";
            // 
            // txt_nomeacc
            // 
            this.txt_nomeacc.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeacc.Location = new System.Drawing.Point(126, 21);
            this.txt_nomeacc.Name = "txt_nomeacc";
            this.txt_nomeacc.Size = new System.Drawing.Size(134, 28);
            this.txt_nomeacc.TabIndex = 2;
            this.txt_nomeacc.Text = "Eze20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nome Account:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 171);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Bask-Tech - Accedi!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_accedi;
        private System.Windows.Forms.TextBox txt_pswdacc;
        private System.Windows.Forms.TextBox txt_nomeacc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

