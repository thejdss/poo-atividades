using System.Collections.Generic;
using System.Text;
using System.IO;
using System;

namespace poo_atividade_3
{
    class Questao2
    {
        public void DescontoDosVendedores()
        {
            // Lista com a classe de usuários
            List<Usuarios> compradores = new List<Usuarios>();

            // caminho do arquivo no pc.
            string localArquivo = @"C:/projetos/visual/poo-atividade-3/poo-atividade-3/poo-atividade-3/texto/vendasClientes.txt";
            string novoArquivo = @"C:/projetos/visual/poo-atividade-3/poo-atividade-3/poo-atividade-3/texto/descontosClientes.txt";

            // extração de dados do arquivo
            if (File.Exists(localArquivo))
            {
                Console.WriteLine("Lendo arquivo -vendasClientes.txt-");
                StreamReader arquivoAberto = new StreamReader(localArquivo, Encoding.ASCII);

                string linha = arquivoAberto.ReadLine();

                while (linha != null)
                {
                    string[] dadosDaLinha = linha.Split('-'); // Partindo a linha com os dados inseridos de acordo com o -
                    // Atribuindo os dados da linha direto na instancia aux
                    Usuarios aux = new Usuarios
                    {
                        nome = dadosDaLinha[0],
                        valor = float.Parse(dadosDaLinha[1])
                    };
                    compradores.Add(aux); // adicionando essa instancia na lista
                    linha = arquivoAberto.ReadLine(); // lendo uma nova linha
                }

                // aplicando desconto no valor dos clientes
                for (int i = 0; i < compradores.Count; i++)
                {
                    if (compradores[i].valor > 1800)
                    {
                        compradores[i].valor = compradores[i].valor * 0.8f; // 20%
                    }
                    else
                        compradores[i].valor = compradores[i].valor * 0.75f; // 15%
                }

                arquivoAberto.Close();
            }

            // Escrevendo os dados no novo arquivo
            StreamWriter novo = new StreamWriter(novoArquivo, false, Encoding.ASCII);
            for (int i = 0; i < compradores.Count; i++)
            {
                novo.WriteLine("{0}-{1}", compradores[i].nome, compradores[i].valor);
            }
            novo.Close();

            Console.WriteLine("Dados inseridos no arquivo -descontosClientes.txt-");
        }
    }

    // Classe usada na lista de usuários.
    public class Usuarios
    {
        public string nome;
        public float valor;
    }
}
