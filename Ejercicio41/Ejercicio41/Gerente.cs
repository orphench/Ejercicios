using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Gerente:SerHumano
    {
        private float _sueldo;

        public Gerente(string nombre, string sexo, float sueldo):base(nombre, sexo)
        {
            this._sueldo = sueldo;
        }
    }
}
