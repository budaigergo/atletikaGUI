namespace atletikaGUI
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
            this.listBoxOrszagok = new System.Windows.Forms.ListBox();
            this.listBoxVersenyszamok = new System.Windows.Forms.ListBox();
            this.eremvalaszto = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.eredmeny = new System.Windows.Forms.Label();
            this.nev = new System.Windows.Forms.Label();
            this.nemzet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eremvalaszto)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxOrszagok
            // 
            this.listBoxOrszagok.FormattingEnabled = true;
            this.listBoxOrszagok.ItemHeight = 25;
            this.listBoxOrszagok.Location = new System.Drawing.Point(69, 43);
            this.listBoxOrszagok.Name = "listBoxOrszagok";
            this.listBoxOrszagok.Size = new System.Drawing.Size(301, 379);
            this.listBoxOrszagok.TabIndex = 0;
            // 
            // listBoxVersenyszamok
            // 
            this.listBoxVersenyszamok.FormattingEnabled = true;
            this.listBoxVersenyszamok.ItemHeight = 25;
            this.listBoxVersenyszamok.Location = new System.Drawing.Point(470, 43);
            this.listBoxVersenyszamok.Name = "listBoxVersenyszamok";
            this.listBoxVersenyszamok.Size = new System.Drawing.Size(291, 154);
            this.listBoxVersenyszamok.TabIndex = 1;
            // 
            // eremvalaszto
            // 
            this.eremvalaszto.Location = new System.Drawing.Point(486, 298);
            this.eremvalaszto.Name = "eremvalaszto";
            this.eremvalaszto.Size = new System.Drawing.Size(120, 32);
            this.eremvalaszto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Válassza ki a versenyszámot:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Versenyző adatai:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Aranyérmet szerzett nemzetek:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Válassza ki az érmes helyezést:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 85);
            this.button1.TabIndex = 7;
            this.button1.Text = "keresés";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 537);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "neve:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "eredménye:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(448, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "nemzete:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 62);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // eredmeny
            // 
            this.eredmeny.AutoSize = true;
            this.eredmeny.Location = new System.Drawing.Point(588, 572);
            this.eredmeny.Name = "eredmeny";
            this.eredmeny.Size = new System.Drawing.Size(73, 25);
            this.eredmeny.TabIndex = 12;
            this.eredmeny.Text = "label8";
            // 
            // nev
            // 
            this.nev.AutoSize = true;
            this.nev.Location = new System.Drawing.Point(585, 537);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(73, 25);
            this.nev.TabIndex = 13;
            this.nev.Text = "label9";
            // 
            // nemzet
            // 
            this.nemzet.AutoSize = true;
            this.nemzet.Location = new System.Drawing.Point(588, 608);
            this.nemzet.Name = "nemzet";
            this.nemzet.Size = new System.Drawing.Size(86, 25);
            this.nemzet.TabIndex = 15;
            this.nemzet.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.nemzet);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.eredmeny);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eremvalaszto);
            this.Controls.Add(this.listBoxVersenyszamok);
            this.Controls.Add(this.listBoxOrszagok);
            this.Font = new System.Drawing.Font("Verdana", 12F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eremvalaszto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOrszagok;
        private System.Windows.Forms.ListBox listBoxVersenyszamok;
        private System.Windows.Forms.NumericUpDown eremvalaszto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label eredmeny;
        private System.Windows.Forms.Label nev;
        private System.Windows.Forms.Label nemzet;
    }
}

