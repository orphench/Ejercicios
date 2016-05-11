using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Program
    {
        static void Main(string[] args)
        {
            SerHumano unSerHumano = new SerHumano("Carlos", "M");
            SerHumano serHumanoDos = new SerHumano("Juliana", "F");

            Gerente unGerente = new Gerente("Raul", "M", 500);
            //Empleado unEmpleado = new Empleado("Camila", "F", 800);

            Empleado empleadoDos = new Empleado(unSerHumano, 900);
            Gerente gerenteDos = new Gerente(serHumanoDos, 1000);

            Empleado empleadoTres = new Empleado(serHumanoDos, 800, 8);

            //unEmpleado.Trabajar();
            //unSerHumano.Mostrar();
            empleadoDos.MostrarEmpleado();
            gerenteDos.Mostrar();

            //polimorfismo: tomar implementacion en tiempo de ejecucion

            Console.ReadKey();
        }
    }
}
