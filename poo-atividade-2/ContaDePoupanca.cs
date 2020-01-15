using System;

namespace poo_atividade_2
{
    class ContaDePoupanca
    {
        private static float taxaDeJurosAnual;
        private float saldoPoupanca;

        public ContaDePoupanca(float saldoPoupanca)
        {
            this.saldoPoupanca = saldoPoupanca;
        }

        public static void AlterarTaxaDeJuros(float novaTaxa)
        {
            taxaDeJurosAnual = novaTaxa;
        }

        public void Saldo()
        {
            Console.WriteLine(saldoPoupanca);

        }

        public void CalcularJurosMensais()
        {
            saldoPoupanca += ((saldoPoupanca * taxaDeJurosAnual) / 12);
        }

    }
}
