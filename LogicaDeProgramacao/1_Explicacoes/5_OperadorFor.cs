using System;

namespace LogicaDeProgramacao.Explicacoes
{
    public class OperadorFor : IExplicacao
    {
        public void Explicar()
        {
            Console.WriteLine(@"
    A instrução for executa uma instrução ou um bloco de instruções enquanto uma expressão booliana especificada é avaliada como true.

    Estrutura da instrução for:

        for (inicialização; condição; iteração)
        {
            // corpo
        }

    Exemplos:

        for(int i = 0; i < 3; i++) 
        {
            Console.WriteLine('i = ' + i);
        }

        // i = 0
        // i = 1
        // i = 2
");
        }
    }
}
