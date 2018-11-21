using System;

namespace LogicaDeProgramacao.Lista1
{
    public class IdentificadorDeIdade : IExercicio
    {
        /*
            Data a idade de uma pessoa, deve retornar qual a faixa etária de acordo com a tabela abaixo:

            * Infantil = até 10 anos
            * Infanto = 11 a 15 anos
            * Juvenil = 16 a 18 anos
            * Adulto = maiores de 18 anos
        */

        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais("Adulto", Rodar(19))
                && Validar.SaoIguais("Juvenil", Rodar(18))
                && Validar.SaoIguais("Infantil", Rodar(10))
                && Validar.SaoIguais("Infantiil", Rodar(0))
                && Validar.SaoIguais("Adulto", Rodar(60));
        }

        public string Rodar(int idade)
        {
            throw new NotImplementedException();
        }
    }
}
