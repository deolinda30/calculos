using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// Implementa operações atitméticas.
    /// </summary>
    internal static class aritmética
    {
       
        /// <summary>
        /// Operação Soma
        /// </summary>
        /// <returns>Retorna a soma de dois números. </returns>
        public static int Somar(int x, int y)
        {
            return x + y;
        }
        /// <summary>
        /// Operação de Subtração:
        /// </summary>
        /// <returns>Retorna o resultado da subtração de dois números.</returns>
        
        public static int Subtrair(int x, int y)
        {
            return x - y;
        }
        /// <summary>
        /// Operação de Multiplicação:
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de dois números.</returns>
        public static int Multiplicar(int x,  int y)
        {
            return y * y;
        }
    }
}
