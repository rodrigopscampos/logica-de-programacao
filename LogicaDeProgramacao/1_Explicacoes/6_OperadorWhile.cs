using LogicaDeProgramacao.Explicacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacao.Explicacoes
{
    public class OperadorWhile : IExplicacao
    {
        public void Explicar()
        {
            Console.WriteLine(@"
    A instrução while executa uma instrução ou um bloco de instruções enquanto uma expressão booliana especificada é avaliada como true

    Exemplo:

        int n = 0;
        while (n < 3)
        {
            Console.WriteLine('n = ' + n);
            n++;
        }

        //n = 0
        //n = 1
        //n = 2
");
        }
    }
}
