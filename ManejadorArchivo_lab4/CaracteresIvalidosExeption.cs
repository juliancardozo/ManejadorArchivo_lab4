﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorArchivo_lab4
{
    class CaracteresIvalidosExeption:Exception
    {
        public CaracteresIvalidosExeption()
        {
        }
        public CaracteresIvalidosExeption(string message)
            : base(message)
        {
        }
    }
}