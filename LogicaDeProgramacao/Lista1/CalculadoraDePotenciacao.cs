using System;

namespace LogicaDeProgramacao.Lista1
{
    public class CalculadoraDePotenciacao : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(4, () => Rodar(2, 2))
                && Validar.SaoIguais(1, () => Rodar(2, 0))
                && Validar.SaoIguais(1000, () => Rodar(10, 3))
                ;
        }

        public int Rodar(int num, int potencia)
        {
            return (int) Math.Pow(num, potencia);
        }
    }
}
