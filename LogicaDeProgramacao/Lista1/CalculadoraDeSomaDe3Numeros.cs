using System;

namespace LogicaDeProgramacao.Lista1
{

    public class CalculadoraDeSomaDe3Numeros : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(3, () => Rodar(1, 1, 1))
                && Validar.SaoIguais(10, () => Rodar(9, 1, 0))
                && Validar.SaoIguais(0, () => Rodar(10, -11, 1));
        }

        public int Rodar(int a, int b, int c)
        {
            return a + b + c;
        }
    }

}