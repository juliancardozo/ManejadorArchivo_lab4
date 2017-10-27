using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo_lab4
{
    public class ArrayExcedidoLargoException : ArgumentOutOfRangeException
    {
        public ArrayExcedidoLargoException()
        {
        }
        public ArrayExcedidoLargoException(string message)
            : base(message)
        {
        }
        public ArrayExcedidoLargoException(string message, ArgumentOutOfRangeException inner)
            : base(message, inner)
        {
        }
    }
}
