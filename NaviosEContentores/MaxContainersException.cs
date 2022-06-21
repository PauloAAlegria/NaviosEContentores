using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviosEContentores
{
    class MaxContainersException : Exception
    {
        public MaxContainersException() : base() { }
        public MaxContainersException(string message) : base(message) { }
    }
}
