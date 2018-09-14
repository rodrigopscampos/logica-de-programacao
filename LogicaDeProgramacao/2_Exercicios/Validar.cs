using System;

namespace LogicaDeProgramacao._2_Exercicios
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
    }
}
