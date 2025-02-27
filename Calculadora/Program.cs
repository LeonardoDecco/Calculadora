using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá, qual operação deseja calcular: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão \n");

            int operacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado;

            if (operacao == 1)
            {
                resultado = num1 + num2;
               Console.WriteLine($"O resultado da adição é: {resultado}");
            }
            if (operacao == 2)
            {
                resultado = num1 - num2;
             Console.WriteLine($"O resultado da subtração é: {resultado}");
            }

            if (operacao == 3)
            {
                resultado = num1 * num2;
               Console.WriteLine($"O resultado da multiplicação é: {resultado}");
            }
            if (operacao == 4)
            {
                resultado = num1 / num2;
             Console.WriteLine($"O resultado da divisão é: {resultado}");
            }
    }

        }
    }
}

