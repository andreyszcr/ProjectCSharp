using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Operadores
    {
        int Numero1;
        int Numero2;
        int resultado;
        public Operadores()
        {
            Numero1 = 0;
            Numero2 = 0;
            resultado = 0;
        }
        




       public void Suma()
       {
            resultado=Numero1 + Numero2;
       }

        public void Resta()
        {
            resultado = Numero1 - Numero2;
        }

        public void Dividir()
        {
            resultado = Numero1 / Numero2;
        }

        public void Multiplicar()
        {
            resultado = Numero1 * Numero2;
        }


    }
}
