using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio41
{
    class Empleado:SerHumano
    {
        private float _sueldoE;
        private int _horasTrabajo;

        public Empleado(SerHumano empleadoTrabajando, float sueldo)
            :base(empleadoTrabajando.Nombre, empleadoTrabajando.Sexo)
        {
            this._sueldoE = sueldo;
        }

        public Empleado(SerHumano empleadoTrabajando, float sueldo, int horasTrabajo):this(empleadoTrabajando, sueldo)
        {
            this._horasTrabajo = horasTrabajo;
        }

        public float SueldoE
        {
            get { return this._sueldoE; }
            set { this._sueldoE = value; }
        }

        public int HorasDeTrabajo
        {
            get { return this._horasTrabajo; }
            set { this._horasTrabajo = value; }

        }

        public void Trabajar()
        {
            if (this._sueldoE < 500)
            {
                Console.WriteLine("El empleado gana poco");
            }

            else
            {
                Console.WriteLine("El empleado gana mas");
            }
                    
        }

        public float SueldoMensual(float sueldo, int horas)
        {
            float sueldoMensual = 0;

            sueldoMensual = sueldo * horas;

            return sueldoMensual;
        }

        public void MostrarSueldo()
        {
            Console.WriteLine(this.SueldoE);
        }

        public void MostrarEmpleado()
        {
            this.Mostrar();
            this.Trabajar();
            this.Dormir();
            MostrarSueldo();
            Console.WriteLine(this._sueldoE);
            Console.WriteLine(this.Comer());
            
            
        }
    }
}
