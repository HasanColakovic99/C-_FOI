﻿namespace _10_Glasanje
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
            this.textBoxOIB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxOpcija = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSuzdrzan = new System.Windows.Forms.Label();
            this.labelProtiv = new System.Windows.Forms.Label();
            this.labelZa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite OIB:";
            // 
            // textBoxOIB
            // 
            this.textBoxOIB.Location = new System.Drawing.Point(27, 35);
            this.textBoxOIB.Name = "textBoxOIB";
            this.textBoxOIB.Size = new System.Drawing.Size(129, 20);
            this.textBoxOIB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odaberite opciju:";
            // 
            // comboBoxOpcija
            // 
            this.comboBoxOpcija.FormattingEnabled = true;
            this.comboBoxOpcija.Items.AddRange(new object[] {
            "ZA",
            "PROTIV",
            "SUZDRZAN"});
            this.comboBoxOpcija.Location = new System.Drawing.Point(27, 85);
            this.comboBoxOpcija.Name = "comboBoxOpcija";
            this.comboBoxOpcija.Size = new System.Drawing.Size(129, 21);
            this.comboBoxOpcija.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Glasaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Rezultati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ZA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "PROTIV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "SUZDRŽAN:";
            // 
            // labelSuzdrzan
            // 
            this.labelSuzdrzan.AutoSize = true;
            this.labelSuzdrzan.Location = new System.Drawing.Point(332, 122);
            this.labelSuzdrzan.Name = "labelSuzdrzan";
            this.labelSuzdrzan.Size = new System.Drawing.Size(0, 13);
            this.labelSuzdrzan.TabIndex = 11;
            // 
            // labelProtiv
            // 
            this.labelProtiv.AutoSize = true;
            this.labelProtiv.Location = new System.Drawing.Point(332, 85);
            this.labelProtiv.Name = "labelProtiv";
            this.labelProtiv.Size = new System.Drawing.Size(0, 13);
            this.labelProtiv.TabIndex = 10;
            // 
            // labelZa
            // 
            this.labelZa.AutoSize = true;
            this.labelZa.Location = new System.Drawing.Point(332, 42);
            this.labelZa.Name = "labelZa";
            this.labelZa.Size = new System.Drawing.Size(0, 13);
            this.labelZa.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 192);
            this.Controls.Add(this.labelSuzdrzan);
            this.Controls.Add(this.labelProtiv);
            this.Controls.Add(this.labelZa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxOpcija);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxOIB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izbori";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOIB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxOpcija;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSuzdrzan;
        private System.Windows.Forms.Label labelProtiv;
        private System.Windows.Forms.Label labelZa;
    }
}

