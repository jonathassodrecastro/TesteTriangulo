# TesteTriangulo
Orientação recebida:
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
        
A partir daí, na classe Program.cs tratei a entrada do usuário:

A entrada é recebida no formato pedido, então é feito um Replace para remover os colchetes externos e um Split para quebrar a matriz em linhas.

Com a matriz pronta passamos a classe com o método que fará a soma.

Seguindo a regra de que um elemento só pode ser somado com um dos dois elementos da próxima linha, o método percorre o triângulo de baixo para cima, calculando a soma máxima possível para cada elemento. 
No final, a soma máxima possível é o valor armazenado no elemento dadosTriangulo[0][0].

