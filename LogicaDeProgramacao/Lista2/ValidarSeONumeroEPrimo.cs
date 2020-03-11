using System;

namespace LogicaDeProgramacao.Lista2
{

    public class ValidarSeONumeroEPrimo : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                  Validar.SaoIguais(true, () => Rodar(1))
               && Validar.SaoIguais(false, () => Rodar(4))
               && Validar.SaoIguais(true, () => Rodar(7))
               && Validar.SaoIguais(false, () => Rodar(900000000))
               && Validar.SaoIguais(true, () => Rodar(999983));
        }

        public bool Rodar(int n)
        {
            return Primo(n);
        }

        private bool Primo(double x)
        {
            for (int i = 2; i < x; i++)
            {
                //Se o resto da divisão for zero, o número é divisivel por i portanto não é primo.
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}