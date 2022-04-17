namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operación 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="operador"></param>
        /// <returns>Resultado de la operación</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            switch (ValidarOperador(operador))
            {
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                default:
                    return num1 + num2;
            }
        }

        /// <summary>
        /// Valida el operador
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Operador ingresado. Valor default: + </returns>
        private static char ValidarOperador(char operador)
        {
            return (operador == '-' || operador == '/' || operador == '*') ? operador : '+';
        }
    }
}
