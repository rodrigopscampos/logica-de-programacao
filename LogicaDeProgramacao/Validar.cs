using System;
using System.Linq.Expressions;

namespace LogicaDeProgramacao
{
    public static class Validar
    {
        public static bool SaoIguais(object esperado, Expression<Func<object>> atualExp)
        {
            try
            {
                var atual = atualExp.Compile().Invoke();

                if (esperado != atual && !esperado.Equals(atual))
                {
                    Console.WriteLine($"Divergencia. Esperado: '{esperado}' Atual: '{atual}'. Cenário: {atualExp}");
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu uma exceção:\r\n{ex}\r\nCenário: {atualExp}");
                return false;
            }
        }

        public static bool SaoIguais<T>(T[] esperado, Expression<Func<T[]>> atualExp)
        {
            try
            {
                var atual = atualExp.Compile().Invoke();

                if (esperado.Length != atual.Length)
                {
                    Console.WriteLine($"Divergencia. Tamanho diferente entre as coleções:");
                    Console.WriteLine($"Esperado: {string.Join(", ", esperado)}");
                    Console.WriteLine($"Atual   : {string.Join(", ", atual)}");
                    Console.WriteLine($"Cenário: {atualExp}");

                    return false;
                }

                for (int i = 0; i < esperado.Length; i++)
                {
                    if (!esperado[i].Equals(atual[i]))
                    {
                        Console.WriteLine($"Divergencia. As coleções estão diferentes:");
                        Console.WriteLine($"Esperado: {string.Join(", ", esperado)}");
                        Console.WriteLine($"Atual   : {string.Join(", ", atual)}");
                        Console.WriteLine($"Cenário: {atualExp}");

                        return false;
                    }
                }

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Ocorreu uma exceção:\r\n{ex}\r\nCenário: {atualExp}");
                return false;
            }
        }
    }
}
