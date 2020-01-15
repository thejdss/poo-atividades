using System;
using System.Collections.Generic;

namespace poo_atividade_1
{
    public struct Contato
    {
        public string nome, telefone, email, dataAniversario;

        public Contato(string nome, string telefone, string email, string dataAniversario)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.dataAniversario = dataAniversario;
        }
    }

    class Questao1
    {
        public static List<Contato> Agenda = new List<Contato>();

        static void Main(string[] args)
        {
            Console.WriteLine("Jaelcio Dutra");
            Console.WriteLine("-----------------");

            while (Agenda.Count < 2)
            {
                Console.WriteLine("Escreva o nome do contato ");
                string nome = Console.ReadLine();
                if (nome.Length > 40)
                {
                    nome = nome.Substring(0, 40);
                }

                Console.WriteLine("Escreva o telefone do contato ");
                string tel = Console.ReadLine();
                if (tel.Length > 15)
                {
                    nome = nome.Substring(0, 15);
                }

                Console.WriteLine("Escreva o email do contato ");
                string email = Console.ReadLine();
                if (email.Length > 40)
                {
                    email = nome.Substring(0, 40);
                }

                Console.WriteLine("Escreva a data de nascimento do contato ");
                string dataNiver = Console.ReadLine();

                Contato novoContato = new Contato(nome, tel, email, dataNiver);
                Agenda.Add(novoContato);

                Console.Clear();
            }

            Console.WriteLine("Agenda de contatos: ");
            foreach (var contato in Agenda)
            {
                Console.WriteLine("nome: " + contato.nome);
                Console.WriteLine("tel: " + contato.telefone);
                Console.WriteLine("email: " + contato.email);
                Console.WriteLine("data de nascimento: " + contato.dataAniversario);
                Console.WriteLine("-----------------------------------------------------------------");
            }

            Console.ReadKey();
        }

    }
}
