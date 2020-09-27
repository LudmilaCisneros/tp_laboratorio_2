using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        /// <summary>
        /// Constructor por defecto.Setea en 0 el numero.
        /// </summary>
        private Numero()
        {
            numero = 0;
        }

        /// <summary>
        /// Constructor por defecto.Setea en 0 el numero.
        /// </summary>
        public Numero(string numeroStr):this()
        {
            double numero;

            if(double.TryParse(numeroStr,out numero))
            {
                this.numero = numero;
            }
        }



        /// <summary>
        /// Asignará un valor al atributo número.
        /// </summary>
        public string SetNumero
        {
            set { this.numero = ValidarNumero(value); }
        }
        /// <summary>
        /// Comprobará que el valor recibido sea numérico
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>si es num lo retorna en double</returns>
        private double ValidarNumero(string numero)
        {
            double numeroAux = 0;

           if(double.TryParse(numero,out numeroAux))
            {
                return numeroAux;
            }

            return numeroAux;
        }


        //sobrecarga operadores
        public static Double operator+(Numero n1,Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static Double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static Double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static Double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }

        /// <summary>
        /// Valida si la cadena esta compuesta por unicamente '0' || '1'.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static bool EsBinario(string numero)
        {
            bool esBinario = false;

            for(int i=0;i<numero.Length;i++)
            {
                if(numero[i] != '0' && numero[i] != '1')
                {
                    return esBinario;
                }
            }
            esBinario = true;

            return esBinario;
        }
        /// <summary>
        /// Convertirá un numero binario al decimal
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>numero str</returns>
        public static string BinarioDecimal(string numeroStr)
        {
            char[] array = numeroStr.ToCharArray();

            Array.Reverse(array);

            int suma = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    if (i == 0)
                    {
                        suma += 1;
                    }
                    else
                    {
                        suma += (int)Math.Pow(2, i);
                    }
                }

                if (array[i] != '0' && array[i] != '1')
                {
                    return "Valor invalido";
                }
            }
            return suma.ToString();
        }

        /// <summary>
        /// Convertirá un decimal a binario
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>binario str</returns>
        public static string DecimalBinario(string numStr)
        {
            double numero;
            bool esNumero;

            esNumero = double.TryParse(numStr, out numero);
            if(esNumero)
            {
                numero = Math.Abs(numero);
                return Convert.ToString(Convert.ToInt32(numero), 2);
            }
            else
            {
               return "\nValor inválido";
            }

        }
    }
}
