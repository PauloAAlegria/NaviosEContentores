using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaviosEContentores
{
    class MaxChemicalException : Exception
    {
        public MaxChemicalException() : base() { }
        public MaxChemicalException(string message) : base(message) { }
    }
}
