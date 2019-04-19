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
            int saidaHora = 0;
            int saidaMinuto = 0;
            int saidaSegundo = 0;

            //apague este comentário e implemente a algoritmo aqui.
            //você deve preencher as variáveis saidaHora, saidaMinuto e saidaSegundo com os valores corretos


            //não remover esta linha
            return new Tuple<int, int, int>(saidaHora, saidaMinuto, saidaSegundo);
        }
    }
}
