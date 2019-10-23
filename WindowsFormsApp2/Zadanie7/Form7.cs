using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie7
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double result_prost;
            double result_trap;
            double n = 1;

            Calkowanie calkowanie_prost = new MetodaProstokatow();
            Calkowanie calkowanie_trap = new MetodaTrapezow();

            int x1 = Convert.ToInt32(numericUpDownX1.Value);
            int x2 = Convert.ToInt32(numericUpDownX2.Value);
            int z = Convert.ToInt32(numericUpDownZ.Value);
            Kalkulator kalkulator;
            while (true)
            {
                kalkulator = new Kalkulator(calkowanie_prost);
                result_prost = kalkulator.Calkowanie.oblicz(n, x1, x2);
                kalkulator = new Kalkulator(calkowanie_trap);
                result_trap = kalkulator.Calkowanie.oblicz(n, x1, x2);
                if ((int)result_prost % z == 0 && (int)result_trap % z == 0)
                {
                    listBox1.Items.Add("Dla n = " +n+" część całkowita wartości całki jest podzielna przez liczbę "+z);
                    break;
                }
                else
                {
                    n++;
                }
            }

        }
    }
}
