using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Dodawanie
    {
        public int ValueA { get; set; }
        public int ValueB { get; set; }
        public int Result { get; set; }
        public Dodawanie() { }
        public Dodawanie(int valueA, int valueB, int result)
        {
            this.ValueA = valueA;
            this.ValueB = valueB;
            this.Result = result;

        }
    }

    class Kalkulator
    {
        public Dodawanie Dodawanie{ get; set; }
        public Kalkulator() { }
        public Kalkulator(Dodawanie dodawanie)
        {
            this.Dodawanie = dodawanie;
        }
    }


}
