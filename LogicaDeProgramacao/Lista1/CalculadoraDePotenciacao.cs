using System;

namespace LogicaDeProgramacao.Lista1
{
    public class CalculadoraDePotenciacao : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(4, Rodar(2, 2))
                && Validar.SaoIguais(1, Rodar(2, 0));
        }

        public int Rodar(int @base, int potencia)
        {
            throw new NotImplementedException();
        }
    }

}
