using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double area;

        public static double CalcularCuadrado(double lado)
        {
            area = Math.Pow(lado, 2);

            return area;
        }

        public static double CalcularTriangulo(double Base, double altura)
        {
            area = (Base * altura) / 2;

            return area;
        }

        public static double CalcularCirculo(double radio)
        {
            area = Math.PI * Math.Pow(radio, 2);

            return area;
        }
    }
}
