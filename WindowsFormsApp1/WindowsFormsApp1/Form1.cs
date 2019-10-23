using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void Zamknij_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Policz_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(numericUpDown1.Value);
            int b = Convert.ToInt32(numericUpDown2.Value);
            Kalkulator kalkulator = new Kalkulator();
            Dodawanie dodawanie = new Dodawanie();
            clObliczenia obliczenia = new clObliczenia();
            dodawanie = obliczenia.DodajLiczby(a, b);
            label1.Text = dodawanie.Result.ToString();
            listBox1.Items.Add("a= " + dodawanie.ValueA.ToString() + "b= " + dodawanie.ValueB.ToString() + "wynik = " + dodawanie.Result.ToString());
        }
    }
}
