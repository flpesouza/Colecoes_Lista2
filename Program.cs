using System;
using System.Collections.Generic;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<double> polonesa = new Stack<double>();
            
            double resultado;

            Console.WriteLine("Digite a expressão polonesa: ");
            string expressao = Console.ReadLine();

            char[] charArray = expressao.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] != '+' && charArray[i] != '-' && charArray[i] != '*' && charArray[i] != '/')
                {
                    char letra = charArray[i];
                    double num = (int)Char.GetNumericValue(letra);
                    polonesa.Push(num);
                }
                else if (charArray[i] == '+')
                {
                    double num1 = polonesa.Pop();
                    double num2 = polonesa.Pop();
                    resultado = num2 + num1;
                    polonesa.Push(resultado);
                }
                else if (charArray[i] == '-')
                {
                    double num1 = polonesa.Pop();
                    double num2 = polonesa.Pop();
                    resultado = num2 - num1;
                    polonesa.Push(resultado);

                }
                else if (charArray[i] == '*')
                {
                    double num1 = polonesa.Pop();
                    double num2 = polonesa.Pop();
                    resultado = num2 * num1;
                    polonesa.Push(resultado);

                }
                else if (charArray[i] == '/')
                {
                    double num1 = polonesa.Pop();
                    double num2 = polonesa.Pop();
                    resultado = num2 / num1;
                    polonesa.Push(resultado);

                }
            }
            resultado = polonesa.Pop();
            Console.WriteLine("Resultado: " + resultado);
            Console.ReadLine();
        }
    }
}