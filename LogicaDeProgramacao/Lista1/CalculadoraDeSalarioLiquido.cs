using System;

namespace LogicaDeProgramacao.Lista1
{
    public class CalculadoraDeSalarioLiquido : IExercicio
    {

        /*
         Deve pegar o salário bruto de um funcionário e calcular o salário liquido de acordo com as regras abaixo:
          * Se inferior a R$300,00 é descontado 5% em impostos.
          * Se variar de R$ 300,00 até 1.200,00 é descontado 10% em impostos, 
          * Se for superior a R$ 1.200,00 é descontado 15% em impostos.
          * Se for superior a R$ 10.000,00 é descontado 15% em impostos e mais 1% sobre o remanescente de taxas bancárias
        */

        public bool VerificarResposta()
        {
            return
                   Validar.SaoIguais(95, () => Rodar(100))
                && Validar.SaoIguais(900, () => Rodar(1000))
                && Validar.SaoIguais(7650, () => Rodar(9000))
                && Validar.SaoIguais(16830, () => Rodar(20000));
        }

        public decimal Rodar(decimal salarioBruto)
        {
            throw new NotImplementedException();
        }
    }
}
