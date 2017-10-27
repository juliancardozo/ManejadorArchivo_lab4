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
            array.Add("Hola");
            array.Add("esta");
            array.Add("llegando");
            array.Add("el");
            array.Add("verano");
            array.Add("uruguay");

            try
            {

                Console.WriteLine("Voy a escribir");
                ma.Escribir("C:\\Users\\Mati\\Documents\\GitHub\\ManejadorArchivo_lab4\\ManejadorArchivo_lab4\\hola.txt", array);


                Console.WriteLine("Voy a escribir mal");
                ma.Escribir("C:\\Windows\\System32\\drivers\\etc\\hosts", array);

            }
            catch(DirectorioNoAccesibleException e)
            {
                Console.WriteLine("*************** EXCEPCION DETECTADA ***************");
                Console.WriteLine(e.ToString());
            }catch(DirectorioNoEncontradoException e)
            {
                Console.WriteLine("*************** EXCEPCION DETECTADA ***************");
                Console.WriteLine(e.ToString());

            }catch(ArrayExcedidoLargoException e)
            {
                Console.WriteLine("*************** EXCEPCION DETECTADA ***************");
                Console.WriteLine(e.ToString());

            }

            try
            {
                string[] h = new String[1];
                ma.Leer("C:\\Users\\Mati\\Documents\\GitHub\\ManejadorArchivo_lab4\\ManejadorArchivo_lab4\\hola.txt", h);

            }catch(ArrayExcedidoLargoException e)
            {
                Console.WriteLine("*************** EXCEPCION DETECTADA ***************");
                Console.WriteLine(e.ToString());
            }
            catch (DirectorioNoAccesibleException e)
            {
                Console.WriteLine("*************** EXCEPCION DETECTADA ***************");
                Console.WriteLine(e.ToString());
            }
            catch (ArchivoCorruptoException e)
            {
                Console.WriteLine("*************** EXCEPCION DETECTADA ***************");
                Console.WriteLine(e.ToString());
                Console.WriteLine("*************** FIN EXCEPCION ***************");
            }



            try
            {
                ArrayList l = ma.Leer("C:\\Users\\Mati\\Documents\\GitHub\\ManejadorArchivo_lab4\\ManejadorArchivo_lab4\\hola.txt", 3);
                foreach(String t in l)
                {
                    Console.WriteLine(t);
                }
            }
            catch (ArrayExcedidoLargoException e)
            {
                Console.WriteLine("*************** EXCEPCION DETECTADA ***************");
                Console.WriteLine(e.ToString());
            }
            catch (DirectorioNoAccesibleException e)
            {
                Console.WriteLine("*************** EXCEPCION DETECTADA ***************");
                Console.WriteLine(e.ToString());
            }
            catch (ArchivoCorruptoException e)
            {
                Console.WriteLine("*************** EXCEPCION DETECTADA ***************");
                Console.WriteLine(e.ToString());
            }



            Console.Read();

        }
    }
}
