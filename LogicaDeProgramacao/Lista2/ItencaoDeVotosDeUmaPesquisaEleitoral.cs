﻿using System;

namespace LogicaDeProgramacao.Lista2
{
    public class ItencaoDeVotosDeUmaPesquisaEleitoral : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(new[] { 25, 25, 25, 25 }, () => Rodar(1, 1, 1, 1))
                && Validar.SaoIguais(new[] { 33, 2, 15, 50 }, () => Rodar(66, 4, 30, 100))
                && Validar.SaoIguais(new[] { 0, 50, 25, 25 }, () => Rodar(0, 30, 15, 15))
                ;
        }

        public int[] Rodar(int c1, int c2, int c3, int c4)
        {
            throw new NotImplementedException();
        }
    }
}
