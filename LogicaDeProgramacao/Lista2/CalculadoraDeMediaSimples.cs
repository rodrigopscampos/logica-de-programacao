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
        //RODAR ERRADO

        public int Rodar(params int[] numeros)
        {
            int somaDeTudo = 0;

            for(int i = 0; i < numeros.Length; i++){
                somaDeTudo += numeros[i];
            }
            return somaDeTudo/numeros.Length;
        }
    }
}
