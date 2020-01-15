using System;

namespace poo_atividade_2
{
    class Relogio
    {
        private int horas, minutos, dia, mes, ano;

        public Relogio()
        {
            horas = minutos = 0;
            dia = mes = 01;
            ano = 2000;
        }
        public Relogio(int horas, int minutos, int dia, int mes, int ano)
        {
            this.horas = horas;
            this.minutos = minutos;
            this.dia = dia;
            this.mes = mes;
            this.ano = ano;
        }

        public void MostrarTempoData()
        {
            Console.WriteLine("Hora: " + horas + ":" + minutos + " | Dia: " + dia + "/" + mes + "/" + ano);
        }

        public void MudarHora(int h)
        {
            horas = h;
        }
        public void MudarMinutos(int m)
        {
            minutos = m;
        }
        public void MudarDia(int d)
        {
            dia = d;
        }
        public void MudarMes(int m)
        {
            mes = m;
        }
        public void MudarAno(int a)
        {
            ano = a;
        }
        public void ReiniciarRelogio()
        {
            horas = minutos = 0;
            dia = mes = 01;
            ano = 2000;
        }
    }
}
