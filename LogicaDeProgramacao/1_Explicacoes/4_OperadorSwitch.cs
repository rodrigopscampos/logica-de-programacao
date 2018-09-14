using System;

namespace LogicaDeProgramacao.Explicacoes
{
    public class OperadorSwitch : IExplicacao
    {
        public void Explicar()
        {
            Console.WriteLine(@"
    O operador switch veio para simplificar o encadeamento de if else que procuram por um valor exato.

    Exemplo utilizando if:
    
    int i = 5;

    if(i == 2 || i == 4 || i == 6 || i == 8) Console.WriteLine('Par');
    else if(i == 1 || i == 3 || i == 5 || i == 7 || i == 9) Console.WriteLine('Impar');
    else if (i == 0) Console.WriteLine('Zero');
    else Console.WriteLine('Maior que 9');

    Utilizando switch:

            int i = 5;
            switch (i)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                    Console.WriteLine('Impar');
                    break;

                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine('Par');
            break;

                case 0:
                    Console.WriteLine('Zero');
            break;

            default:
                    Console.WriteLine('Maior que 9');
            break;
        }
");
        }
    }
}
