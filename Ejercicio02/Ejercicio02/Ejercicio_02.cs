using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio_02
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            int numero;
            string dato;
            bool respuesta;

            do
            {
                Console.WriteLine("Ingresa un numero mayor a cero (0): ");
                dato = Console.ReadLine();
                

                while(int.TryParse(dato, out numero) == false)
                {
                    Console.WriteLine("Error, ingrese un numero valido: ");
                    
                    dato = Console.ReadLine();
                }


            } while (numero <= 0);

            double cuadrado = Math.Pow(numero, 2);//Devuelve el numero a la potencia espesificada ambos tipo de dato double
            double cubo = Math.Pow(numero, 3);

            Console.WriteLine("El Cuadrado del numero es {0} y el Cubo es {1}", cuadrado, cubo);

            Console.ReadKey();
        }
    }
}
