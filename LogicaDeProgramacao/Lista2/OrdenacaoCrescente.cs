using System;
using System.Linq;
namespace LogicaDeProgramacao.Lista2
{
    public class OrdenacaoCrescente : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(new[] { 1, 2, 3, 4, 5 }, () => Rodar(5, 4, 3, 2, 1))
                && Validar.SaoIguais(new[] { -1, 10, 100 }, () => Rodar(10, 100, -1))
                && Validar.SaoIguais(new[] { -1, 0, 0, 1 }, () => Rodar(0, 1, 0, -1))
                ;
        }

        public int[] Rodar(params int[] array)
        {
            return array.OrderBy(p => p).ToArray();
        }
    }
}
