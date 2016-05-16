using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapterElevenCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Daniel's Calculator!!");
            Console.WriteLine("Please enter your first of two numbers, then hit 'Enter': ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second of two numbers, then hit 'Enter': ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Now tell me what you want me to do to them. Type '+' for add, '-' for subtract, '*' for multiply, '/' for divide, '%' for modulus, or '^' for exponent. Then hit 'Enter'");
            char userOperator = char.Parse(Console.ReadLine());
            double result = 0;

            switch(userOperator)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    result = firstNumber / secondNumber;
                    break;
                case '%':
                    result = firstNumber % secondNumber;
                    break;
                case '^':
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
            }

            Console.WriteLine(result);
        }
    }
}
