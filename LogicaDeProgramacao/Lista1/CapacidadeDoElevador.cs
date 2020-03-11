using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacao.Lista1
{
    public class CapacidadeDoElevador : IExercicio
    {
        /*
            Quantas pessoas de peso 'p', um elevador de capacidade 'c' pode carregar ?
            
            Exemplo: 
            Um elevador de capacidade 200, pode carregar 2 pessoas de peso 100 ou 4 pessoas de peso 50
        */

        public bool VerificarResposta()
        {
            return
                  Validar.SaoIguais(10, () => Rodar(1000, 100))
               && Validar.SaoIguais(10, () => Rodar(1000, 99))
               && Validar.SaoIguais(11, () => Rodar(1000, 90))
               && Validar.SaoIguais(1, () => Rodar(100, 100))
               && Validar.SaoIguais(0, () => Rodar(100, 101))
               && Validar.SaoIguais(0, () => Rodar(0, 1));
        }

        public int Rodar(int c, int p)
        {
            return (int)Math.Round((double)(c/p));
        }
    }
}
