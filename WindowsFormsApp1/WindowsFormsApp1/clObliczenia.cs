using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class clObliczenia
    {
        public Dodawanie DodajLiczby(int a, int b)
        {
            int result = a + b;
            return new Dodawanie(a, b, result);
        }
    }
}
