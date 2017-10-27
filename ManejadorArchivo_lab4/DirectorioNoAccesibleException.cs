using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo_lab4
{
    public class DirectorioNoAccesibleException : UnauthorizedAccessException
    {
        public DirectorioNoAccesibleException()
        {
        }
        public DirectorioNoAccesibleException(string message)
            : base(message)
        {
        }
        public DirectorioNoAccesibleException(string message, UnauthorizedAccessException inner)
            : base(message, inner)
        {
        }
    }
}
