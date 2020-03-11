﻿using System;

namespace LogicaDeProgramacao.Lista2
{
    public class CalculadoraDeIdadeEmDias : IExercicio
    {
        /*
         Converte para dias a idade de uma pessoa, considerando que um ano tem 365 dias e um mes tem 30
        */

        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(365, () => Rodar(1, 0, 0))
                && Validar.SaoIguais(366, () => Rodar(1, 0, 1))
                && Validar.SaoIguais(396, () => Rodar(1, 1, 1))
                && Validar.SaoIguais(3564, () => Rodar(9, 9, 9))
                ;
        }

        public int Rodar(int anos, int meses, int dias)
        {
            int diasConvertidos = 0;
            diasConvertidos += anos*365;
            diasConvertidos += meses*30;
            diasConvertidos += dias;
            return diasConvertidos;
        }
    }
}
