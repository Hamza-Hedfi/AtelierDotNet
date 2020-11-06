namespace TP03
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BoutonAjouter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BoutonVersListe2 = new System.Windows.Forms.Button();
            this.BoutonVersListe1 = new System.Windows.Forms.Button();
            this.BoutonEffacerListe1 = new System.Windows.Forms.Button();
            this.BoutonEffacerListe2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taper un texte pour l\'inclure dans la liste 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Saisie";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 2;
            // 
            // BoutonAjouter
            // 
            this.BoutonAjouter.Location = new System.Drawing.Point(235, 53);
            this.BoutonAjouter.Name = "BoutonAjouter";
            this.BoutonAjouter.Size = new System.Drawing.Size(119, 23);
            this.BoutonAjouter.TabIndex = 3;
            this.BoutonAjouter.Text = "Ajouter";
            this.BoutonAjouter.UseVisualStyleBackColor = true;
            this.BoutonAjouter.Click += new System.EventHandler(this.BoutonAjouter_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Liste 1";
            // 
            // BoutonVersListe2
            // 
            this.BoutonVersListe2.Location = new System.Drawing.Point(153, 158);
            this.BoutonVersListe2.Name = "BoutonVersListe2";
            this.BoutonVersListe2.Size = new System.Drawing.Size(75, 23);
            this.BoutonVersListe2.TabIndex = 8;
            this.BoutonVersListe2.Text = "->";
            this.BoutonVersListe2.UseVisualStyleBackColor = true;
            this.BoutonVersListe2.Click += new System.EventHandler(this.BoutonVersListe2_Click);
            // 
            // BoutonVersListe1
            // 
            this.BoutonVersListe1.Location = new System.Drawing.Point(153, 187);
            this.BoutonVersListe1.Name = "BoutonVersListe1";
            this.BoutonVersListe1.Size = new System.Drawing.Size(75, 23);
            this.BoutonVersListe1.TabIndex = 9;
            this.BoutonVersListe1.Text = "<-";
            this.BoutonVersListe1.UseVisualStyleBackColor = true;
            this.BoutonVersListe1.Click += new System.EventHandler(this.BoutonVersListe1_Click);
            // 
            // BoutonEffacerListe1
            // 
            this.BoutonEffacerListe1.Location = new System.Drawing.Point(50, 247);
            this.BoutonEffacerListe1.Name = "BoutonEffacerListe1";
            this.BoutonEffacerListe1.Size = new System.Drawing.Size(75, 23);
            this.BoutonEffacerListe1.TabIndex = 10;
            this.BoutonEffacerListe1.Text = "Effacer";
            this.BoutonEffacerListe1.UseVisualStyleBackColor = true;
            this.BoutonEffacerListe1.Click += new System.EventHandler(this.BoutonEffacerListe1_Click);
            // 
            // BoutonEffacerListe2
            // 
            this.BoutonEffacerListe2.Location = new System.Drawing.Point(257, 247);
            this.BoutonEffacerListe2.Name = "BoutonEffacerListe2";
            this.BoutonEffacerListe2.Size = new System.Drawing.Size(75, 23);
            this.BoutonEffacerListe2.TabIndex = 13;
            this.BoutonEffacerListe2.Text = "Effacer";
            this.BoutonEffacerListe2.UseVisualStyleBackColor = true;
            this.BoutonEffacerListe2.Click += new System.EventHandler(this.BoutonEffacerListe2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Liste 2";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(234, 137);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AcceptButton = this.BoutonAjouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 301);
            this.Controls.Add(this.BoutonEffacerListe2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.BoutonEffacerListe1);
            this.Controls.Add(this.BoutonVersListe1);
            this.Controls.Add(this.BoutonVersListe2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BoutonAjouter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BoutonAjouter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BoutonVersListe2;
        private System.Windows.Forms.Button BoutonVersListe1;
        private System.Windows.Forms.Button BoutonEffacerListe1;
        private System.Windows.Forms.Button BoutonEffacerListe2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
    }
}

