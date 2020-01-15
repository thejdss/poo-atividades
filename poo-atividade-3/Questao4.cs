using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace poo_atividade_3
{
    class Questao4
    {
        public void LeituraVotos()
        {
            // caminho do texto no PC
            string votos = @"C:/projetos/visual/poo-atividade-3/poo-atividade-3/poo-atividade-3/texto/Votos.txt";

            // array com o tamanho dos arquivos que vão ser lidos
            int[] votosArray = new int[85];

            // Leitura do Arquivo
            if (File.Exists(votos))
            {
                Console.WriteLine("Lendo arquivo -Votos.txt-");
                StreamReader arquivoAberto = new StreamReader(votos, Encoding.ASCII);

                string linha = arquivoAberto.ReadLine();
                int i = 0;

                while (linha != null)
                {
                    votosArray[i] = int.Parse(linha);
                    i++;

                    linha = arquivoAberto.ReadLine();
                }

                arquivoAberto.Close();
            }

            // Lógica
            float[] votosConfirmados = new float[5]; //Votos num array
            for (int i = 0; i < votosArray.Length; i++)
            {
                // De acordo com arquivo lido é somado no confirmado
                switch (votosArray[i])
                {
                    case 1:
                        votosConfirmados[0]++;
                        break;

                    case 2:
                        votosConfirmados[1]++;
                        break;

                    case 3:
                        votosConfirmados[2]++;
                        break;

                    case 4:
                        votosConfirmados[3]++;
                        break;

                    case 5:
                        votosConfirmados[4]++;
                        break;

                    default:
                        votosConfirmados[4]++;
                        break;
                }
            }
            float somaTotalVotos = votosConfirmados[0] + votosConfirmados[1] + votosConfirmados[2] + votosConfirmados[3] + votosConfirmados[4]; //todos os votos
            // porcentagem dos votos
            votosConfirmados[0] = votosConfirmados[0] / somaTotalVotos * 100;
            votosConfirmados[1] = votosConfirmados[1] / somaTotalVotos * 100;
            votosConfirmados[2] = votosConfirmados[2] / somaTotalVotos * 100;

            // escrevendo na tela valores
            Console.WriteLine("Votos Candidato 1: {0}% dos votos", votosConfirmados[0].ToString("F"));
            Console.WriteLine("Votos Candidato 2: {0}% dos votos", votosConfirmados[1].ToString("F"));
            Console.WriteLine("Votos Candidato 3: {0}% dos votos", votosConfirmados[2].ToString("F"));
            Console.WriteLine("Votos Nulos: {0}", votosConfirmados[3]);
            Console.WriteLine("Votos Indecisos: {0}", votosConfirmados[4]);
            Console.WriteLine("Total de Votos: {0}", somaTotalVotos);
        }

    }
}
