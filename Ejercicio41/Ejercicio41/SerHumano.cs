using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class SerHumano
    {
        private string _nombre;
        private Single _peso;
        private Single _altura;
        private string _sexo;

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Sexo
        {
            get { return this._sexo; }
            set { this._sexo = value; }
        }

        public SerHumano(string nombre, string sexo)
        {
            this._nombre = nombre;
            this._sexo = sexo;
        }

        public SerHumano(Single peso, Single altura, string nombre, string sexo)
            : this(nombre, sexo)
        {
            this._peso = peso;
            this._altura = altura;

        }

        public string Comer()
        {
            string comida = "Pan";

            return "El Humano come " + comida;
        }

        public void Dormir()
        {
            Console.WriteLine("Duerme todos los dias");
        }

        public void Mostrar()
        {
            Console.WriteLine("NOMBRE: " + this._nombre + "\nSEXO: " + this._sexo);
        }
    }
}
