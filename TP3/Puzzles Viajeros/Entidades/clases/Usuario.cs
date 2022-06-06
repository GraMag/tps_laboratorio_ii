using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Usuario : Persona
    {
        private string password;
        private List<string> faltas;
        private List<Puzzle> puzzlesArmados;
        private List<Puzzle> puzzlesPorArmar;
        private bool esAdmin;

        public Usuario()
        {
            this.Faltas = new List<string>();
            this.PuzzlesArmados = new List<Puzzle>();
            this.PuzzlesPorArmar = new List<Puzzle>();
            this.EsAdmin = false;
        }

        public Usuario(string nombre, string apellido, Direccion direccion, string telefono, string email, DateTime fechaNac, int dni, string password, bool esAdmin)
            :base(nombre, apellido, direccion, telefono, email, fechaNac, dni)
        {
            this.Faltas = new List<string>();
            this.PuzzlesArmados = new List<Puzzle>();
            this.PuzzlesPorArmar = new List<Puzzle>();
            this.EsAdmin = esAdmin;
            this.Password = password;
        }


        public List<string> Faltas { get => faltas; set => faltas = value; }
        public List<Puzzle> PuzzlesArmados { get => puzzlesArmados; set => puzzlesArmados = value; }
        public List<Puzzle> PuzzlesPorArmar { get => puzzlesPorArmar; set => puzzlesPorArmar = value; }
        public bool EsAdmin { get => esAdmin; set => esAdmin = value; }
        public string Password { get => password; set => password = value; }


    }
}
