using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace poo_atividade_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a questão");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 2:
                    Questao2 quest2 = new Questao2();
                    quest2.DescontoDosVendedores();
                    break;

                case 3:
                    Questao3 quest3 = new Questao3();
                    quest3.NumeroSequencia();
                    break;

                case 4:
                    Questao4 quest4 = new Questao4();
                    quest4.LeituraVotos();
                    break;
            }

            Console.ReadKey();
        }
    }
}
