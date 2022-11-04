using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo1_Herencia
{
    class Empleados
    {
        //declaracion de variables
        public string nombre, apellido, genero;
        public int edad;
        private double sueldo;

        public double Sueldo
        {
            get { return sueldo; }
            set
            {
                while (value <=0 )
                {
                    Console.Write("Error! No se aceptan valores negativos.\nIngrese nuevamente el sueldo: ");
                    value = Convert.ToDouble(Console.ReadLine());
                }
                sueldo = value;
            }
        }

        // Metodo para calculo de ISSS

        public double DescIsss()
        {
          if (Sueldo >=0 && Sueldo <=685.71)
            {
                return Sueldo * 0.03;
            } else
            {
                return 20.57;
            }
           
        }

        public double DesAfp ()
        {
            return Sueldo * 0.0725;
        }

       

    }
}
