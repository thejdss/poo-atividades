using System;

namespace poo_atividade_1
{
    class Questao2
    {
        static float CalcularCoelhos(float coelhos)
        {
            return ((coelhos * 0.70f)/18 + 10);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Jaelcio Dutra");
            Console.WriteLine("-----------------");
            Console.WriteLine("Escreva o número de coelhos: ");
            float coelhos = float.Parse(Console.ReadLine());
            coelhos = CalcularCoelhos(coelhos);
            Console.WriteLine("O custo total para todos esses coelhos é: " + coelhos);
            Console.ReadKey();
        }
    }
}
