using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ManejadorArchivo_lab4
{
    class Program
    {
        static void Main(string[] args)
        {

            ManejadorArchivos ma = new ManejadorArchivos();

            ArrayList array = new ArrayList();
            array.Add("HOLA");
            array.Add("verano");

            Console.WriteLine("Voy a escribir");
            ma.Escribir("hola.txt", array);

            Console.WriteLine("Voy a escribir algo mal");
            ma.Escribir("hoalsdfhola.txt", array);

            Console.Read();
        }
    }
}
