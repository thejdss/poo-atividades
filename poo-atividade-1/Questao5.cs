using System;

namespace poo_atividade_1
{
    class Questao5
    {
        static void Main(string[] args)
        {
            int horas = 0, minutos = 0, auxMin = 0, segundos = 0, tempo = 0;

            Console.WriteLine("Insira um valor segundos para calcular as horas e minutos: ");
            tempo = int.Parse(Console.ReadLine());

            horas = (tempo >= 3600 ? tempo / 3600 : 0);
            auxMin = (tempo < 60 ? 0 : tempo % 3600);
            minutos = (tempo < 60 ? 0 : auxMin / 60);
            segundos = auxMin % 60;

            Console.WriteLine(" " + horas + " Horas " + minutos + " Minutos " + segundos + " Segundos");

            Console.ReadLine();
        }
    }
}
