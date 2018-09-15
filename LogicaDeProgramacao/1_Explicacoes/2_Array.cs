using System;

namespace LogicaDeProgramacao.Explicacoes
{
    public class _2_Array : IExplicacao
    {
        public void Explicar()
        {
            Console.WriteLine(@"

Um array (ou vetor) é a mais simples das estruturas de dados.
Diferente das variáveis do tipo valor, que são capazes de guardar um único dado, os vetores são capazes de guardar uma quantidade enorme.

Todo array possui um tipo (que é o tipo do dado que ele guarda, como int, float, char e etc) e um tamanho.

Exemplo:
    int[] array = new [4]; //Aqui temos um array do tipo int e comprimento 4, ou seja, é capaz de guardar 4 valores.
");
        }
    }
}
