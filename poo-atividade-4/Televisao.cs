namespace poo_atividade_4
{
    class Televisao
    {
        private bool ligada = false;
        private int volume;
        private int canal;

        public bool Ligada { get { return ligada; } }
        public int Volume { get { return volume; } }
        public int Canal { get { return canal; } }

        public void BotaoLigaDesliga()
        {
            if (!ligada)
                ligada = true;
            else
                ligada = false;
        }

        public void TrocarCanal(bool botao)
        {
            if (ligada)
                if (botao)
                {
                    if (canal < 83)
                        canal++;
                    else canal = 1;
                }
                else
                {
                    if (canal > 1)
                        canal--;
                    else canal = 83;
                }
        }

        public void Volume(bool botao)
        {
            if (ligada)
                if (botao)
                {
                    if (volume < 100)
                        volume++;
                }
                else
                {
                    if (volume > 0)
                        volume--;
                }
        }
    }
}