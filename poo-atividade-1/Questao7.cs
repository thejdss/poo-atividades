using System;

namespace poo_atividade_1
{
    class Questao7
    {
        static float Idade(float ano)
        {
            return (2019 - ano);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Jaelcio Dutra");
            Console.WriteLine("-----------------");
            Console.WriteLine("Escreva o ano de seu nascimento: ");
            float anoNasc = float.Parse(Console.ReadLine());
            Console.WriteLine("Sua idade é : " + Idade(anoNasc));
            if (anoNasc >= 16) Console.WriteLine("Você pode votar");
            if (anoNasc >= 18) Console.WriteLine("Você pode tirar uma carteira para dirigir");
            Console.ReadKey();
        }
    }
}
