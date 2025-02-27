namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int operacao;
            double num1;
            double num2;

            Console.WriteLine("Insira o número referente a operação: ");
            int operacao = int.Parse(Console.ReadLine());


            Console.WriteLine("Digite o primeiro número: ");
            double num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = int.Parse(Console.ReadLine());

            if (operacao == 3) {"O resultado da multiplicação é igual a "+num1*num2; }

            if (operacao == 4) {"O resultado da divisão é igual a "+num1/num2; }


        }
    }