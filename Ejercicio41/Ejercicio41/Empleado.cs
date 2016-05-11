using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Empleado:SerHumano
    {
        private float _sueldo;

        public Empleado(string nombre, string sexo, float sueldo):base(nombre, sexo)
        {
            this._sueldo = sueldo;
        }

    }
}
