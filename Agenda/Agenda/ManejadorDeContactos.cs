using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Agenda
{
    public class ManejadorDeContactos
    {
        //public List<Contacto> contactos = new List<Contacto>();
        public List<Contacto> contactos;

        public ManejadorDeContactos()
        {
            this.contactos = new List<Contacto>();
        }

        public void AgregarContactos(Contacto persona)
        {
            contactos.Add(persona);
        }

        //public List<Contacto> ObtenerContactos()
        //{
        //    return this.contactos;
        //}



        public static bool GuardarListaDePersonas(List<Contacto> listaDePersonas)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Agenda.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Contacto>));
                    serializador.Serialize(escritor, listaDePersonas);
                }
            }
            catch (Exception ex)
            {

                return false;
            }

            return true;
        }

        public static List<Contacto> CargarListaDePersonas()
        {
            List<Contacto> aux = null;

            try
            {
                using (XmlTextReader lector = new XmlTextReader("Agenda.xml"))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Contacto>));
                    aux = (List<Contacto>)serializador.Deserialize(lector);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("La agenda esta vacia");
                Console.ReadKey();
                Console.Clear();
                aux = new List<Contacto>();
            }

            return aux;
        }

        
    }
}
