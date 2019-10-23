using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double result_prost;
            double result_trap;
            double n;
            
            Calkowanie calkowanie_prost = new MetodaProstokatow();
            Calkowanie calkowanie_trap = new MetodaTrapezow();

            int x1 = Convert.ToInt32(numericUpDownX1.Value);
            int x2 = Convert.ToInt32(numericUpDownX2.Value);
            int k = Convert.ToInt32(numericUpDownK.Value);
            int z = Convert.ToInt32(numericUpDownZ.Value);
            Kalkulator kalkulator;

            n = Math.Pow(10, k);
            kalkulator = new Kalkulator(calkowanie_prost);
            result_prost = kalkulator.Calkowanie.oblicz(n, x1, x2);
            kalkulator = new Kalkulator(calkowanie_trap);
            result_trap = kalkulator.Calkowanie.oblicz(n, x1, x2);
            
            if ( (int)result_prost % z == 0 && (int)result_trap % z == 0)
            {
                listBox1.Items.Add("Dla x1 = " + x1 + " i x2 = " + x2 + " część całkowita wartości całki jest podzielna przez liczbę " + z);
            }
            else
            {
                listBox1.Items.Add("Dla x1 = " + x1 + " i x2 = " + x2 + " część całkowita wartości całki NIE jest podzielna przez liczbę " + z);
                listBox1.Items.Add("Podaj inne wartości x1 i x2");
            }
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
