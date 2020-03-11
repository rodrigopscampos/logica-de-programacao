using System;

namespace LogicaDeProgramacao.Lista2
{
    public class CalculadoraDeMediaSimples : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                  Validar.SaoIguais(2, () => Rodar(2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2))
               && Validar.SaoIguais(3, () => Rodar(10, 3, 0, -1))
               ;
        }

        public int Rodar(params int[] numeros)
        {
            int total = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                total += numeros[i];
            }
            return total / numeros.Length;
        }
    }
}
