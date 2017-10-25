using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo_lab4
{
    public class ManejadorArchivos
    {
        // Lee las líneas del archivo indicado y los almacena en el array contenedor.
        // En caso de que el archivo contenga más líneas que el largo del array
        // (contenedor), se deberá lanzar una excepción específica.
        public void Escribir(String nomArchivo, ArrayList elementos)
        {
            //Hay que importar la librería system.IO.
            // StreamWriter log = new StreamWriter("log.txt", true);

            StreamWriter archivo = new StreamWriter(nomArchivo, false);
            foreach (String linea in elementos)
            {
                archivo.WriteLine(linea);
            }
            archivo.Close();
/*
            try { 
                StreamWriter archivo = new StreamWriter(nomArchivo, false);
                foreach (String linea in elementos)
                {
                    archivo.WriteLine(linea);
                }
                archivo.Close();
            } catch(DirectoryNotFoundException fe)
            {
                throw new DirectorioNoEncontradoException("El directorio no existe.");
            }

            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("No tenes permisos papi");
                throw new DirectorioNoEncontradoException("El directorio no existe.");
            }
            */

        }

        public void Leer(String nomArchivo, String[] contenedor)
        {

        }

        public ArrayList Leer (String nomArchivo, int lineaNro)
        {
            ArrayList resultado = null;
            return resultado;
        }

        
       
    }
}
