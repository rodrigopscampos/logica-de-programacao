namespace LogicaDeProgramacao._2_Exercicios
{
    public class Ex1_CalculadoraDePotenciacao : IExercicio
    {
        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(4, Rodar(2, 2))
                && Validar.SaoIguais(1, Rodar(2, 0));
        }

        public int Rodar(int @base, int potencia)
        {
            //Implemente a solução aqui
            return 0;
        }
    }
}
