using System;

namespace LogicaDeProgramacao.Explicacoes
{
    public class Variaveis : IExplicacao
    {
        public void Explicar()
        {
            Console.WriteLine(@"

                Uma variável é um espaço na memória que pode armazenar um dado.

                No C#, as variáveis tem tipo, que representa o tipo de dado que ela pode armazenar como um número, um caracter, um data e etc.

                Os principais tipos são:
                
                int:   Número inteiro entre -2.147.483.648 e 2.147.483.647
                long:  Número inteiro entre -9.223.372.036.854.775.808 e 9.223.372.036.854.775.807
                
                float:  Número racional com 7 casa decimais
                double: Número racional com 15 a 16 casas decimais
                decimal: Número racional com 28 a 29 casas decimais

                char: Um caracter
                string: Um conjunto de caracteres, um texto.

                DateTime: Uma Data
                Timespam: Um intervalo de tempo. Ex: 00:10:00 (10 minutos)

                
                Exemplos:
                    int a = 10;
                    int b = 10;
                    int c = a + b; // c será igual a 20.

                    float d = 1.1;
                    float e = 0.1;
                    float f = d + e; // f será igual a 1.2.

                    string g = 'Olá';
                    string h = ' Mundo!';
                    string i = g + h; // i será igual a 'Olá Mundo!'.

                    Podemos utilizar uma série de operadores para interagir com as variáveis como > >= < <= != + - * /
                ");
        }
    }
}