using Entidades.clases;
using System;

namespace Entidades
{
    public abstract class Persona
    {
        private static int id;
        private string nombre;
        private string apellido;
        private Direccion direccion;
        private string telefono;
        private string email;
        private DateTime fechaNac;
        private int dni;

        static Persona()
        {
            id = 0;
        }
        public Persona()
        {
            id++;
        }

        public Persona(string nombre, string apellido, Direccion direccion, string telefono, string email, DateTime fechaNac, int dni)
            : this()
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.FechaNac = fechaNac;
            this.Dni = dni;
        }

        public static int Id { get => id;}
        public string Nombre { get => nombre;
            set
            {
                nombre = Helpers.FormatearTexto(value);
            }
        }
        public string Apellido { get => apellido;
            set {
                apellido = Helpers.FormatearTexto(value);
            }
        }
        public Direccion Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value.Trim(); }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Dni { get => dni; set => dni = value; }
        
        public override string ToString()
        {
            return $"Id: {id} - Nombre: {nombre} - Apellido: {apellido} " +
                $"- Direccion: {direccion} - Teléfono: {telefono} - Email: {email}" +
                $"- Fecha de nacimiento: {fechaNac} - DNI: {dni}";
        }
    }
}
