using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacao.Lista1
{
    public class CalculadoraSomaDeTempos : IExercicio
    {
        private static Tuple<int, int, int> T(int a, int b, int c)
        {
            return new Tuple<int, int, int>(a, b, c);
        }

        public bool VerificarResposta()
        {
            return
                Validar.SaoIguais(
                    T(2, 2, 2),
                    () => Rodar(
                        1, 1, 1,
                        1, 1, 1
                        )
                    )

                &&

                Validar.SaoIguais(
                    T(2, 0, 0),
                    () => Rodar(
                        1, 0, 0,
                        0, 0, 3600
                        )
                    )

                &&

                Validar.SaoIguais(
                    T(7, 0, 0),
                    () => Rodar(
                        1, 0, 0,
                        0, 360, 0
                        )
                    )

                &&

                Validar.SaoIguais(
                    T(30, 30, 0),
                    () => Rodar(
                        0, 1800, 0,
                        0, 0, 1800
                        )
                    );
        }

        public Tuple<int, int, int> Rodar(
            int entradaHora1, int entradaMinuto1, int entradaSegundo1,
            int entradaHora2, int entradaMinuto2, int entradaSegundo2)
        {
            int chegada = getHourInSec(entradaHora1) + getMinInSec(entradaMinuto1) + entradaSegundo1;
            int saida = getHourInSec(entradaHora2) + getMinInSec(entradaMinuto2) + entradaSegundo2;

            int total = (chegada + saida);

            int saidaSegundo = total % 60;
            int saidaMinuto = total /60 % 60;
            int saidaHora = total / 60 / 60 % 60;

            //não remover esta linha
            return new Tuple<int, int, int>(saidaHora, saidaMinuto, saidaSegundo);
        }

        private int getHourInSec(int hora)
        {
            return hora * 60 * 60;
        }

        private int getMinInSec(int minutos)
        {
            return minutos * 60;
        }
    }
}
