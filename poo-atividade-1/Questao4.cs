using System;

namespace poo_atividade_1
{
    class Questao4
    {
        static void Main(string[] args)
        {
            Funcionario novoFuncionario = new Funcionario();
            Console.WriteLine("Jaelcio Dutra");
            Console.WriteLine("-----------------");

            Console.WriteLine("Escreva o nome do funcionário: ");
            novoFuncionario.nome = Console.ReadLine();
            Console.WriteLine("Escreva as horas trabalhadas desse funcionário: ");
            novoFuncionario.horasTrabalhadas = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o número de dependentes desse funcionário: ");
            novoFuncionario.dependentes = float.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("O funcionário " + novoFuncionario.nome);
            float salBruto = novoFuncionario.SalarioBruto(novoFuncionario.horasTrabalhadas, novoFuncionario.dependentes);
            Console.WriteLine("Tem o salário bruto de: " + salBruto);
            Console.WriteLine("É descontado de INSS: " + novoFuncionario.CalcularDescontoINSS(salBruto));
            Console.WriteLine("É descontado de Imposto de Renda: " + novoFuncionario.CalcularDescontoIR(salBruto));
            Console.WriteLine("E recebe líquido: " + novoFuncionario.SalarioLiquido(salBruto));
            Console.WriteLine("----------------------------------------------------");
            Console.ReadKey();
        }
    }

    public class Funcionario
    {
        public string nome;
        public float horasTrabalhadas, dependentes;

        public float SalarioBruto(float hrsTrabalhadas, float dpt)
        {
            return ((hrsTrabalhadas * 12.00f) + (dpt * 40f));
        }

        public float CalcularDescontoINSS(float salBruto)
        {
            return ((8f * salBruto) / 100f);
        }

        public float CalcularDescontoIR(float salBruto)
        {
            return ((5f * salBruto) / 100f);
        }

        public float SalarioLiquido(float salBruto)
        {
            float aux = salBruto;
            aux -= CalcularDescontoINSS(aux);
            aux -= CalcularDescontoIR(aux);
            return aux;
        }
    }
}
