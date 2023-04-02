using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        public static void Task1()
        {
            double operand1 = 14.0;
            double operand2 = 7.0;

            Console.WriteLine($"Operand 1 = {operand1} and Operand 2 = {operand2}.");
            Console.WriteLine("Please enter the sign of the arithmetic operation. Signs allowed: +, -, *, /, %.");

            string sign = Console.ReadLine();

            if (operand2 == 0.0 && (sign == "/" || sign == "%"))
            {
                Console.WriteLine("Division by 0 is not allowed");
            }
            else if (sign == "+")
            {
                Console.WriteLine($"{operand1} + {operand2} = {operand1 + operand2}");
            }
            else if (sign == "-")
            {
                Console.WriteLine($"{operand1} - {operand2} = {operand1 - operand2}");
            }
            else if (sign == "*")
            {
                Console.WriteLine($"{operand1} * {operand2} = {operand1 * operand2}");
            }
            else if (sign == "/")
            {
                Console.WriteLine($"{operand1} / {operand2} = {operand1 / operand2}");
            }
            else if (sign == "%")
            {
                Console.WriteLine($"{operand1} % {operand2} = {operand1 % operand2}");
            }
            else
            {
                Console.WriteLine("Unknown operation");
            }
        }
    }

}