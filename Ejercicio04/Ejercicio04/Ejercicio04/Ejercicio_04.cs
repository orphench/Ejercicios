using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicico Nro 04";

            double numero = 2;
            double denominador = 1;
            int count = 0;
            double suma = 0;

            while (count < 2)
            {
                for (int i = 0; i < numero - 1; i++)
                {

                    if(numero % denominador == 0)
                    {
                        suma = suma + denominador;
                        denominador++;


                    }

                    else
                    {
                        denominador++;
                    }
                }


                
                

                if (suma == numero)
                {
                    
                        Console.WriteLine(numero + "");
                        numero++;
                        denominador = 1;
                        suma = 0;
                        count++;
                    
                    
                }

                if (suma > numero)
                {
                    numero++;
                    denominador = 1;
                    suma = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
