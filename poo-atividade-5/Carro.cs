using System;

namespace poo_forms
{
    class Carro
    {
        static double tarifaBase;
        private string placa;
        private DateTime horaEntrada;
        private DateTime horaSaida;
        private int tipo;
        
        public string getPlaca() { return this.placa; }
        public int getTipo() { return this.tipo;  }
        public DateTime getHoraEntrada() { return this.horaEntrada; }
        public DateTime getHoraSaida() { return this.horaSaida; }

        static Carro()
        {
            tarifaBase = 9.00;
        }

        public Carro(string placa, DateTime data, int tipo)
        {
            this.placa = placa;
            this.horaEntrada = data;
            this.horaSaida = data;
            this.tipo = tipo;
        }

        public Carro(string placa)
        {
            this.placa = placa;
            this.horaEntrada = new DateTime(1, 1, 1, 0, 0, 0);
            this.horaSaida = new DateTime(1, 1, 1, 0, 0, 0);
        }

        public void setHoraEntrada(string hora, string min)
        {
            int h = int.Parse(hora);
            int m = int.Parse(min);
            this.setHoraEntrada(h, m);
        }

        public void setHoraEntrada(int hora, int min)
        {
            if (hora >= 0 && hora < 24 && min >= 0 && min < 60)
                this.horaEntrada = new DateTime(1, 1, 1, hora, min, 0);

        }

        public void setHoraSaida(DateTime hora)
        {
            this.horaSaida = hora;
        }

        private double calcTempoPassado()
        {
            TimeSpan chegada = horaSaida.Subtract(horaEntrada);
            return chegada.TotalHours;
        }

        public double tarifaAPagar()
        {
            double tarifa = tarifaBase * calcTempoPassado();

            if(this.tipo == 0) return tarifa = ((tarifa * 50) / 100);
            else if (this.tipo == 1) return tarifa += ((tarifa * 50) / 100);
            else return tarifa;
        }
    }
}
