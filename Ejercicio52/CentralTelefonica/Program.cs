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

            Centralita centralitaUno = new Centralita("Telefonica");

            Local llamadaUno = new Local("Once", "Palermo", 30, 2.65f);
            Provincial llamadaDos = new Provincial("Once", Franja.Franja_1, 21, "Misiones");
            Local llamadaTres = new Local("Once", "Belgrano", 45, 1.99f);
            Provincial llamadaCuatro = new Provincial(Franja.Franja_3, llamadaDos);

            centralitaUno.Llamadas.Add(llamadaUno);
            centralitaUno.Llamadas.Add(llamadaDos);
            centralitaUno.Llamadas.Add(llamadaTres);
            centralitaUno.Llamadas.Add(llamadaCuatro);

            centralitaUno.Mostrar();

            //centralitaUno
            

            Console.ReadKey();
        }
    }
}
