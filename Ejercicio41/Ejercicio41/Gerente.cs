using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Gerente:SerHumano
    {
        private float _sueldoG;

        public float SueldoG
        {
            get { return this._sueldoG; }
            set { this._sueldoG = value; }
        }

        public Gerente(string nombre, string sexo, float sueldo):base(nombre, sexo)
        {
            this._sueldoG = sueldo;
        }

        public Gerente(SerHumano gerenteACargo, float sueldo)
            :base(gerenteACargo.Nombre, gerenteACargo.Sexo)
        {
            this._sueldoG = sueldo;
        }

        //public float GetSueldo(float sueldo)
        //{

        //    return sueldo;
        //}

        public void DatosGerente()
        {
            this.Mostrar();
            Console.WriteLine(this._sueldoG);
        }
    }
}
