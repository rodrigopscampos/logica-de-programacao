using System;

namespace LogicaDeProgramacao
{
    public static class Validar
    {
        public static bool SaoIguais(object esperado, object atual)
        {
            if (esperado != atual && !esperado.Equals(atual))
            {
                Console.WriteLine($"Divergencia. Esperado: '{esperado}' Atual: '{atual}'");
                return false;
            }

            return true;
        }

        public static bool SaoIguais<T>(T[] esperado, T[] atual)
        {
            if (esperado.Length != atual.Length)
            {
                Console.WriteLine($"Divergencia. Tamanho diferente entre as coleções:");
                Console.WriteLine($"Esperado: {string.Join(", ", esperado)}");
                Console.WriteLine($"Atual   : {string.Join(", ", atual)}");

                return false;
            }

            for (int i = 0; i < esperado.Length; i++)
            {
                if (!esperado[i].Equals(atual[i]))
                {
                    Console.WriteLine($"Divergencia. As coleções estão diferentes:");
                    Console.WriteLine($"Esperado: {string.Join(", ", esperado)}");
                    Console.WriteLine($"Atual   : {string.Join(", ", atual)}");

                    return false;
                }
            }

            return true;
        }
    }
}
