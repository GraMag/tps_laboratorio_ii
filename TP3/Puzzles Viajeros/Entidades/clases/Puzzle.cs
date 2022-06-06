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
        private string referente;
        private string observaciones;
        private Persona donante; // Deberia ser generico?
        private DateTime ingreso;

        static Puzzle()
        {
            id = 0; 
        }

        public Puzzle()
        {
            id++;
            this.Ingreso = DateTime.Today;
        }

        public Puzzle(ECantidad piezas, string titulo, EMarca marca, ECategoria categoria, string referente, Persona donante)
            : this()
        {
            this.Piezas = piezas;
            this.Titulo = titulo;
            this.Marca = marca;
            this.Categoria = categoria;
            this.referente = referente;
            this.donante = donante;
        }

        public Puzzle(ECantidad piezas, string titulo, EMarca marca, ECategoria categoria, string referente, Persona donante, string observaciones)
            :this(piezas, titulo, marca, categoria, referente, donante)
        {
            this.Observaciones = observaciones;
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public ECantidad Piezas 
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
        public string Referente
        {
            get
            {
                return referente;
            }

            set
            {
                this.referente = value;
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

        public DateTime Ingreso
        {
            get
            {
                return ingreso;
            }
            set
            {
                this.ingreso = value;
            }
        }
    }
}