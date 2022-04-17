using System;
using System.Text;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        public Operando()
        {
            this.numero = 0;
        }

        public Operando(double numero)
            : this()
        {
             this.numero = numero;
        }

        public Operando(string strNumero)
            :this()
        {
            Numero = strNumero;
        }



        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        public static string BinarioDecimal(string binario)
        {
            string resultado = "Valor invalido";
            if (EsBinario(binario))
            {
                double decimalNum = 0;
                int exponente = binario.Length - 1;
                foreach (char item in binario)
                {
                    decimalNum += int.Parse(item.ToString()) * Math.Pow(2, exponente);
                    exponente--;
                }
                resultado = decimalNum.ToString();
            }
            return resultado;
        }

        public static string DecimalBinario(string numero)
        {
            double.TryParse(numero, out double resultado);
            return DecimalBinario(resultado);
        }

        public static string DecimalBinario(double numero)
        {
            double numeroEntero = Math.Abs(numero);
            if (numero > 0)
            {
                StringBuilder numeroBinario = new StringBuilder();
                while (numeroEntero > 1)
                {
                    numeroBinario.Insert(0, numeroEntero % 2);
                    numeroEntero /= 2;
                }
                numeroBinario.Insert(0, "1");
                return numeroBinario.ToString();
            }
            return "Valor invalido";
        }

        /// <summary>
        /// Valida que el numero sea binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>TRUE si es binario, FALSE si no lo es</returns>
        private static bool EsBinario(string binario)
        {
            foreach(char digito in binario){
                if(!(digito == '0' || digito == '1'))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Valida que el operando sea un numero
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>El numero ingresado. Si no es un numero retorna 0</returns>
        private static double ValidarOperando(string strNumero)
        {
            double.TryParse(strNumero, out double numero);
            return numero;
        }

        /// <summary>
        /// Suma dos numeross
        /// </summary>
        /// <param name="n1">Sumando</param>
        /// <param name="n2">Sumando</param>
        /// <returns>Resultado de la suma</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Resta dos numeross
        /// </summary>
        /// <param name="n1">Minuendo</param>
        /// <param name="n2">Sustraendo</param>
        /// <returns>Diferencia de la resta</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Multiplica dos numeross
        /// </summary>
        /// <param name="n1">Multiplicando</param>
        /// <param name="n2">Multiplicador</param>
        /// <returns>Producto de la multiplicacion</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Divide dos numeross
        /// </summary>
        /// <param name="n1">Dividendo</param>
        /// <param name="n2">Divisor</param>
        /// <returns>Cociente de la division. Si el divisor es 0 el resultado sera double.MinValue</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            return (n2.numero == 0) ? double.MinValue : (n1.numero / n2.numero);
        }
    }
}