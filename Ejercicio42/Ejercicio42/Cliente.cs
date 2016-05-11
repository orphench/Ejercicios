using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class Cliente
    {
        private string _apellido;
        private int _cuentaBancaria;
        private double _cuit;
        private int _edad;
        private string _nombre;

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public int Edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }

        public double Cuit
        {
            get { return this._cuit; }
            set { this._cuit = value; }
        }

        public int Cuenta
        {
            get { return this._cuentaBancaria; }
        }

        public Cliente(string apellido, string nombre, int cuenta)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._cuentaBancaria = cuenta;
        }
    }
}
