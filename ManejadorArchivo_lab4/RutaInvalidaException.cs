using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManejadorArchivo_lab4
{
    public class RutaInvalidaException : DirectoryNotFoundException
    {
        public RutaInvalidaException()
        {

        }
        public RutaInvalidaException(string message)
            : base(message)
        {
        }
        public RutaInvalidaException(string message, DirectoryNotFoundException inner)
            : base(message, inner)
        {
        }
    }
}
