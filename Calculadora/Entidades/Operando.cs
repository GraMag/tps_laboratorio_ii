using System;
using System.Text;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Operando()
            :this(0)
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="numero"></param>
        public Operando(double numero)
        {
             this.numero = numero;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="strNumero"></param>
        public Operando(string strNumero)
            :this()
        {
            Numero = strNumero;
        }


        /// <summary>
        /// Setter del numero
        /// </summary>
        private string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        /// <summary>
        /// Convierte un numero de binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Numero en decimal. Valor default: "Valor invalido"</returns>
        public string BinarioDecimal(string binario)
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

        /// <summary>
        /// Convierte un numero de binario a decimal
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Numero en decimal. Valor default: "Valor invalido"</returns>
        public string DecimalBinario(string numero)
        {
            double.TryParse(numero, out double resultado);
            return DecimalBinario(resultado);
        }

        /// <summary>
        /// Convierte un numero de decimal binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Numero en binario. Valor default: "Valor invalido"</returns>
        public string DecimalBinario(double numero)
        {
            double numeroEntero = Math.Abs(numero);
            if (numeroEntero > 0)
            {
                StringBuilder numeroBinario = new();
                do
                {
                    numeroBinario.Insert(0, (int)numeroEntero % 2);
                    numeroEntero /= 2;
                } while (numeroEntero >= 1);
                    return numeroBinario.ToString();
            }
            return "Valor invalido";
        }

        /// <summary>
        /// Valida que el numero sea binario
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>TRUE si es binario, FALSE si no lo es</returns>
        private bool EsBinario(string binario)
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
            strNumero = strNumero.Replace(".", ",");
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