using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace poo_forms
{
    public partial class Form1 : Form
    {
        const int TOTALVAGAS = 40;
        List<Carro> estacionamento;
        int contCarros;
        int tipo;

        public Form1()
        {
            estacionamento = new List<Carro>();
            contCarros = 0;
            tipo = 0;
            InitializeComponent();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            int auxPos = lbCarros.SelectedIndex;

            if (auxPos == -1)
            {
                lblVagas.Text = "Selecione um veículo para ser retirado";
            }
            else
            {
                estacionamento[auxPos].setHoraSaida(DateTime.Now);
                string placa = estacionamento[auxPos].getPlaca();
                double valAux = estacionamento[auxPos].tarifaAPagar();
                lblVagas.Text = (tipoVeiculo(estacionamento[auxPos].getTipo()) + " - " + placa + " | Foi Retirado | " + estacionamento[auxPos].getHoraEntrada().ToShortTimeString() + " | " +
                   estacionamento[auxPos].getHoraSaida().ToShortTimeString() + " | " + String.Format("{0:c}", valAux));

                estacionamento.RemoveAt(auxPos);

                lbCarros.Items.Clear();
                for (int i = 0; i < estacionamento.Count; i++)
                {
                    lbCarros.Items.Add(tipoVeiculo(estacionamento[i].getTipo()) + " - " + estacionamento[i].getPlaca() + " | " +
                    estacionamento[i].getHoraEntrada().ToShortTimeString());
                }
                
                this.contCarros--;
            }
        }

        private void btnCarroAdicionar_Click(object sender, EventArgs e)
        {
            if(this.tipo <= 2)
            {
                string auxPlaca = mtxPlaca.Text;
                Carro novoCarro = new Carro(auxPlaca, DateTime.Now, this.tipo);

                if (contCarros < TOTALVAGAS)
                {
                    estacionamento.Add(novoCarro);
                    contCarros++;
                    lblVagas.Text = "Veículos Estacionado " + contCarros;
                }
                else
                {
                    lblVagas.Text = "Estacionamento cheio, tem " + contCarros + " carros";
                }

                mtxPlaca.Clear();
                mtxPlaca.Focus();
            }
            else lblVagas.Text = "Tipo de veículo inválido";
        }

        private void checkBoxG_CheckedChanged(object sender, System.EventArgs e)
        {
            checkBoxG.Checked = true;
            checkBoxM.Checked = false;
            checkBoxP.Checked = false;

            this.tipo = 1;
        }
        private void checkBoxP_CheckedChanged(object sender, System.EventArgs e)
        {
            checkBoxP.Checked = true;
            checkBoxG.Checked = false;
            checkBoxM.Checked = false;

            this.tipo = 2;
        }
        private void checkBoxM_CheckedChanged(object sender, System.EventArgs e)
        {
            checkBoxM.Checked = true;
            checkBoxG.Checked = false;
            checkBoxP.Checked = false;

            this.tipo = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if(estacionamento.Count > 0)
            {
                lbCarros.Items.Clear();
                for (int i = 0; i < estacionamento.Count; i++)
                {
                    lbCarros.Items.Add(tipoVeiculo(estacionamento[i].getTipo()) + " - " + estacionamento[i].getPlaca() + " | " +
                        estacionamento[i].getHoraEntrada().ToShortTimeString());
                }
            }
            else
            {
                lblVagas.Text = "Não há veículos estacionados";
            }
        }

        private void btnCalcularValores_Click(object sender, EventArgs e)
        {
            DateTime agora = DateTime.Now;
            int auxPos = lbCarros.SelectedIndex;

            if (auxPos == -1){
                lblVagas.Text = "Selecione um veículo para calcular seu valor";
            }
            else
            {
                estacionamento[auxPos].setHoraSaida(DateTime.Now);
                string placa = estacionamento[auxPos].getPlaca();
                double valAux = estacionamento[auxPos].tarifaAPagar();
                lbCarros.Items[auxPos] = (tipoVeiculo(estacionamento[auxPos].getTipo()) + " - " + placa + " | " + estacionamento[auxPos].getHoraEntrada().ToShortTimeString() + " | " +
                   estacionamento[auxPos].getHoraSaida().ToShortTimeString() + " | " + String.Format("{0:c}", valAux));
            }

        }

        private void mtxPlaca_Enter(object sender, EventArgs e) {
            mtxPlaca.Clear();
        }

        private string tipoVeiculo(int tipo)
        {
            switch (tipo)
            {
                case 0:
                    return "Moto";

                case 1:
                    return "Grande";

                case 2:
                    return "Pequeno";

                default:
                    return "Falha";
            }
        }
    }
}
