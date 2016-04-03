using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {
        public static bool Validar(int maximo, int minimo, int numero)
        {
           
            if (numero > maximo || numero < minimo)
            {
                return false;
            }

            else
            {
                return true;
            }
            
        }

    }
}
