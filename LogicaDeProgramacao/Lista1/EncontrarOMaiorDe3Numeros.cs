using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacao.Lista1
{
    public class EncontrarOMaiorDe3Numeros : IExercicio
    {
        /*
            Deve encontrar o maior dos 3 números  (a, b, c)
        */

        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(3, () => Rodar(3, 2, 1))
                && Validar.SaoIguais(3, () => Rodar(1, 2, 3))
                && Validar.SaoIguais(3, () => Rodar(1, 3, 2))
                ;
        }

        public int Rodar(int a, int b, int c)
        {
            int maior = a;
            if (b > maior)
            {
                maior = b;
            }
            if (c > maior)
            {
                maior = c;
            }
            return maior;
        }
    }
}
