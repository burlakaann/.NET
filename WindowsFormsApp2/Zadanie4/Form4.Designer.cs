﻿namespace Zadanie4
{
    partial class Form4
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
            this.numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonOblicz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownX2
            // 
            this.numericUpDownX2.Location = new System.Drawing.Point(504, 94);
            this.numericUpDownX2.Name = "numericUpDownX2";
            this.numericUpDownX2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX2.TabIndex = 0;
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.Location = new System.Drawing.Point(504, 147);
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownK.TabIndex = 1;
            // 
            // numericUpDownX1
            // 
            this.numericUpDownX1.Location = new System.Drawing.Point(504, 44);
            this.numericUpDownX1.Name = "numericUpDownX1";
            this.numericUpDownX1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX1.TabIndex = 2;
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.Location = new System.Drawing.Point(504, 204);
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownZ.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(431, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(431, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(431, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "k";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(431, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "z";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 277);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(486, 95);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Location = new System.Drawing.Point(504, 277);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(75, 23);
            this.buttonOblicz.TabIndex = 9;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownZ);
            this.Controls.Add(this.numericUpDownX1);
            this.Controls.Add(this.numericUpDownK);
            this.Controls.Add(this.numericUpDownX2);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.NumericUpDown numericUpDownX1;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonOblicz;
    }
}

