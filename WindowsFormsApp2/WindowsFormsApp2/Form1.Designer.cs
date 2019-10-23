namespace WindowsFormsApp2
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
            this.numericUpDownM = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownZ = new System.Windows.Forms.NumericUpDown();
            this.labelM = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownM
            // 
            this.numericUpDownM.Location = new System.Drawing.Point(424, 94);
            this.numericUpDownM.Name = "numericUpDownM";
            this.numericUpDownM.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownM.TabIndex = 0;
            this.numericUpDownM.ValueChanged += new System.EventHandler(this.numericUpDownM_ValueChanged);
            // 
            // numericUpDownZ
            // 
            this.numericUpDownZ.Location = new System.Drawing.Point(424, 153);
            this.numericUpDownZ.Name = "numericUpDownZ";
            this.numericUpDownZ.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownZ.TabIndex = 1;
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Location = new System.Drawing.Point(315, 94);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(86, 13);
            this.labelM.TabIndex = 2;
            this.labelM.Text = "Wybierz liczbe m";
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.Location = new System.Drawing.Point(318, 159);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(83, 13);
            this.labelZ.TabIndex = 3;
            this.labelZ.Text = "Wybierz liczbe z";
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.Location = new System.Drawing.Point(644, 124);
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
            this.listBox1.Location = new System.Drawing.Point(64, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 199);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(878, 322);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.numericUpDownZ);
            this.Controls.Add(this.numericUpDownM);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown m;
        private System.Windows.Forms.TextBox text_m;
        private System.Windows.Forms.NumericUpDown z;
        private System.Windows.Forms.TextBox text_z;
        private System.Windows.Forms.NumericUpDown liczbaM;
        private System.Windows.Forms.NumericUpDown liczbaZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Oblicz;
        private System.Windows.Forms.ListBox Wyniki;
        private System.Windows.Forms.NumericUpDown numericUpDownM;
        private System.Windows.Forms.NumericUpDown numericUpDownZ;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.ListBox listBox1;
    }
}

