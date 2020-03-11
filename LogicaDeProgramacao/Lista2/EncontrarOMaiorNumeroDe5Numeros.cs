using System;

namespace LogicaDeProgramacao.Lista2
{
    public class EncontrarOMaiorNumeroDe5Numeros : IExercicio
    {
        /*
            Deve encontrar o maior dos 5 números  (a, b, c, d, e)
        */

        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(10, () => Rodar(1, 3, 2, 10, -10))
                && Validar.SaoIguais(5, () => Rodar(4, 3, 2, 2, 5))
                && Validar.SaoIguais(-100, () => Rodar(-100, -200, -100, -101, -200))
                ;
        }

        public int Rodar(int a, int b, int c, int d, int e)
        {
            int maior = a;
            if (b > maior) maior = b;
            if (c > maior) maior = c;
            if (d > maior) maior = d;
            if (e > maior) maior = e;

            return maior;
        }
    }
}
