using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.excepciones
{
    public class DNIInvalidoException : Exception
    {
        public DNIInvalidoException(string message) : base(message)
        {
        }
    }
}
