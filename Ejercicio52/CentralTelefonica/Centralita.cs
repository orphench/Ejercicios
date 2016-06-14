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
            get { return CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananaciaPorProincial
        {
            get { return CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciaTotal
        {
            get { return CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this._listaDeLlamadas; }
        }

        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string razonSocial):this()
        {
            this._razonSocial = razonSocial;
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
                if ((item is Local) || (item is Provincial))
                {
                    item.Mostrar();
                }
            }
        }

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float total = 0;

            if (tipo == TipoLlamada.Todas)
            {
                for (int i = 0; i < this._listaDeLlamadas.Count; i++)
                {
                    if (this._listaDeLlamadas[i] is Local)
                    {
                        total += ((Local)this._listaDeLlamadas[i]).CostoLlamada;
                    }
                    else
                    {
                        total += ((Provincial)this._listaDeLlamadas[i]).CostoLlamada;
                    }
                }
            }

            else
            {
                for (int i = 0; i < this._listaDeLlamadas.Count; i++)
                {
                    if ((this._listaDeLlamadas[i] is Local) && (tipo == TipoLlamada.Local))
                    {
                        total += ((Local)this._listaDeLlamadas[i]).CostoLlamada;
                    }
                    if ((this._listaDeLlamadas[i] is Provincial) && (tipo == TipoLlamada.Provincial))
                    {
                        total += ((Provincial)this._listaDeLlamadas[i]).CostoLlamada;
                    }
                }
            }

            return total;
        }
    }
}
