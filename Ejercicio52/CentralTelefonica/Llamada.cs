using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralTelefonica
{
    class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion
        {
            get { return this._duracion; }
        }

        public string NroDestino
        {
            get { return this._nroDestino; }
        }

        public string NroOrigen
        {
            get { return this._nroOrigen; }
        }
       
        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
        {

            return 0;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nro. de Origen: " + this._nroOrigen);
            sb.AppendLine("Nro. de Destino: " + this._nroDestino);
            sb.AppendLine("Duracion de Llamada: " + this._duracion);
            Console.WriteLine(sb.ToString());
        }

    }
}
