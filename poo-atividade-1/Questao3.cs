using System;

namespace poo_atividade_1
{
    class Questao3
    {
        static void TrocarValores(ref float a, ref float b)
        {
            float aux=a;
            a = b;
            b = aux;
        }


        static void Main(string[] args)
        {
            float a=0, b=0;
            Console.WriteLine("Jaelcio Dutra");
            Console.WriteLine("-----------------");

            Console.WriteLine("Escreva o primeiro numero para ser trocado: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo numero para ser trocado: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Valores Originais: " + a + " " + b);
            TrocarValores(ref a, ref b);
            Console.WriteLine("Valores Trocados: " + a + " " + b);

            Console.ReadKey();
        }
    }
}
