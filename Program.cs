using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea2progra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] emp;                            //declaracion de variables
            int[] suel;
            int[] agui;

            emp = new string[4];

            emp[0] = "Pedro";                        //datos almacenados en los arreglos
            emp[1] = "Marco";
            emp[2] = "Juan";
            emp[3] = "Julio";

            suel = new int[4];

            suel[0] = 2000;
            suel[1] = 5000;
            suel[2] = 3000;
            suel[3] = 8000;

            agui = new int[4];

            agui[0] = 12 * suel[0];
            agui[1] = 12 * suel[1];
            agui[2] = 12 * suel[2];
            agui[3] = 12 * suel[3];
                                                                         //impresion en pantalla

            Console.WriteLine("El empleado " + emp[0] + ", tiene un sueldo de " + suel[0] + ", su aguinaldo es de " + agui[0] + ".");
            Console.WriteLine("El empleado " + emp[1] + ", tiene un sueldo de " + suel[1] + ", su aguinaldo es de " + agui[1] + ".");
            Console.WriteLine("El empleado " + emp[2] + ", tiene un sueldo de " + suel[2] + ", su aguinaldo es de " + agui[2] + ".");
            Console.WriteLine("El empleado " + emp[3] + ", tiene un sueldo de " + suel[3] + ", su aguinaldo es de " + agui[3] + ".");

            Console.ReadKey();
        }
    }
}
