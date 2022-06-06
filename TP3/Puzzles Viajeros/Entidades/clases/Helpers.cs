using Entidades.excepciones;
using System;
using System.Text.RegularExpressions;

namespace Entidades.clases
{
    public static class Helpers
    {
        /// <summary>
        /// La primera letra 
        /// </summary>
        /// <param name="texto"></param>
        /// <returns></returns>
        public static String FormatearTexto(string texto)
        {
            return texto.Trim()
                        .ToUpper();
        }

        /// <summary>
        /// Comprueba si el usuario y la contraseña coinciden
        /// </summary>
        /// <param name="puzzleteca"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool ValidarUsuario(Puzzleteca puzzleteca, string usuario, string password) 
        {
            if (puzzleteca.Usuarios is null) throw new NullReferenceException("No existen usuarios.");
            foreach (Usuario user in puzzleteca.Usuarios)
            {
                if (user.Email.Equals(usuario) && user.Password.Equals(password))
                {
                    return true;
                }
                else if (user.Email.Equals(usuario) && !user.Password.Equals(password))
                {
                    throw new LoginException("Contraseña invalida");
                }
            }
            throw new LoginException("Usuario invalido");
        }

        /// <summary>
        /// Comprueba que un mail sea un mail valido 
        /// </summary>
        /// <param name="mail"></param>
        /// <returns>True OK, Excepcion sin no es valido</returns>
        public static bool ValidarEmail(string mail)
        {
            Regex r = new Regex("^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");

            return (r.IsMatch(mail)) ? true 
                                     : throw new EmailInvalidoException("Ingrese un mail valido");
        }

        public static string FormatearTelefono(string caracteristica, string telefono)
        {
            return $"({caracteristica}) - {telefono}";
        }

        /// <summary>
        /// Compara 2 emails chequeando que sean validos e iguales
        /// </summary>
        /// <param name="mail">Mail original</param>
        /// <param name="mail2">Repetir e-mail</param>
        /// <returns>True si son iguales, Excepcion si son distintos</returns>
        public static bool ValidarEmail(string mail, string mail2)
        {
            return (ValidarEmail(mail) && ValidarEmail(mail2) && mail.Equals(mail2)) 
                ? true
                : throw new RepetirEmailException("ERROR: e-mail no coincide");

        }

        public static bool ValidarTexto(string texto)
        {
            return (String.IsNullOrWhiteSpace(texto))
                ? true
                : throw new MandatoryException("Este campo es obligatorio");
        }

        public static void ValidarTexto(string texto, out string text)
        {
            ValidarTexto(texto);
            text = texto;
        }

        public static bool ValidarContraseña(string pass, string pass2)
        {
            if (pass.Length < 8) throw new ShortPassException("Error: debe tener al menos 8 caracteres");
            return (pass.Equals(pass))
               ? true
               : throw new RepetirEmailException("ERROR: La contraseña no coincide");
        }

        public static bool ValidarEdad(DateTime fecha)
        {
            return (DateTime.Today.Subtract(fecha).Days > 6570)
                ? true
                : throw new EdadInvalidaException("Error: Debe ser mayor de 18");
        } 
    }
}
