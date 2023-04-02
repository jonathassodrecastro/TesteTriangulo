using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCandidatoTriangulo
{
    public class Triangulo
    {
        /// <summary>
        ///    6
        ///   3 5
        ///  9 7 1
        /// 4 6 8 4
        /// Um elemento somente pode ser somado com um dos dois elementos da próxima linha. Como o elemento 5 na Linha 2 pode ser somado com 7 e 1, mas não com o 9.
        /// Neste triangulo o total máximo é 6 + 5 + 7 + 8 = 26
        /// 
        /// Seu código deverá receber uma matriz (multidimensional) como entrada. O triângulo acima seria: [[6],[3,5],[9,7,1],[4,6,8,4]]
        /// </summary>
        /// <param name="dadosTriangulo"></param>
        /// <returns>Retorna o resultado do calculo conforme regra acima</returns>
        public int ResultadoTriangulo(int[][] dadosTriangulo)
        {
            

            // Para cada linha do triângulo, exceto a última
            for (int i = dadosTriangulo.Length - 2; i >= 0; i--)
            {
                // Para cada elemento da linha
                for (int j = 0; j < dadosTriangulo[i].Length; j++)
                {
                    // Calcula o máximo entre a soma do elemento atual com os dois elementos abaixo
                    dadosTriangulo[i][j] += Math.Max(dadosTriangulo[i + 1][j], dadosTriangulo[i + 1][j + 1]);
                }
            }

            
            // Retorna o valor máximo na primeira posição do triângulo
            return dadosTriangulo[0][0];

            
        }


    }
}

