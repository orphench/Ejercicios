using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralTelefonica
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        public float GananciaPorLocal
        {
            get;
        }

        public float GananaciaPorProincial
        {
            get;
        }

        public float GananciaTotal
        {
            get;
        }

        public List<Llamada> Llamadas
        {
            get;
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Razon Social: " + this._razonSocial);
            sb.AppendLine("Ganancia Total: " + this.GananciaTotal);
            sb.AppendLine("Ganancia Local: " + this.GananciaPorLocal);
            sb.AppendLine("Ganancia Provincial: " + this.GananaciaPorProincial);
            Console.WriteLine(sb.ToString());

            foreach (Llamada item in _listaDeLlamadas)
            {
                if (item is Local)
                {
                    item.Mostrar();
                }
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {

        }
    }
}
