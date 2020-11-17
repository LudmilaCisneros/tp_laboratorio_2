using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            string auxOperador;

            switch(operador)
            {
                case "-":
                    auxOperador = "-";
                    break;

                case "*":
                    auxOperador = "*";
                    break;

                case "/":
                    auxOperador = "/";
                    break;

                default:
                    auxOperador = "+";
                    break;
            }
            return auxOperador;
        }
        /// <summary>
        /// Realiza el calculo
        /// </summary>
        /// <param name="n1">Numero n1</param>
        /// <param name="n2">Numero n1</param>
        /// <param name="operador">Operador del calculo</param>
        /// <returns>double Resultado si esta ok, (-1) error</returns>
        public static Double Operar(Numero n1, Numero n2,string operador)
        {
            double resultado = -1;
            string auxOperador;

            auxOperador = ValidarOperador(operador);

            switch(auxOperador)
            {
                case "+":
                    resultado = n1 + n2;
                    break;
                case "-":
                    resultado = n1 - n2;
                    break;
                case "*":
                    resultado = n1 * n2;
                    break;
                case "/":
                    resultado = n1 / n2;
                    break;
                default:
                    Console.WriteLine("\nError");
                    break;
            }
            return resultado;
        }
    }
}
