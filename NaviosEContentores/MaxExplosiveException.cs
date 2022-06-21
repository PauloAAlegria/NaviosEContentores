using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviosEContentores
{
    class MaxExplosiveException : Exception
    {
        public MaxExplosiveException() : base() { }
        public MaxExplosiveException(string message) : base(message) { }
    }
}
