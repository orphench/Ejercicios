using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
            {
            bool continuar = true;
            string opcion = "";

            ManejadorDeContactos manejador = new ManejadorDeContactos();

            //List<Contacto> contactos = manejador.ObtenerContactos();
            //manejador.contactos = ManejadorDeContactos.CargarListaDePersonas(); //CARGAR PRIMERO LA LISTA PARA NO INICIAR CON UNA LISTA VACIA
            //ManejadorDeContactos.CargarListaDePersonas();
            

            while (continuar)
            {
                Console.WriteLine("1.- Agregar contacto ");
                Console.WriteLine("2.- Ver contactos ");
                Console.WriteLine("3.- Salir ");
                Console.Write("Ingrese una opcion: ");
                opcion = Console.ReadLine();
                Console.Clear();

                switch (opcion)
                {
                    case "1":
                        Contacto persona = new Contacto();
                        Console.Write("Ingrese el nombre del contacto: ");
                        persona.nombre = Console.ReadLine();
                        Console.Write("Ingrese el apellido del contacto: ");
                        persona.apellido = Console.ReadLine();
                        Console.Write("Ingrese el telefono del contacto: ");
                        persona.telefono = Console.ReadLine();                        
                        
                        manejador.contactos = ManejadorDeContactos.CargarListaDePersonas(); //CARGAR PRIMERO LA LISTA PARA NO INICIAR CON UNA LISTA VACIA
                        //manejador.contactos.Add(persona);
                        manejador.AgregarContactos(persona);
                        ManejadorDeContactos.GuardarListaDePersonas(manejador.contactos);

                        Console.Clear();
                                               
                        break;
                    case "2":
                       
                        manejador.contactos = ManejadorDeContactos.CargarListaDePersonas();
                        
                        Console.WriteLine("Contactos Agregados");
                        Console.WriteLine("Nombre \t\t Apellido \t\t Telefono");
                        //try
                        //{
                            foreach (Contacto item in manejador.contactos)
                            {
                                Console.WriteLine("{0} \t\t {1} \t\t {2}", item.nombre, item.apellido, item.telefono);
                            }
                        //}
                        //catch (Exception ex)
                        //{

                        //    Console.WriteLine("No hay datos para mostrar");
                        //}

                        

                        Console.ReadKey();
                        Console.Clear();

                        break;

                    case "3":
                        Console.WriteLine("Adios");
                        continuar = false;
                        Console.ReadKey();
                        break;

                    default:                       
                        Console.WriteLine("Ingrese una opcion valida: ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            }
        }
    }
}
