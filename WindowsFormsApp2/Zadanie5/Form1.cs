using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void oblicz_prost(int k)
        {

            int x1_f1 = 0;
            int x2_f1 = 100;

            double x1_f2 = 0;
            double x2_f2 = 0;
            double step = 100;
            int diff;

            double result_prost_f1;
            double result_prost_f2;
            Calkowanie calkowanie_prost = new MetodaProstokatow();
            double n = Math.Pow(10, k);
            Kalkulator kalkulator = new Kalkulator(calkowanie_prost);


            result_prost_f1 = kalkulator.Calkowanie.oblicz(1, n, x1_f1, x2_f1);
            while (true)
            {
                result_prost_f2 = kalkulator.Calkowanie.oblicz(2, n, x1_f2, x2_f2);
                diff = ((int)result_prost_f1 - (int)result_prost_f2);
                if (diff < 0)
                {
                    x2_f2 += step;
                }
                else if (diff > 0)
                {
                    x2_f2 -= step;
                    step /= 2;
                }
                else
                {
                    listBox1.Items.Add("Dla x1_f1 = 0, x2_f1 = 100 i x1_f2 = " + x1_f2 + " , x2_f2 = " + x2_f2 + " wartości całek obliczonych metodą prostokątów są równe");
                    break;
                }

            }
        }
        private void oblicz_trap(int k)
        {

            int x1_f1 = 0;
            int x2_f1 = 100;

            double x1_f2 = 0;
            double x2_f2 = 0;
            double step = 100;
            int diff;

            double result_trap_f1;
            double result_trap_f2;
            Calkowanie calkowanie_trap = new MetodaTrapezow();
            double n = Math.Pow(10, k);
            Kalkulator kalkulator = new Kalkulator(calkowanie_trap);


            result_trap_f1 = kalkulator.Calkowanie.oblicz(1, n, x1_f1, x2_f1);
            while (true)
            {
                result_trap_f2 = kalkulator.Calkowanie.oblicz(2, n, x1_f2, x2_f2);
                diff = ((int)result_trap_f1 - (int)result_trap_f2);
                if (diff < 0)
                {
                    x2_f2 += step;
                }
                else if (diff > 0)
                {
                    x2_f2 -= step;
                    step /= 2;
                }
                else
                {
                    listBox1.Items.Add("Dla x1_f1 = 0, x2_f1 = 100 i x1_f2 = " + x1_f2 + " , x2_f2 = " + x2_f2 + " wartości całek oliczonych metodą trapezów są równe");
                    break;
                }
            }
        }
            

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            
            int k = Convert.ToInt32(numericUpDownK.Value);

            oblicz_prost(k);
            oblicz_trap(k);

        }
    }
}
