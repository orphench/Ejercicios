using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Ejercicio_11
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";

            int numero;
            bool resp;
            int max = 0;
            int min = 0;
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    resp = Validacion.Validar(100, -100, numero);

                } while (resp != true);

                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else
                {
                    if(numero > max)
                    {
                        max = numero;
                    }
                    if (numero < min)
                    {
                        min = numero;
                    }
                }

                suma = suma + numero;
            }

            float promedio = (float)suma / 10;

            Console.WriteLine("Numero maximo: {0} Numero minimo: {1} Promedio: {2}", max, min, promedio);
            Console.ReadKey();
        }
    }
}
