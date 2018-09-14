using System;

namespace LogicaDeProgramacao.Explicacoes
{
    public class OpeardorDo : IExplicacao
    {
        public void Explicar()
        {
            Console.WriteLine(@"
    A instrução do executa uma instrução ou um bloco de instruções enquanto uma expressão booliana especificada é avaliada como true.

    Exemplo:
        int n = 0;
        do 
        {
            Console.WriteLine('n = ' + n);
            n++;
        } while (n < 3);

        //n = 0
        //n = 1
        //n = 2
");
        }
    }
}
