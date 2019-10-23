using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{

    class MetodaTrapezow : Calkowanie
    {
        public MetodaTrapezow() : base() {}
        public override double oblicz()
        {
            double x = base.x_p;
            double n = base.Random_N();
            double szerokosc = (base.x_k - base.x_p) / n;
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
        public MetodaProstokatow() : base() {}
        public override double oblicz()
        {
            double x = base.x_p;
            double suma = 0;
            double pole;
            double n = base.Random_N();
            double szerokosc = (base.x_k - base.x_p) / n;
            for( int i = 0; i < n; i++)
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
        public int x_p = 0;
        public int x_k = 100;
        public int n;
        public Calkowanie() {}
        public abstract double oblicz();
        public double funkcja(double x)
        {
            return x * x;
        }
        public int Random_N()
        {
            Random rnd = new Random();

            double n_p = Math.Pow(10, 1);
            double n_k = Math.Pow(10, 5);
            n = rnd.Next((int)n_p, (int)n_k);
            return n;
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
