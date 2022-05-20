using Entidades.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Entidades
{
    public class Puzzle
    {
        private static int id;
        private ECantidad piezas;
        private string titulo;
        private EMarca marca;
        private ECategoria categoria;
        private string observaciones;

        static Puzzle()
        {
            id = 0; 
        }
        public Puzzle()
        {
            id++;
        }

        public Puzzle(ECantidad piezas, string titulo, EMarca marca, ECategoria categoria):
            this()
        {
            this.piezas = piezas;
            this.titulo = titulo;
            this.marca = marca;
            this.categoria = categoria;
        }

        public Puzzle(ECantidad piezas, string titulo, EMarca marca, ECategoria categoria, string observaciones)
            :this(piezas, titulo, marca, categoria)
        {
            this.observaciones = observaciones;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public ECantidad Cantidad 
        { 
            get
            {
                return piezas;
            }

            set
            {
                this.piezas = value;
            }
        }

        public string Titulo
        {
            get
            {
                return titulo;
            }

            set
            {
                this.titulo = value;
            }
        }

        public EMarca Marca
        {
            get
            {
                return marca;
            }

            set
            {
                this.marca = value;
            }
        }

        public ECategoria Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                this.categoria = value;
            }
        }

        public string Observaciones
        {
            get
            {
                return observaciones;
            }

            set
            {
                this.observaciones = value;
            }
        }
    }
}