using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.excepciones
{
    public class EmailInvalidoException : Exception
    {
        public EmailInvalidoException(string message) : base(message)
        {
        }
    }
}
