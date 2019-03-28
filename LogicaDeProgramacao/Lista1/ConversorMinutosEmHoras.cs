using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacao.Lista1
{
    public class ConversorMinutosEmHoras : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                  Validar.SaoIguais(1, () => Rodar(60))
               && Validar.SaoIguais(1.5, () => Rodar(90))
               && Validar.SaoIguais(2, () => Rodar(120))
               && Validar.SaoIguais(1.75, () => Rodar(105));
        }

        public double Rodar(int minutos)
        {
            throw new NotImplementedException();
        }
    }
}
