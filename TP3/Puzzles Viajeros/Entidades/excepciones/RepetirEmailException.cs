using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.excepciones
{
    /// <summary>
    /// El email y la confirmacion son distintos
    /// </summary>
    public class RepetirEmailException : Exception
    {
           public RepetirEmailException(string message) : base(message)
        {
        }
    }
}
