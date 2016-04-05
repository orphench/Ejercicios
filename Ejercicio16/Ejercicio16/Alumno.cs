using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notafinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public Alumno(int legajo, string apellido, string nombre)
        {
            this.legajo = legajo;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public void CalcularFinal()
        {
            if (_nota1 >= 4 && _nota2 >= 4)
            {
                Random notaFinalRandon = new Random();
                _notafinal = notaFinalRandon.Next(1, 10);
            }
            else
            {
                _notafinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            /*Console.WriteLine("Ingresa la nota uno: ");
            _nota1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la nota dos: ");
            _nota2 = byte.Parse(Console.ReadLine());*/
            _nota1 = notaUno;
            _nota2 = notaDos;
            
        }

        public void Mostrar()
        {
            if(_notafinal == -1)
            {
                Console.WriteLine("Legajo: {0} Nombre: {1} Apellido: {2} \nNota Uno: {3} Nota Dos: {4}", legajo, nombre, apellido, _nota1, _nota2);
            }
            else
            {
                Console.WriteLine("Legajo: {0} Nombre: {1} Apellido: {2} \nNota Uno: {3} Nota Dos: {4} Nota Final: {5}", legajo, nombre, apellido, _nota1, _nota2, _notafinal);
            }
            
        }
    }
}
