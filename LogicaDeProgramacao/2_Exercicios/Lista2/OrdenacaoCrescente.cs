using System;

namespace LogicaDeProgramacao._2_Exercicios.Lista2
{
    public class OrdenacaoCrescente : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(new[] { 1, 2, 3, 4, 5 }, new[] { 5, 4, 3, 2, 1 })
                && Validar.SaoIguais(new[] { -1, 10, 100 }, new[] { 10, 100, -1 })
                && Validar.SaoIguais(new[] { -1, 0, 0, 1 }, new[] { 0, 1, 0, -1 })
                ;
        }

        public int[] Rodar(params int[] array)
        {
            throw new NotImplementedException();
        }
    }
}
