using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie6
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Calkowanie calkowanie_prost = new MetodaProstokatow();
            Calkowanie calkowanie_trap = new MetodaTrapezow();
            Kalkulator kalkulator;

            int k = Convert.ToInt32(numericUpDownK.Value);
            int m = Convert.ToInt32(numericUpDownM.Value);

            double res_trap1, res_prost1, res_trap2, res_prost2;

            double min_res_prost = 1000000000;
            double min_res_trap = 1000000000;

            double wynik_prost1 =0, wynik_prost2=0, wynik_trap1=0, wynik_trap2=0;

            double min_x1, min_x2;
            double x1, x2;
            Random rnd = new Random();
            double n = Math.Pow(10, k);

            for ( int i = 0; i < m; i++)
            {
                x1 = rnd.Next(0, 50);
                x2 = rnd.Next(50, 100);

                kalkulator = new Kalkulator(calkowanie_prost);
                res_prost1 = kalkulator.Calkowanie.oblicz(1, n, x1, x2);
                kalkulator = new Kalkulator(calkowanie_trap);
                res_trap1 = kalkulator.Calkowanie.oblicz(1, n, x1, x2);
                x1 = rnd.Next(0, 50);
                x2 = rnd.Next(50, 100);
                kalkulator = new Kalkulator(calkowanie_prost);
                res_prost2 = kalkulator.Calkowanie.oblicz(2, n, x1, x2);
                kalkulator = new Kalkulator(calkowanie_trap);
                res_trap2 = kalkulator.Calkowanie.oblicz(2, n, x1, x2);
                if (res_prost1 >= res_prost2)
                {
                    if ( min_res_prost > (res_prost1 - res_prost2))
                    {
                        min_res_prost = (res_prost1 - res_prost2);
                        wynik_prost1 = res_prost1;
                        wynik_prost2 = res_prost2;
                    }
                }
                else
                {
                    if( min_res_prost > (res_prost2 - res_prost1))
                    {
                        min_res_prost = (res_prost2 - res_prost1);
                        wynik_prost1 = res_prost1;
                        wynik_prost2 = res_prost2;
                    }
                    
                }

                if (res_trap1 >= res_trap2)
                {
                    if (min_res_trap > (res_trap1 - res_trap2))
                    {
                        min_res_trap = (res_trap1 - res_trap2);
                        wynik_trap1 = res_trap1;
                        wynik_trap2 = res_trap2;
                    }
                }
                else
                {
                    if (min_res_trap > (res_trap2 - res_trap1))
                    {
                        min_res_trap = (res_trap2 - res_trap1);
                        wynik_trap1 = res_trap1;
                        wynik_trap2 = res_trap2;
                    }
                }
            }
            listBox1.Items.Add("Metoda prostokatow");
            listBox1.Items.Add("Wyniki o najmiejszej różnicy");
            listBox1.Items.Add("f(x)=x^2: "+wynik_prost1);
            listBox1.Items.Add("f(x)=x^3: " + wynik_prost2);
            listBox1.Items.Add("Metoda trapezów");
            listBox1.Items.Add("Wyniki o najmiejszej różnicy");
            listBox1.Items.Add("f(x)=x^2: " + wynik_trap1);
            listBox1.Items.Add("f(x)=x^3: " + wynik_trap2);
        }
    }
}
