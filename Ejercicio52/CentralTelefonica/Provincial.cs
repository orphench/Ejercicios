using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralTelefonica
{
    class Provincial:Llamada
    {
        protected Franja _franjaHoraria;

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public Provincial(Franja miFranja, Llamada unaLlamada):base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino):this(miFranja, new Llamada(origen, destino, duracion))
        { }

        private float CalcularCosto()
        {
            float costoProvincial = 0;

            switch (_franjaHoraria)
            {
                case Franja.Franja_1:
                    costoProvincial = 0.99f * this.Duracion;
                    break;
                case Franja.Franja_2:
                    costoProvincial = 1.25f * this.Duracion;
                    break;
                case Franja.Franja_3:
                    costoProvincial = 0.66f * this.Duracion;
                    break;
                default:
                    break;
            }

            return costoProvincial;
        }

        public void Mostrar()
        {
            base.Mostrar();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Franja Horaria: " + this._franjaHoraria);
            sb.AppendLine("Costo de Llamada: " + this.CostoLlamada);
            Console.WriteLine(sb.ToString());
        }
    }
}
