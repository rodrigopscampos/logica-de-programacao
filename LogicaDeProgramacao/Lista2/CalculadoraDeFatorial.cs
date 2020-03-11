using System;

namespace LogicaDeProgramacao.Lista2
{

    public class CalculadoraDeFatorial : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(2, () => Rodar(2))
                && Validar.SaoIguais(6, () => Rodar(3))
                && Validar.SaoIguais(3628800, () => Rodar(10))
                && Validar.SaoIguais(3628800, () => Rodar(10))
                && Validar.SaoIguais(1, () => Rodar(0));
        }

        public float Rodar(int n)
        {
            var resultado = 1;
            for(var i = n; i > 1; i--){
                resultado = resultado * i;
            }
            return resultado;
        }
    }

}