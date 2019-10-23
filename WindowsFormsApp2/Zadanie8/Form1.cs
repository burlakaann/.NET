using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie8
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double result_prost;
            double procent_prost;
            double result_trap;
            double procent_trap;
            Calkowanie calkowanie_prost = new MetodaProstokatow();
            Calkowanie calkowanie_trap = new MetodaTrapezow();
            int z = Convert.ToInt32(numericUpDownZ.Value);
            int n = 1;
            int wynik;
            Kalkulator kalkulator;
            while (true)
            {
                kalkulator = new Kalkulator(calkowanie_prost);
                result_prost = kalkulator.Calkowanie.oblicz(n);
                procent_prost = result_prost * 100 / kalkulator.Calkowanie.wynik;
                kalkulator = new Kalkulator(calkowanie_trap);
                result_trap = kalkulator.Calkowanie.oblicz(n);
                procent_trap = result_trap * 100 / kalkulator.Calkowanie.wynik;

                if (procent_prost >= 100)
                {

                    if ((procent_prost - 100) <= z)
                    {
                        if ((procent_trap >= 100 && (procent_trap - 100) <= z) ||
                            (procent_trap < 100) && (100 - procent_trap <= z))
                        {
                            wynik = n;
                            break;
                        }
                    }
                }
                else
                {
                    if ((100 - procent_prost) <= z)
                    {
                        if ((procent_trap >= 100 && (procent_trap - 100) <= z) ||
                            (procent_trap < 100) && (100 - procent_trap <= z))
                        {
                            wynik = n;
                            break;
                        }
                    }
                }
                n++;
            }
            listBox1.Items.Add("Minimalna wartość n spełniająca warunki zadania to: " + wynik.ToString());
        }
    }
}