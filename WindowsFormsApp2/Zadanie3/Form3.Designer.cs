namespace Zadanie3
{
    partial class Form3
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
            this.numericUpDownX1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            this.x1 = new System.Windows.Forms.Label();
            this.x2 = new System.Windows.Forms.Label();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownX1
            // 
            this.numericUpDownX1.Location = new System.Drawing.Point(539, 137);
            this.numericUpDownX1.Name = "numericUpDownX1";
            this.numericUpDownX1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX1.TabIndex = 0;
            // 
            // numericUpDownX2
            // 
            this.numericUpDownX2.Location = new System.Drawing.Point(539, 179);
            this.numericUpDownX2.Name = "numericUpDownX2";
            this.numericUpDownX2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownX2.TabIndex = 1;
            this.numericUpDownX2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // x1
            // 
            this.x1.AutoSize = true;
            this.x1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.x1.Location = new System.Drawing.Point(501, 140);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(22, 17);
            this.x1.TabIndex = 2;
            this.x1.Text = "x1";
            // 
            // x2
            // 
            this.x2.AutoSize = true;
            this.x2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.x2.Location = new System.Drawing.Point(501, 182);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(22, 17);
            this.x2.TabIndex = 3;
            this.x2.Text = "x2";
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Location = new System.Drawing.Point(539, 237);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(75, 23);
            this.buttonOblicz.TabIndex = 4;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(44, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(406, 95);
            this.listBox1.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(199, 305);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(293, 20);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.numericUpDownX2);
            this.Controls.Add(this.numericUpDownX1);
            this.Name = "Form3";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownX1;
        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.Label x1;
        private System.Windows.Forms.Label x2;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

