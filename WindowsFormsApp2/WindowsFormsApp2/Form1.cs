using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void m_ValueChanged(object sender, EventArgs e)
        {

        }

        private void z_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double result_prost;
            double procent_prost;
            double result_trap;
            double procent_trap;
            List<double> wyniki_prost = new List<double>();
            List<double> wyniki_trap = new List<double>();
            Calkowanie calkowanie_prost = new MetodaProstokatow();
            Calkowanie calkowanie_trap = new MetodaTrapezow();
            int m = Convert.ToInt32(numericUpDownM.Value);
            int z = Convert.ToInt32(numericUpDownZ.Value);

            Kalkulator kalkulator = new Kalkulator(calkowanie_prost);
            for (int i = 0; i < m; i++)
            {
                result_prost = kalkulator.Calkowanie.oblicz();
                procent_prost = result_prost * 100 / kalkulator.Calkowanie.wynik;

                if (procent_prost >= 100)
                {
                    if ((procent_prost - 100) <= z)
                    {
                        wyniki_prost.Add(result_prost);
                    }
                }
                else
                {
                    if ((100 - procent_prost) <= z)
                    {
                        wyniki_prost.Add(result_prost);
                    }
                }
            }
            kalkulator = new Kalkulator(calkowanie_trap);
            for ( int i = 0; i < m; i++)
            {
                result_trap = kalkulator.Calkowanie.oblicz();
                procent_trap = result_trap * 100 / kalkulator.Calkowanie.wynik;

                if (procent_trap >= 100)
                {
                    if ((procent_trap - 100) <= z)
                    {
                        wyniki_trap.Add(result_trap);
                    }
                }
                else
                {
                    if ((100 - procent_trap) <= z)
                    {
                        wyniki_trap.Add(result_trap);
                    }
                }
            }
                
            listBox1.Items.Add("Metoda prostokątów: ");
            foreach (double wynik_prost in wyniki_prost)
            {
                listBox1.Items.Add(wynik_prost.ToString() + ", ");
            }
            listBox1.Items.Add("\nMetoda trapezów: ");
            foreach (double wynik_trap in wyniki_trap)
            {
                listBox1.Items.Add(wynik_trap.ToString() + ", ");
            }
        }

        private void numericUpDownM_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
