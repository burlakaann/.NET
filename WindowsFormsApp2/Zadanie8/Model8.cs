using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{

    class MetodaTrapezow : Calkowanie
    {
        public MetodaTrapezow() : base() { }
        public override double oblicz(int n)
        {
            double x = base.x_p;
            double szerokosc = (base.x_k - base.x_p) / (double)n;
            double suma = 0;
            double pole;
            for (int i = 0; i < n; i++)
            {
                double x_pom = x;
                x += szerokosc;
                suma += base.funkcja(x_pom) + base.funkcja(x);
            }
            pole = suma / 2 * szerokosc;
            return pole;
        }
    }

    class MetodaProstokatow : Calkowanie
    {
        public MetodaProstokatow() : base() { }
        public override double oblicz(int n)
        {
            double x = base.x_p;
            double suma = 0;
            double pole;
            double szerokosc = (base.x_k - base.x_p) / (double)n;
            for (int i = 0; i < n; i++)
            {
                suma += base.funkcja(x);
                x += szerokosc;
            }
            pole = suma * szerokosc;
            return pole;
        }
    }

    abstract class Calkowanie
    {
        public double wynik = 1;
        public double x_p = 0;
        public double x_k = Math.PI / 2;
        public int n;
        public Calkowanie() { }
        public abstract double oblicz(int n);
        public double funkcja(double x)
        {
            return Math.Cos(x);
        }
    }

    class Kalkulator
    {
        public Calkowanie Calkowanie { get; set; }
        public Kalkulator() { }
        public Kalkulator(Calkowanie calkowanie)
        {
            this.Calkowanie = calkowanie;
        }
    }


}
