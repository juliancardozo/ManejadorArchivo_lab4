using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo_lab4
{
    class NombreArchivoInvalido:Exception
    {
        public NombreArchivoInvalido()
        {
        }
        public NombreArchivoInvalido(string message):base(message)
        {
        }
    }
}
