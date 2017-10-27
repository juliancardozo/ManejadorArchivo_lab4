using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManejadorArchivo_lab4
{
    public class NoExisteArchivoException : FileNotFoundException
    {
        public NoExisteArchivoException()
        {
        }
        public NoExisteArchivoException(string message)
            : base(message)
        {
        }
        public NoExisteArchivoException(string message, FileNotFoundException inner)
            : base(message, inner)
        {
        }
    }
}
