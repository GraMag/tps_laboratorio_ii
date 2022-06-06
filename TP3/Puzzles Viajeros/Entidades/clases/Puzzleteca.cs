using Entidades.interfaces;
using System.Collections.Generic;


namespace Entidades
{
    public class Puzzleteca : IAgregable
    {
        private static Puzzleteca singleton;
        private List<Puzzle> puzzles;
        private List<Persona> usuarios;

        private Puzzleteca()
        {
            this.Puzzles = new List<Puzzle>();
            this.Usuarios = new List<Persona>();
        }

        public static Puzzleteca Singleton 
        {
            get
            {
                if(singleton is null)
                {
                    singleton = new Puzzleteca();
                }
                return singleton;
            }
        }

        public List<Puzzle> Puzzles { get => puzzles; set => puzzles = value; }
        public List<Persona> Usuarios { get => usuarios; set => usuarios = value; }

        public static List<Puzzle> operator +(Puzzleteca puzzleteca, Puzzle puzzle)
        {
            puzzleteca.Puzzles.Add(puzzle);

            return puzzleteca.Puzzles;
        }

        public static List<Persona> operator +(Puzzleteca puzzleteca, Persona usuario)
        {
            puzzleteca.Usuarios.Add(usuario);

            return puzzleteca.Usuarios;
        }

        public Puzzleteca AgregarAlListado<T>(Puzzleteca puzzleteca, T item) where T : class
        { 
            //TODO
            return puzzleteca;
        }
    }
}
