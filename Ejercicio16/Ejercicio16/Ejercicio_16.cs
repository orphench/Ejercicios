using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Ejercicio_16
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";

            byte notaUno = 0;
            byte notaDos = 0;

            Alumno alumno1 = new Alumno(001, "Fries", "Victor");
            //Alumno alumno2 = new Alumno(002, "Dent", "Harvey");
            //Alumno alumno3 = new Alumno(003, "Cobblepot", "Oswald");

            Console.WriteLine("Ingresa las notas: ");
            //alumno1.Estudiar(notaUno, notaDos);
            alumno1.Estudiar(notaUno = byte.Parse(Console.ReadLine()), notaDos = byte.Parse(Console.ReadLine()));

            alumno1.CalcularFinal();
            alumno1.Mostrar();

            Console.ReadKey();
        }
    }
}
