namespace Zadanie6
{
    partial class Form6
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
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownK
            // 
            this.numericUpDownK.Location = new System.Drawing.Point(569, 131);
            this.numericUpDownK.Name = "numericUpDownK";
            this.numericUpDownK.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownK.TabIndex = 0;
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(569, 180);
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(520, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "k";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(520, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "m";
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Location = new System.Drawing.Point(569, 248);
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
            this.listBox1.Location = new System.Drawing.Point(25, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(402, 303);
            this.listBox1.TabIndex = 5;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownM);
            this.Controls.Add(this.numericUpDownK);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownK;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.ListBox listBox1;
    }
}

