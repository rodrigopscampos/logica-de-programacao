using System;

namespace LogicaDeProgramacao.Lista2
{

    public class ValidarSeONumeroEPrimo : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                  Validar.SaoIguais(true, () => Rodar(1))
               && Validar.SaoIguais(false, () => Rodar(4))
               && Validar.SaoIguais(true, () => Rodar(7))
               && Validar.SaoIguais(false, () => Rodar(900000000))
               && Validar.SaoIguais(true, () => Rodar(999983));
        }

        public bool Rodar(int n)
        {
            bool resultado = true;
            for(int i = 2; i <= n/2; i++){

                    if(n % i == 0){
                        resultado = false;
                    }

            }
            return resultado;
        }
    }
}