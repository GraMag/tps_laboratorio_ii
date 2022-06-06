using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.archivos
{
    public class Serializadora
    {
        static string ruta;
        static Serializadora()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"Archivos-serializacion";
        }

        public static void Escribir(Persona persona)
        {
            string nombreArchivo = ruta + @"/Usuario_" + DateTime.Now.ToString("dd_MM_HH_mm_ss") + ".xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using(StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Persona));
                    xmlSerializer.Serialize(sw, persona);
                }
            } catch (Exception e)
            {
                throw new Exception($"Error en el archivo {nombreArchivo}");
            }

        }

        public static void Escribir(Puzzle puzzle)
        {
            string nombreArchivo = ruta + @"/Puzzle_" + DateTime.Now.ToString("dd_MM_HH_mm_ss") + ".xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Puzzle));
                    xmlSerializer.Serialize(sw, puzzle);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {nombreArchivo}");
            }

        }

        public static void Escribir(List<Persona> persona)
        {
            string nombreArchivo = ruta + @"/Lista_Usuarios_" + DateTime.Now.ToString("dd_MM_HH_mm_ss") + ".xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Persona>));
                    xmlSerializer.Serialize(sw, persona);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {nombreArchivo}");
            }

        }

        public static void Escribir(List<Puzzle> puzzle)
        {
            string nombreArchivo = ruta + @"/Lista_Puzzles_" + DateTime.Now.ToString("dd_MM_HH_mm_ss") + ".xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(nombreArchivo))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Puzzle>));
                    xmlSerializer.Serialize(sw, puzzle);
                }
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {nombreArchivo}");
            }

        }

        public static Puzzle Leer()
        {
            string nombreArchivo = ruta + @"/Lista_Puzzles_.xml";

            Puzzle puzzle = null;
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamReader sr = new StreamReader(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Puzzle));
                    puzzle = (Puzzle) xmlSerializer.Deserialize(sr);
                }

                return puzzle;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {nombreArchivo}");
            }

        }

        public static List<Puzzle> LeerLista()
        {
            string nombreArchivo = ruta + @"/Lista_Puzzles_.xml";

            List<Puzzle> puzzle = null;
            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamReader sr = new StreamReader(ruta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Puzzle>));
                    puzzle = (List<Puzzle>)xmlSerializer.Deserialize(sr);
                }

                return puzzle;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {nombreArchivo}");
            }

        }
    }
}
