using System;

namespace LogicaDeProgramacao._2_Exercicios.Lista2
{
    public class CalculadoraDeMediaSimples : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                  Validar.SaoIguais(2, Rodar(2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2))
               && Validar.SaoIguais(6, Rodar(10, 3, 0, -1))
               ;
        }

        public int Rodar(params int[] numeros)
        {
            throw new NotImplementedException();
        }
    }
}
