using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CentralTelefonica
{
    class Local:Llamada
    {
        protected float _costo;

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public Local(string origen, string destino, float duracion, float costo) : base(origen, destino, duracion)
        {
            this._costo = costo;
        }

        public Local(Llamada unaLlamada, float costo):base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            this._costo = costo;
        }
        
        public void Mostrar()
        {
            base.Mostrar();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Costo de Llamada: " + this._costo);
            Console.WriteLine(sb.ToString());
        }

        private float CalcularCosto()
        {
            float valorDeLlamada = 0;

            valorDeLlamada = this.Duracion * this._costo;

            return valorDeLlamada;
        }

        
    }
}
