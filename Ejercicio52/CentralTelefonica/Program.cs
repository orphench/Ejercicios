using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralTelefonica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CentralitaHerencia";

            Llamada unaLlamada = new Llamada("ONCE", "PALERMO", 2);
            Local unallamadaLocal = new Local(unaLlamada, 4);
            unallamadaLocal.Mostrar();
            

            Console.ReadKey();
        }
    }
}
