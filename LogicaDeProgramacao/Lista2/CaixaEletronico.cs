using System;

namespace LogicaDeProgramacao.Lista2
{
    public class CaixaEletronico : IExercicio
    {
        /*
            Um caixa eletrônico entrega notas de 2, 5, 10, 20, 50 e 100 (as notas do Real)
            Ele deve entregar sempre as maiores notas, entergando notas menores apenas quando necessário.
            Exemplo: Para um saque de 30, deve entregar uma de 20 e outra de 10. Não se pode entregar 3 de 10.

            A representação da entrega deve ser feita na forma de um int[6]. 
            O valor do indice 1 é a quantidade de notas de 2
            O valor do indice 2 é a quantidade de notas de 5
            E assism vai até o indice 5 que é a quantidade de notas de 100.
        */

        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(new[] { 00, 00, 00, 02, 00, 00 }, () => Rodar(40))
                && Validar.SaoIguais(new[] { 03, 00, 00, 01, 01, 00 }, () => Rodar(76))
                && Validar.SaoIguais(new[] { 03, 01, 00, 02, 01, 09 }, () => Rodar(1001))
                ;
        }

        public int[] Rodar(int valor)
        {
            int notas100 = QuantidadeNotas(valor, 100);
            valor -= notas100 * 100;

            int notas50 = QuantidadeNotas(valor, 50);
            valor -= notas50 * 50;

            int notas20 = QuantidadeNotas(valor, 20);
            valor -= notas20 * 20;

            int notas10 = QuantidadeNotas(valor, 10);
            valor -= notas10 * 10;

            int notas5 = QuantidadeNotas(valor, 5);
            valor -= notas5 * 5;

            int notas2 = QuantidadeNotas(valor, 2);

            return new[] { notas2, notas5, notas10, notas20, notas50, notas100 };
        }
        
        private int QuantidadeNotas(int valor, int valorNota)
        {
            try
            {
                if (valor == 0)
                {
                    return 0;
                }
                int notas = valor / valorNota;
                // Como não existem notas de 1 real, o resto nunca pode ser 1;
                if ((valor % (notas * valorNota)) == 1)
                {
                    notas -= 1;
                }
                return notas;
            } catch (Exception)
            {
                return 0;
            }
        }
    }
}
