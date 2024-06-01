using System;
using Calculadora.Services;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("QUAL OPERAÇÃO DESEJA REALIZAR?");
            Console.WriteLine("1: Adição");
            Console.WriteLine("2: Subtração");
            Console.WriteLine("3: Multiplicação");
            Console.WriteLine("4: Divisão");

            try
            {
                int operacao = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o primeiro número:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                int num2 = int.Parse(Console.ReadLine());

                int resultado;

                CalculadoraImplementacao c = new CalculadoraImplementacao();

                switch (operacao)
                {
                    case 1:
                        resultado = c.Somar(num1, num2);
                        break;
                    case 2:
                        resultado = c.Subtrair(num1, num2);
                        break;
                    case 3:
                        resultado = c.Multiplicar(num1, num2);
                        break;
                    case 4:
                        resultado = c.Dividir(num1, num2);
                        break;
                    default:
                        throw new ArgumentException("Operação inválida: " + operacao);
                }

                Console.WriteLine("O resultado é: " + resultado);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Erro: Os valores digitados devem ser números inteiros.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
            }
        }
    }
}
