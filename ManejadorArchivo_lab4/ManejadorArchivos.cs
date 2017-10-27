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

            StreamWriter log = new StreamWriter("C:\\Users\\Mati\\Documents\\GitHub\\ManejadorArchivo_lab4\\ManejadorArchivo_lab4\\log.txt", true);
            log.WriteLine("Intento escribir en "+nomArchivo);

            try
            {
                StreamWriter archivo = new StreamWriter(nomArchivo, false);
                foreach (String linea in elementos)
                {
                    archivo.WriteLine(linea);
                }
                archivo.Close();
                log.WriteLine("Logré escribir en "+nomArchivo);
                log.Close();
            } catch(DirectoryNotFoundException e)
            {
                log.WriteLine("Ocurrio un error, no existe el directorio para "+nomArchivo);
                log.Close();
                throw new DirectorioNoEncontradoException("El directorio no existe.");
            }

            catch (UnauthorizedAccessException e)
            {
                log.WriteLine("Ocurrio un error, hay permisos para "+nomArchivo);
                log.Close();
                throw new DirectorioNoAccesibleException("Ocurrio un error, es inaccesible");

            }
        }

        public void Leer(String nomArchivo, String[] contenedor)
        {
            StreamWriter log = new StreamWriter("C:\\Users\\Mati\\Documents\\GitHub\\ManejadorArchivo_lab4\\ManejadorArchivo_lab4\\log.txt", true);
            log.WriteLine("Intento leer " + nomArchivo);

            try
            {
                String[] lineas = System.IO.File.ReadAllLines(nomArchivo);
                if (lineas.Count() > contenedor.Count())
                {
                    log.WriteLine("El archivo " + nomArchivo + " supera el largo del array dado");
                    log.Close();
                    throw new ArrayExcedidoLargoException("El archivo supera el largo del array");
                }
                else
                {
                    contenedor = lineas;
                }
            }
            catch (FileNotFoundException e)
            {
                log.WriteLine("No existe el archivo " + nomArchivo);
                log.Close();
                throw new NoExisteArchivoException("El archivo no existe.");
            }

            catch (UnauthorizedAccessException e)
            {
                log.WriteLine("Ocurrio un error, hay permisos para " + nomArchivo);
                log.Close();
                throw new DirectorioNoAccesibleException("Ocurrio un error, es inaccesible");

            }catch (FileLoadException e)
            {
                log.WriteLine("Archivo corrupto: " + nomArchivo);
                log.Close();
                throw new ArchivoCorruptoException("Archivo corrupto");

            }
        }

        public ArrayList Leer (String nomArchivo, int lineaNro)
        {
            ArrayList resultado = new ArrayList();

            StreamWriter log = new StreamWriter("C:\\Users\\Mati\\Documents\\GitHub\\ManejadorArchivo_lab4\\ManejadorArchivo_lab4\\log.txt", true);
            log.WriteLine("Intento leer (arraylist) " + nomArchivo);

            try
            {
                String[] lineas = System.IO.File.ReadAllLines(nomArchivo);
                for(int i = lineaNro; i < lineas.Count(); i++)
                {
                    resultado.Add(lineas[i]);
                }
                log.Close();
                return resultado;
            }
            catch (FileNotFoundException e)
            {
                log.WriteLine("No existe el archivo " + nomArchivo);
                log.Close();
                throw new NoExisteArchivoException("El archivo no existe.");
            }

            catch (UnauthorizedAccessException e)
            {
                log.WriteLine("Ocurrio un error, hay permisos para " + nomArchivo);
                log.Close();
                throw new DirectorioNoAccesibleException("Ocurrio un error, es inaccesible");

            }
            catch (FileLoadException e)
            {
                log.WriteLine("Archivo corrupto: " + nomArchivo);
                log.Close();
                throw new ArchivoCorruptoException("Archivo corrupto");

            }

        }

        
       
    }
}
