using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            maskedTextBox1.Clear();
            double result_prost;
            double result_trap;
            double n;
            double suma_prost = 0;
            double suma_trap = 0;
            int x1, x2;
            Control control = new Control();
            Calkowanie calkowanie_prost = new MetodaProstokatow();
            Calkowanie calkowanie_trap = new MetodaTrapezow();
            if (Convert.ToInt32(numericUpDownX1.Value) == 0 && Convert.ToInt32(numericUpDownX2.Value) == 100)
            {
                x1 = Convert.ToInt32(numericUpDownX1.Value);
                x2 = Convert.ToInt32(numericUpDownX2.Value);
            }
            else
            {
                maskedTextBox1.AppendText("Wprowadzono błędną wartość x1 lub x2");
                return;
            }
            
            Kalkulator kalkulator;
            for (int i = 1; i < 7; i++)
            {
                n = Math.Pow(10, i);
                kalkulator = new Kalkulator(calkowanie_prost);
                result_prost = kalkulator.Calkowanie.oblicz(n, x1, x2);
                kalkulator = new Kalkulator(calkowanie_trap);
                result_trap = kalkulator.Calkowanie.oblicz(n, x1, x2);

                suma_prost += Math.Pow((kalkulator.Calkowanie.wynik - result_prost), 2);
                suma_trap += Math.Pow((kalkulator.Calkowanie.wynik - result_trap), 2);
            }
            listBox1.Items.Add("Błąd średniokwadratowy dla metody prostokątów wynosi: " + suma_prost / 6);
            listBox1.Items.Add("Błąd średniokwadratowy dla metody trapezów wynosi: " + suma_trap / 6);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }
    }
}
