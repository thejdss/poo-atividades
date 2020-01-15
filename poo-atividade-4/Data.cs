using System;

namespace poo_atividade_4
{
    class Data
    {
        //aloquei o zero no vetor para ter os meses corretos.
        private int[] diasMes = { 01, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private int dia;
        private int mes;
        private int ano;

        public int Dia { get { return dia; } }
        public int Mes { get { return mes; } }
        public int Ano { get { return ano; } }

        public Data()
        {
            dia = mes = 01;
            ano = 2000;
        }

        public bool ValidarData()
        {
            if (mes < 1 || mes > 12)
                return false;
            else if (ano < 1)
                return false;
            else if (dia < 1 || dia > diasMes[mes])
                return false;
            else return true;
        }

        /// <summary>
        /// Mostra data armazenada nesse objeto.
        /// </summary>
        public void MostrarData()
        {
            Console.WriteLine("{0}/{1}/{2}", dia, mes, ano);
        }
    }
}