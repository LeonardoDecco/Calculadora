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
            int operacao = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (operacao == 3) { num1* num2; }

            if (operacao == 4) { num1 / num2; }


        }
    }