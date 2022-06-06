using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Admin : Usuario
    {
        private List<Puzzle> referente;


        public Admin()
        {
            this.EsAdmin = true;
            this.referente = new List<Puzzle>();
        }

        public Admin(string nombre, string apellido, Direccion direccion, string telefono, string email, DateTime fechaNac, int dni, string password, bool esAdmin)
        : base(nombre, apellido, direccion, telefono, email, fechaNac, dni, password, esAdmin)
        {
            this.referente = new List<Puzzle>();
        }
}
