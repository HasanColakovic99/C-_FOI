﻿namespace WindowsFormsApp1
{
    partial class DodajAdresu
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
            this.label3 = new System.Windows.Forms.Label();
            this.idMjestaTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.dodajAdresuButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Mjesta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adresa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aktivna do:";
            // 
            // idMjestaTextBox
            // 
            this.idMjestaTextBox.Location = new System.Drawing.Point(178, 59);
            this.idMjestaTextBox.Name = "idMjestaTextBox";
            this.idMjestaTextBox.Size = new System.Drawing.Size(178, 22);
            this.idMjestaTextBox.TabIndex = 3;
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.Location = new System.Drawing.Point(178, 115);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(178, 22);
            this.adresaTextBox.TabIndex = 4;
            // 
            // dodajAdresuButton
            // 
            this.dodajAdresuButton.Location = new System.Drawing.Point(178, 228);
            this.dodajAdresuButton.Name = "dodajAdresuButton";
            this.dodajAdresuButton.Size = new System.Drawing.Size(84, 43);
            this.dodajAdresuButton.TabIndex = 6;
            this.dodajAdresuButton.Text = "Dodaj adresu";
            this.dodajAdresuButton.UseVisualStyleBackColor = true;
            this.dodajAdresuButton.Click += new System.EventHandler(this.dodajAdresuButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(272, 228);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(84, 43);
            this.odustaniButton.TabIndex = 7;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(178, 161);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(178, 22);
            this.dateTimePicker.TabIndex = 8;
            // 
            // DodajAdresu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 334);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajAdresuButton);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(this.idMjestaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajAdresu";
            this.Text = "Dodaj adresu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idMjestaTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.Button dodajAdresuButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}