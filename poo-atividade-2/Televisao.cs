namespace poo_atividade_2
{
    class Televisao
    {
        public bool ligada = false;
        public int volume;
        public int canal;
        
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
