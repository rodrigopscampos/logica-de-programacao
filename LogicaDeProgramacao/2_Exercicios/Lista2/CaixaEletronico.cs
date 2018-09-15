using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacao._2_Exercicios.Lista2
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
                   Validar.SaoIguais(new[] { 00, 00, 00, 02, 00, 00 }, Rodar(40))
                && Validar.SaoIguais(new[] { 01, 05, 00, 02, 01, 00 }, Rodar(76))
                && Validar.SaoIguais(new[] { 01, 00, 00, 00, 00, 10 }, Rodar(1001))
                ;
        }

        public int[] Rodar(int valor)
        {
            throw new NotImplementedException();
        }
    }
}
