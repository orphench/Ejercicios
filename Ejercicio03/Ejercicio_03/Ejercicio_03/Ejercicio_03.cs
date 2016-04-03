using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Ejercicio_03
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";

            int numero;
            int denominador = 2;
            string dato;

            Console.WriteLine("Ingresa un numero: ");
            dato = Console.ReadLine();

            while(int.TryParse(dato, out numero)==false)
            {
                Console.WriteLine("Error, ingrese un numero valido: ");
                dato = Console.ReadLine();

            }

            while (1 <= numero)//Miestras que el numero ingresado sea mayor o igual a 1 seguira iterando
            {
                if(numero % denominador == 0)//evalua si el modulo es igual a cero, el primer valor del denominador sera 2, no tendria sentido empezar con 0 o 1
                {
                    if(numero == denominador)//cuando el numero sea igual al denominador muestra los numero primos hasta el numero ingresado 
                    {

                        Console.WriteLine(numero + ", ");            
                    }
                    numero--;//reduce el numero ingresado para evaluar si el anterior es primo
                    denominador = 2;//le reasigna el valor a 2 para volver a evaluar el modulo desde el inicio
                }

                else
                {
                    denominador++;//si el modulo no es 0 incrementa el denominador para lograr igualarlo al numero ingresado
                }
            }

            Console.ReadKey();
        }
    }
}
