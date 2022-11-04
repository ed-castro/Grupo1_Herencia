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

        //metodo para calcular AFP
        public double DesAfp ()
        {
            return Sueldo * 0.0725;
        }
        //metodo para calcular Renta

        public double DescRenta ()
        {
            // TRAMO I
            if (Sueldo>=0.01 && Sueldo<=472)
            {
                return 0;
                // TRAMO II
            } else if (Sueldo>=472.01 && Sueldo <=895.24)
            {
                return ((Sueldo - 472) * 0.1) + 17.67;

                //TRAMO III
            } else if (Sueldo>=895.25 && Sueldo<=2038.10)
            {
                return ((Sueldo - 895.24) * 0.2) + 60;
            }
            // TRAMO IV
            else  
            {
                return ((Sueldo - 2038.10) * 0.3) + 288.57;
            } 
        }

        // metodo para captura de datos desde teclado
        public void Captura ()
        {
            Console.Write("Ingrese el nombre del emplado: ");
            nombre= Console.ReadLine();
            Console.Write("Ingrese el apellido del emplado: ");
            apellido = Console.ReadLine();
            Console.Write("Ingrese el genero: ");
            genero = Console.ReadLine();
            Console.Write("Ingrese la edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el salario: ");
            sueldo = Convert.ToDouble(Console.ReadLine());
        }
        // Constructor por omision 

        public void Mostrar()
        {
            Console.WriteLine("Nombre: " + nombre + " " + apellido);
            Console.WriteLine("Genero: " + genero );
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Sueldo: " + sueldo);
        }
    
    

        public Empleados ()
        {
            Console.WriteLine("Bienvenidos!");
        }

        public Empleados (string nombre, string apellido, string genero, int edad, double sueldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.genero = genero;
            this.edad = edad;
            this.sueldo = sueldo;
                
        }
       

    }
}
