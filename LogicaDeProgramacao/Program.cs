using LogicaDeProgramacao._2_Exercicios;
using LogicaDeProgramacao.Explicacoes;
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
            var explicacoes = PegarExplicacoes().ToArray();

            while (true)
            {
                Console.Clear();

                var numeroDeOpcoes = ApresentarExplicacoes(explicacoes);
                Console.WriteLine("Escolha uma explicação:");

                int opcaoEscolhida;
                while (!int.TryParse(Console.ReadLine(), out opcaoEscolhida) || opcaoEscolhida < 0 || opcaoEscolhida >= numeroDeOpcoes)
                {
                    Console.WriteLine("Opcao inválida");
                }

                explicacoes[opcaoEscolhida].Explicar();

                Console.WriteLine("-----------------------------");
                Console.WriteLine("Digite 'exit' para sair ou Enter para continuar");

                if (Console.ReadLine() == "exit")
                    return;
            }
        }

        static int ApresentarExplicacoes(IEnumerable<IExplicacao> explicacoes)
        {
            var i = 0;
            foreach (var e in explicacoes)
            {
                Console.WriteLine($"{i} - {e.GetType().Name}");

                i++;
            }

            return explicacoes.Count();
        }

        static IEnumerable<IExercicio> PegarExercicios()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var tipos = assembly.GetTypes()
                    .Where(t => t.IsClass)
                    .Where(t => typeof(IExercicio).IsAssignableFrom(t))
                    .ToArray();

            return tipos.Select(t => (IExercicio)Activator.CreateInstance(t)).ToArray();
        }

        static IEnumerable<IExplicacao> PegarExplicacoes()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var tipos = assembly.GetTypes()
                    .Where(t => t.IsClass)
                    .Where(t => typeof(IExplicacao).IsAssignableFrom(t))
                    .ToArray();

            return tipos.Select(t => (IExplicacao)Activator.CreateInstance(t)).ToArray();
        }
    }
}