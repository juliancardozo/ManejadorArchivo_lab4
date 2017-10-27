using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo_lab4
{
    public class DirectorioNoEncontradoException : DirectoryNotFoundException
    {

        public DirectorioNoEncontradoException()
        {
        }

        public DirectorioNoEncontradoException(string message) : base(message)
        {
            Console.Write("Hola Error DirectorioNoEncontrado.");
        }

        public DirectorioNoEncontradoException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
