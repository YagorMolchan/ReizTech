using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Exceptions
{
    public class MinuteException:ArgumentException
    {
        public MinuteException(string message):base(message)
        {
            
        }
    }
}
