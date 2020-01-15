using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo_atividade_3
{
    class Questao3
    {
        public void NumeroSequencia()
        {
            //caminho do arquivo no pc
            string seq1 = @"C:/projetos/visual/poo-atividade-3/poo-atividade-3/poo-atividade-3/texto/Sequencia1.txt";
            string seq2 = @"C:/projetos/visual/poo-atividade-3/poo-atividade-3/poo-atividade-3/texto/Sequencia2.txt";

            // array para guardar a sequencia de números.
            int[] seq1Array = new int[20];
            int[] seq2Array = new int[20];

            // extraindo informação dos dois arquivos ao mesmo tempo.
            if (File.Exists(seq1) && File.Exists(seq2))
            {
                StreamReader arquivoAberto1 = new StreamReader(seq1, Encoding.ASCII);
                StreamReader arquivoAberto2 = new StreamReader(seq2, Encoding.ASCII);

                string linha1 = arquivoAberto1.ReadLine();
                string linha2 = arquivoAberto2.ReadLine();
                int i = 0;

                while (linha1 != null)
                {
                    seq1Array[i] = int.Parse(linha1);
                    seq2Array[i] = int.Parse(linha2);
                    i ++;

                    linha2 = arquivoAberto2.ReadLine();
                    linha1 = arquivoAberto1.ReadLine();
                }

                arquivoAberto1.Close();
                arquivoAberto2.Close();
            }

            // Lógica
            int pontos=0;
            Console.WriteLine("Tabela 1 e 2:");
            for (int i = 0; i < seq1Array.Length; i++)
            {
                // O int pontos é somado caso um lado do array seja igual ao outro
                if (seq2Array[i] == seq1Array[i])
                {
                    pontos++;
                    Console.WriteLine("{0} | {1} - aqui", seq1Array[i], seq2Array[i]); // descrição de onde está igual.
                }
                else
                    Console.WriteLine("{0} | {1}", seq1Array[i], seq2Array[i]);
            }

            Console.WriteLine("Existem {0} números na segunda sequencia iguais com a primeira sequencia", pontos);
        }
    }
}
