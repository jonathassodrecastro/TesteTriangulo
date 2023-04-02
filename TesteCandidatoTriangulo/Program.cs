using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCandidatoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo= new Triangulo();  

            Console.WriteLine("Digite o triângulo no formato [[6],[3,5],[9,7,1],[4,6,8,4]]:");
            string entrada = Console.ReadLine();
            entrada = entrada.Replace("[[", "").Replace("]]", ""); // Remove os colchetes externos
            string[] linhas = entrada.Split(new string[] { "],[" }, StringSplitOptions.None); // Separa as linhas
            int[][] matriz = new int[linhas.Length][];
            for (int i = 0; i < linhas.Length; i++)
            {
                string[] numeros = linhas[i].Split(',');
                matriz[i] = new int[numeros.Length];
                for (int j = 0; j < numeros.Length; j++)
                {
                    matriz[i][j] = int.Parse(numeros[j]);
                }
            }

            int resultado = triangulo.ResultadoTriangulo(matriz);
            Console.WriteLine("Resultado: " + resultado);
        }
    }
}
