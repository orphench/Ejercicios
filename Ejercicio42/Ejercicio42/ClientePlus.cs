using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class ClientePlus:Cliente
    {
        private int _puntos;

        public int Putos
        {
            get { return this._puntos; }
            set { this._puntos = value; }
        }

        public ClientePlus(string apellido, string nombre, int cuenta, int puntos):base(apellido,nombre,cuenta)
        {
            this._puntos = puntos;
        }
    }
}
