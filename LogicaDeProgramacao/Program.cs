using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace LogicaDeProgramacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var exercicios = PegarExercicios().ToArray();

            while (true)
            {
                Console.Clear();

                var numeroDeOpcoes = ApresentarExercicios(exercicios);
                Console.WriteLine("Escolha um exercício:");

                int opcaoEscolhida;
                while (!int.TryParse(Console.ReadLine(), out opcaoEscolhida) || opcaoEscolhida < 0 || opcaoEscolhida >= numeroDeOpcoes)
                {
                    Console.WriteLine("Opcao inválida");
                }

                Console.Clear();

                exercicios[opcaoEscolhida].VerificarResposta();

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Digite 'exit' para sair ou Enter para continuar");

                if (Console.ReadLine() == "exit")
                    return;
            }
        }

        static int ApresentarExercicios(IEnumerable<IExercicio> exercicios)
        {
            var i = 0;

            foreach (var e in exercicios)
            {
                Console.WriteLine(string.Format("{0, 3} - {1}", i, e.GetType().FullName));
                i++;
            }

            return exercicios.Count();
        }

        static IEnumerable<IExercicio> PegarExercicios()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var tipos = assembly.GetTypes()
                    .Where(t => t.IsClass)
                    .Where(t => typeof(IExercicio).IsAssignableFrom(t))
                    .OrderBy(t => t.FullName)
                    .ToArray();

            return tipos.Select(t => (IExercicio)Activator.CreateInstance(t)).ToArray();
        }
    }
}