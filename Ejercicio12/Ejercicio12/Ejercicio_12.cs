using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class Ejercicio_12
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";

            int numero;
            int suma = 0;
            bool resp = false;

            
            do
            {
                Console.WriteLine("Ingrese un numero a sumar: ");
                numero = int.Parse(Console.ReadLine());

                suma = numero + suma;
                Console.Clear();

                Console.WriteLine("Desea continuar? Ingrese S o N: ");
                ValidarRespuesta.respuesta = Convert.ToChar(Console.ReadLine());
                resp = ValidarRespuesta.ValidarS_N();
                Console.Clear();
            } while (resp == true);

            Console.WriteLine("La suma de los numeros ingresados es: {0}", suma);
            Console.ReadKey();
        }
    }
}
