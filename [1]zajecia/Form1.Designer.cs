namespace _1_zajecia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wart1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wart2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dodaj = new System.Windows.Forms.Button();
            this.odejmij = new System.Windows.Forms.Button();
            this.pomnoz = new System.Windows.Forms.Button();
            this.podziel = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wart1
            // 
            this.wart1.Location = new System.Drawing.Point(53, 51);
            this.wart1.Name = "wart1";
            this.wart1.Size = new System.Drawing.Size(71, 23);
            this.wart1.TabIndex = 0;
            this.wart1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "wartość 1";
            // 
            // wart2
            // 
            this.wart2.Location = new System.Drawing.Point(229, 51);
            this.wart2.Name = "wart2";
            this.wart2.Size = new System.Drawing.Size(71, 23);
            this.wart2.TabIndex = 2;
            this.wart2.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "wartość 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "wynik";
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(82, 231);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(35, 35);
            this.dodaj.TabIndex = 5;
            this.dodaj.Text = "+";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // odejmij
            // 
            this.odejmij.Location = new System.Drawing.Point(138, 231);
            this.odejmij.Name = "odejmij";
            this.odejmij.Size = new System.Drawing.Size(35, 35);
            this.odejmij.TabIndex = 6;
            this.odejmij.Text = "-";
            this.odejmij.UseVisualStyleBackColor = true;
            this.odejmij.Click += new System.EventHandler(this.odejmij_Click);
            // 
            // pomnoz
            // 
            this.pomnoz.Location = new System.Drawing.Point(191, 231);
            this.pomnoz.Name = "pomnoz";
            this.pomnoz.Size = new System.Drawing.Size(35, 35);
            this.pomnoz.TabIndex = 7;
            this.pomnoz.Text = "*";
            this.pomnoz.UseVisualStyleBackColor = true;
            this.pomnoz.Click += new System.EventHandler(this.pomnoz_Click);
            // 
            // podziel
            // 
            this.podziel.Location = new System.Drawing.Point(244, 231);
            this.podziel.Name = "podziel";
            this.podziel.Size = new System.Drawing.Size(35, 35);
            this.podziel.TabIndex = 8;
            this.podziel.Text = "/";
            this.podziel.UseVisualStyleBackColor = true;
            this.podziel.Click += new System.EventHandler(this.podziel_Click);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wynik.Location = new System.Drawing.Point(158, 134);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(25, 30);
            this.wynik.TabIndex = 9;
            this.wynik.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 323);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.podziel);
            this.Controls.Add(this.pomnoz);
            this.Controls.Add(this.odejmij);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wart2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox wart1;
        private Label label1;
        private TextBox wart2;
        private Label label2;
        private Label label3;
        private Button dodaj;
        private Button odejmij;
        private Button pomnoz;
        private Button podziel;
        private Label wynik;
    }
}