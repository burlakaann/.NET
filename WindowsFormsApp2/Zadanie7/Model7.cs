using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{

    class MetodaTrapezow : Calkowanie
    {
        public MetodaTrapezow() : base() { }
        public override double oblicz(double n, int x_p, int x_k)
        {
            double x = x_p;
            double szerokosc = (x_k - x_p) / n;
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
        public override double oblicz(double n, int x_p, int x_k)
        {
            double x = x_p;
            double suma = 0;
            double pole;
            double szerokosc = (x_k - x_p) / n;
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
        public double wynik = 1000000 / 3;
        public int n;
        public Calkowanie() { }
        public abstract double oblicz(double n, int x_p, int x_k);
        public double funkcja(double x)
        {
            return x * x;
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

