using System;

namespace LogicaDeProgramacao.Explicacoes
{
    public class LogicaBooleanaEOperadoresAritmeticos : IExplicacao
    {
        public void Explicar()
        {
            Console.WriteLine(@"

                Lógica booleana é a lógica do verdadeiro ou falso e das operações de and (e) e or (ou)

                Exemplos: 
                    Verdade que 1 + 1 == 2
                    Falso que 1 > 2
                    Verdade que 1 * 0 == 0
                    Falso que 2 / 2 == 2
                    
                    Verdade que 1 + 1 == 3 OU 1 - 1 == 0
                    Falso   que 1 + 1 == 3 E  1 - 1 == 0

                    Os operadores booleanos são:
                    
                    < menor
                    <= menor ou igual

                    > maior
                    >= maior ou igual

                    != diferente

                Os operadores aritméticos são:
                    + mais
                    - menos
                    * vezes
                    / dividir
                    % resto
            ");
        }
    }
}
