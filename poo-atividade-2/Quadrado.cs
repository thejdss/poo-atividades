namespace poo_atividade_2
{
    class Quadrado
    {
        private int lado;

        public int Lado
        {
            get { return lado; }
            set { lado = value; }
        }

        public Quadrado()
        {
            lado = 0;
        }

        public Quadrado(int lado)
        {
            this.lado = lado;
        }
    }
}
