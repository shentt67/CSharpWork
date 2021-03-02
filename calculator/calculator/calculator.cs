using System;

namespace calculator
{
    class calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("Enter two numbers and the operator:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            char ope = Convert.ToChar(Console.ReadLine());
            switch(ope)
            {
                case '+':
                    Console.WriteLine("num1+num2={0}",num1+num2);
                    break;
                case '-':
                    Console.WriteLine("num1-num2={0}", num1 - num2);
                    break;
                case '*':
                    Console.WriteLine("num1*num2={0}", num1 * num2);
                    break;
                case '/':
                    Console.WriteLine("num1/num2={0}", num1 / num2);
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
            
        }
    }
}
