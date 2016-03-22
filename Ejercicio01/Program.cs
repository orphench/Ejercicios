using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string dato;
            int max = 0;
            int min = 0;
            int suma = 0;
            float promedio = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingresa cinco numeros: ");
                dato = Console.ReadLine();

                while(int.TryParse(dato, out numero) == false)
                {

                    Console.WriteLine("ERROR, reingrese: ");
                    dato = Console.ReadLine();
                }

                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else
                {
                    if (numero > max)
                    {
                        max = numero;

                    }
                    if(numero < min)
                    {
                        min = numero;
                    }

                }

                suma = numero + suma;
                  
            }

            promedio = suma / 5;

            Console.WriteLine("El numero maximo es: {0} El numero minimo es: {1} y el promedio es: {2}", max, min, promedio);
            Console.ReadKey();

        }
    }
}
