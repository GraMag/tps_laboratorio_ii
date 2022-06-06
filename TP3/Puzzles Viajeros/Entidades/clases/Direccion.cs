using Entidades.enums;

namespace Entidades
{
    public class Direccion
    {
        private string calle;
        private int numero;
        private string piso;
        private string dpto;
        private string localidad;
        private int cp;
        private EProvincia provincia;
        

        public Direccion()
        {

        }

        public Direccion(string calle, int numero, string localidad, int cp, EProvincia provincia)
        {
            this.Calle = calle;
            this.Numero = numero;
            this.Localidad = localidad;
            this.Cp = cp;
            this.Provincia = provincia;
        }

        public Direccion(string calle, int numero, string localidad, int cp, EProvincia provincia, string piso, string dpto)
            : this(calle, numero, localidad, cp, provincia)
        {
            this.Piso = piso;
            this.Dpto = dpto;
        }

        public string Calle
        {
            get => calle;
            set
            {
                calle = value.Trim();
            }
        }
        public int Numero 
        { 
            get => numero;
            set {
               numero = value; 
            }
        }
        public string Piso
        {
            get => piso;
            set
            {
                if(value.ToUpper() == "PB" || value.ToUpper() == "PLANTA BAJA" || int.TryParse(value, out int x))
                {
                    piso = value;
                } else {
                    piso = null;
                }
            }
        }

        public string Dpto { get => dpto; set => dpto = value.Trim(); }
        public string Localidad { get => localidad; set => localidad = value.Trim(); }
        public int Cp
        {
            get => cp;
            set 
            {
                cp = int.Parse(value.ToString());
            }
        }
        public EProvincia Provincia { get => provincia; set => provincia = value; }

    }
}