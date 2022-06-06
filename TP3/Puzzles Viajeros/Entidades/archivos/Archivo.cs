using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.archivos
{
    public static class Archivo
    {
        private static string ruta;
        static Archivo()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"Archivos";
        }
        public static void Escribir()
        {

            //string ruta = AppDomain.CurrentDomain.BaseDirectory;
            string nombreArchivo = @"/log" + ".txt" + DateTime.Now.ToString("dd_MM_HH_mm_ss");
            string completo = ruta + nombreArchivo;

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }
                string datos = string.Empty;
                datos += "\n" + DateTime.Now.ToString();

                File.AppendAllText(completo, datos);
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {completo}");
            }
        }

        public static string Leer(string archivo)
        {
            try
            {
                string datos = string.Empty;
                if (Directory.Exists(ruta))
                {
                    string completo = ruta + @$"\{archivo}" + ".txt";
                    datos = File.ReadAllText(completo);
                }
                return datos;
            }
            catch (Exception e)
            {
                throw new Exception($"Error en el archivo {ruta}");
            }
        }
    }
}
