namespace Zadanie5
{
    partial class Form5
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
            this.numericUpDownK = new System.Windows.Forms.NumericUpDown();
            this.K = new System.Windows.Forms.Label();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.Location = new System.Drawing.Point(460, 153);
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownK.TabIndex = 0;
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.K.Location = new System.Drawing.Point(412, 156);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(17, 17);
            this.K.TabIndex = 1;
            this.K.Text = "K";
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Location = new System.Drawing.Point(460, 212);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(75, 23);
            this.buttonOblicz.TabIndex = 2;
            this.buttonOblicz.Text = "Oblicz";
            this.buttonOblicz.UseVisualStyleBackColor = true;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(589, 95);
            this.listBox1.TabIndex = 3;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.K);
            this.Controls.Add(this.numericUpDownK);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.Label K;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.ListBox listBox1;
    }
}

