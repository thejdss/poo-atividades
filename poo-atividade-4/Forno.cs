using System.Diagnostics;
using System;

namespace poo_atividade_4
{
    class Forno
    {
        private int minuto { get { return minuto; } set { if (value >= 0 && value < 60) minuto = value; } }
        private int segundo { get { return segundo; } set { if (value >= 0 && value < 60) segundo = value; } }
        private int potencia { get { return potencia; } set { if (value > 0 && value <= 10) potencia = value; } }

        private bool portaAberta;

        public void LigarForno()
        {
            if (!portaAberta)
            {

            }
        }

        public void Zerar()
        {
            minuto = segundo = 0;
        }

        public void DefinirPotencia(int p)
        {
            potencia = p;
        }

        public void DefinirSegundos(int s)
        {
            segundo = s;
        }

        public void DefinirMinuto(int m)
        {
            minuto = m;
        }

        public void AbrirPorta()
        {
            portaAberta = true;
        }

        public void FecharPorta()
        {
            portaAberta = false;
        }

    }
}
