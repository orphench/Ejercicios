using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {
        public static char respuesta;

        public static bool ValidarS_N()
        {
            

            while ( respuesta != 'S' && respuesta != 'N')
            {
                Console.Clear();
                Console.WriteLine("Error, Ingrese S o N: ");
                respuesta = Convert.ToChar(Console.ReadLine());

            }

            if (respuesta == 'S')
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
