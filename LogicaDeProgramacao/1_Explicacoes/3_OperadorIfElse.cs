using System;

namespace LogicaDeProgramacao.Explicacoes
{
    public class OperadorIfElse : IExplicacao
    {
        public void Explicar()
        {
            Console.WriteLine
                (
                @"
Visite 'https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/if-else'

O operador if else serve para tomar uma decisão, de acordo com uma operação booleana.
Se for verdade faça isso, senão faça aquilo.

Exemplo:
    int a = DateTime.Now.Second; //Esta instrução vai atribuir a variável 'a' o segundo exato do horário da máquina.

    if(a > 40) 
    {
        Console.WriteLine('O segundo do relógio é MAIOR que 40'); 
    }
    else if (a > 30)
    { 
        Console.WriteLine('O segundo do relógio está entre 31 e 40'); 
    }
    else if(a > 20)
    {
        Console.WriteLine('O segundo do relógio está entre 21 e 30');
    }
    else
    { 
        Console.WriteLine('O segundo do relógio é MENOR OU IGUAL a 20');
    }


Também temos uma forma 'encolhida' de escrever um if else chamada Operador ternário.
Basicamente escrevemos uma pergunta, adicionamos uma '?', dizemos o que fazer se for verdade, adicionamos um ':' e dizemos o que fazer se for mentida.


Exemplo:

    if(a > 5)
    {
        Console.WriteLine('É maior que 5');
    }
    else
    {
        Console.WriteLine('NÃO é maior que 5');
    }

    a > 5 ? Console.WriteLine('É maior que 5') : Console.WriteLine('NÃO é maior que 5');

    
Outro Exemplo:

    int a = 1;
    int b = -1;
    int c = DateTime.Now.Second;

    int d = c >= 30 ? a : b; //d será igual a 'a' se c for MAIOR OU IGUAL a 30, caso contrário será igual a 'b'.
");
        }
    }
}
