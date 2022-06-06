using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.interfaces
{
    interface IEliminable
    {
        public T EliminarDelListado<T, U>(T lista, U item);
    }
}
