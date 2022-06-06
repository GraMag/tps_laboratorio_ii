using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.excepciones
{
    class MandatoryException : Exception
    {
        public MandatoryException(string message) : base(message)
        {
        }
    }
}
