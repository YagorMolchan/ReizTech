﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Exceptions
{
    public class HourException: ArgumentException
    {
        public HourException(string message):base(message)
        {
            
        }
    }
}
