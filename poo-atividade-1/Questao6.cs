using System;

namespace poo_atividade_1
{
    class Questao6
    {
        static float PesoIdealHomem(float h)
        {
            return (72.7f * (h - 58f));
        }

        static float PesoIdealMulher(float h)
        {
            return (62.1f * (h - 44.7f));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Jaelcio Dutra");
            Console.WriteLine("-----------------");

            Console.WriteLine("Peso Ideal: ");
            Console.WriteLine("Digite seu sexo (m ou f | masculino ou feminino) : ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Digite sua altura : ");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Seu peso ideal é : ");
            if(sexo.Equals("m")|| sexo.Equals("masculino"))
            {
                Console.WriteLine(PesoIdealHomem(altura));
            }
            else if (sexo.Equals("f") || sexo.Equals("feminino"))
            {
                Console.WriteLine(PesoIdealMulher(altura));
            }
            else
            {
                Console.WriteLine("Sexo ou peso inválido");
            }
            Console.ReadKey();
        }
    }
}
