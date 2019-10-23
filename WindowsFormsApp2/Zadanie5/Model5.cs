using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie5
{

    class MetodaTrapezow : Calkowanie
    {
        public MetodaTrapezow() : base() { }
        public override double oblicz(int f, double n, double x_p, double x_k)
        {
            double x = x_p;
            double szerokosc = (x_k - x_p) / n;
            double suma = 0;
            double pole;
            if (f == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    double x_pom = x;
                    x += szerokosc;
                    suma += base.funkcja1(x_pom) + base.funkcja1(x);
                }
            }
            else if (f == 2)
            {
                for (int i = 0; i < n; i++)
                {
                    double x_pom = x;
                    x += szerokosc;
                    suma += base.funkcja2(x_pom) + base.funkcja2(x);
                }
            }
            
            pole = suma / 2 * szerokosc;
            return pole;
        }
    }

    class MetodaProstokatow : Calkowanie
    {
        public MetodaProstokatow() : base() { }
        public override double oblicz(int f, double n, double x_p, double x_k)
        {
            double x = x_p;
            double suma = 0;
            double pole;
            double szerokosc = (x_k - x_p) / n;
            if(f == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    suma += base.funkcja1(x);
                    x += szerokosc;
                }
            }
            else if(f ==2)
            {
                for (int i = 0; i < n; i++)
                {
                    suma += base.funkcja2(x);
                    x += szerokosc;
                }
            }
            
            pole = suma * szerokosc;
            return pole;
        }
    }

    abstract class Calkowanie
    {

        public int n;
        public Calkowanie() { }
        public abstract double oblicz(int f, double n, double x_p, double x_k);
        public double funkcja2(double x)
        {
            return x * x * x;
        }
        public double funkcja1(double x)
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

