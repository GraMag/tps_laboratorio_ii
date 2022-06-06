using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.interfaces
{
    interface IAgregable
    {
        public Puzzleteca AgregarAlListado<T>(Puzzleteca puzzleteca, T item) where T : class;
    }
}
