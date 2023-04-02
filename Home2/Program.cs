using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();
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

        public static void Task2()
        {
            Console.WriteLine("Please enter a number.");

            double number = Convert.ToDouble(Console.ReadLine());

            if (number < 0.0 || number > 100.0)
            {
                Console.WriteLine("The number is not in the range [1 - 100]");
            } 
            else if (number <= 14.0) {
                Console.WriteLine("The number is in the range [0 - 14]");
            }
            else if (number <= 35.0)
            {
                Console.WriteLine("The number is in the range [15 - 35]");
            }
            else if (number <= 50.0)
            {
                Console.WriteLine("The number is in the range [36 - 50]");
            }
            else if (number <= 100.0)
            {
                Console.WriteLine("The number is in the range [50 - 100]");
            }
        }

        public static void Task3()
        {
            Console.WriteLine("Enter one of the following words to get an English translation:");
            Console.WriteLine("дождь, ветер, шторм, торнадо, снег, град, температура, погода, метель, ураган.");

            string word = Console.ReadLine();

            if (word == "дождь")
            {
                Console.WriteLine("English translation: rain");
            }
            else if (word == "ветер")
            {
                Console.WriteLine("English translation: wind");
            }
            else if (word == "шторм")
            {
                Console.WriteLine("English translation: storm");
            }
            else if (word == "снег")
            {
                Console.WriteLine("English translation: tornado");
            }
            else if (word == "град")
            {
                Console.WriteLine("English translation: hail");
            }
            else if (word == "температура")
            {
                Console.WriteLine("English translation: temperature");
            }
            else if (word == "погода")
            {
                Console.WriteLine("English translation: weather");
            }
            else if (word == "метель")
            {
                Console.WriteLine("English translation: blizzard");
            }
            else if (word == "ураган")
            {
                Console.WriteLine("English translation: hurricane");
            }
            else
            {
                Console.WriteLine("The entered word is not in the dictionary.");
            }
        }
    }
}