using System;

namespace poo_atividade_4
{
    class Alarme
    {
        private bool despertar, soneca;
        private bool[] diasParaDespertar = new bool[7];

        private int hora { get { return hora; } set { if (value > 0) hora = value; } }
        private int minuto { get { return minuto; } set { if (value > 0 && value < 60) minuto = value; } }
        private int qtdSoneca { get { return qtdSoneca; } set { if (value > 0 && value < 60) qtdSoneca = value; } }
        public bool HoraDeDespertar { get { return despertar; } }

        public void DeterminarHora(int h)
        {
            hora = h;
        }

        public void DeterminarMinuto(int m)
        {
            minuto = m;
        }

        public void ColocarDia(string n)
        {
            switch (n)
            {
                case "Domingo":
                    diasParaDespertar[0] = true;
                    break;

                case "Segunda":
                    diasParaDespertar[1] = true;
                    break;

                case "Terça":
                    diasParaDespertar[2] = true;
                    break;

                case "Quarta":
                    diasParaDespertar[3] = true;
                    break;

                case "Quinta":
                    diasParaDespertar[4] = true;
                    break;

                case "Sexta":
                    diasParaDespertar[5] = true;
                    break;

                case "Sabado":
                    diasParaDespertar[6] = true;
                    break;
            }
        }

        public void RetirarDia(string n)
        {
            switch (n)
            {
                case "Domingo":
                    diasParaDespertar[0] = false;
                    break;

                case "Segunda":
                    diasParaDespertar[1] = false;
                    break;

                case "Terça":
                    diasParaDespertar[2] = false;
                    break;

                case "Quarta":
                    diasParaDespertar[3] = false;
                    break;

                case "Quinta":
                    diasParaDespertar[4] = false;
                    break;

                case "Sexta":
                    diasParaDespertar[5] = false;
                    break;

                case "Sabado":
                    diasParaDespertar[6] = false;
                    break;
            }
        }

        public void Despertar()
        {
            if (soneca)
            {
                int aux = minuto + qtdSoneca;

                ConfereHora(hora, aux, diasParaDespertar);
            }
            else ConfereHora(hora, minuto, diasParaDespertar);
        }

        public void ConfereHora(int minhaHora, int meuMinuto, bool[] dias)
        {
            DateTime localDate = DateTime.Now;

            if (localDate.Hour.Equals(minhaHora))
            {
                if (localDate.Minute.Equals(meuMinuto))
                {
                    int aux = GetDayOfWeek(localDate.DayOfWeek);

                    if (dias[aux])
                        LigarDespertador();
                }
            }
        }

        public void DesligarDespertador()
        {
            despertar = false;
        }

        public void LigarDespertador()
        {
            despertar = true;
        }

        public void AtivarSoneca()
        {
            soneca = true;
        }

        public void TamanhoDaSoneca(int m)
        {
            qtdSoneca = m;
        }

        public void DesativarSoneca()
        {
            soneca = false;
        }

        private int GetDayOfWeek(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday:
                    return 0;

                case DayOfWeek.Monday:
                    return 1;

                case DayOfWeek.Tuesday:
                    return 2;

                case DayOfWeek.Wednesday:
                    return 3;

                case DayOfWeek.Thursday:
                    return 4;

                case DayOfWeek.Friday:
                    return 5;

                case DayOfWeek.Saturday:
                    return 6;

                default:
                    return 0;
            }
        }
    }
}
