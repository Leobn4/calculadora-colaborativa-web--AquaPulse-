using System;

namespace CalculadoraWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Colaborativa Web");
            // Gustavo Cravo
            Console.WriteLine("Selecione qual operação deseja realizar.");
            int operacao = 0;
            Console.WriteLine("Digite um número>");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número.");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação deseja realizar?");
            operacao = int.Parse(Console.Readline());
            switch (operacao)
            {
                case 1:
                    Console.WriteLine("Adição");
                    Adicao();
                    break;
                case 2:
                    Console.WriteLine("Subtração");
                    Subtracao();
                    break;
                case 3;
                    Console.WriteLine("Multiplicação");
                    Multiplicacao();
                    break;
                case 4;
                    Console.WriteLine("Divisão");
                    Divisao();
                    break;
            }
        }

        // Gustavo Cravo
        public static double Adicao(double a, double b)
        {
            return a + b;
        }

        // Integrante 2
        // public static double Subtracao(double a, double b)
        // {
        //     // Implementar aqui
        // }

        // Integrante 3
        // public static double Multiplicacao(double a, double b)
        // {
        //     // Implementar aqui
        // }

        // Integrante 4
        // public static double Divisao(double a, double b)
        // {
        //     // Implementar aqui
        // }


  // Integrante 5
        // public static double Potenciacao(double a, double b)
        // {
        //     // Implementar aqui
        // }
    }
}

