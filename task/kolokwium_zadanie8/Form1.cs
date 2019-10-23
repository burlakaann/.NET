using System;
using System.Windows.Forms;

namespace kolokwium_zadanie8
{
    public partial class Form1 : Form
    {
        public Form1()
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

            if (z == 0)
            {
                listBox1.Items.Add("Nie znaleziono takich n. Podaj inną wartość z");
                return;
            }
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
