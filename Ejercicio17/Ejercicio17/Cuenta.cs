using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Cuenta
    {
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private ETipoInteres _tipoInteres;

        public string getNombre()
        {
            return "0";
        }

        public long getNroCuenta()
        {
            return 0;
        }

        public double getSaldo()
        {
            return 0;
        }

        public ETipoInteres getTipoInteres()
        {
            return 0;
        }

        public void setNombre(string nombre)
        {

        }

    }

    public enum ETipoInteres
    {
        TIN,
        TAE,
        TIR
    }
}
