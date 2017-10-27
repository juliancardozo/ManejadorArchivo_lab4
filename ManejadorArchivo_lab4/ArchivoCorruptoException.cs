using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ManejadorArchivo_lab4
{
    public class ArchivoCorruptoException : FileLoadException
    {
        public ArchivoCorruptoException()
        {
        }
        public ArchivoCorruptoException(string message)
            : base(message)
        {
        }
        public ArchivoCorruptoException(string message, FileLoadException inner)
            : base(message, inner)
        {
        }

        public ArchivoCorruptoException(string message, UnauthorizedAccessException inner)
            : base(message, inner)
        {
        }
    }
}
