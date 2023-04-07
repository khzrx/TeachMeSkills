using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task0();
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            Task7();
        }

        public static void Task0()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Please enter a number.");

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (number == array[i])
                {
                    Console.WriteLine("The number is in the array.");
                    break;
                }
                else if (i == array.Length - 1 && number != array[i])
                {
                    Console.WriteLine("The number is not in the array.");
                }
            }
        }

        public static void Task1()
        {
            int[] mainArray = new int[] { 1, 2, 3, 4, 5};
            int[] newArray = new int[mainArray.Length - 1];
            int mainArrayCount = 0;
            

            Console.WriteLine("Please enter a number.");
            int number = int.Parse(Console.ReadLine());


            foreach (int i in mainArray)
            {
                if (i == number)
                {
                    mainArrayCount++;
                }
            }

            if (mainArrayCount == 0)
            {
                Console.WriteLine("The number is not in the array.");
            }
            else
            {
                int newArrayIndex = 0;

                for (int j = 0; j < mainArray.Length; j++)
                {
                    if (mainArray[j] != number)
                    {
                        newArray[newArrayIndex] = mainArray[j];
                        newArrayIndex++;
                    }
                }
                                
                foreach (int i in newArray)
                {
                    Console.Write(i);
                }
            }
        }

        public static void Task2()
        {
            Random random = new Random();

            Console.WriteLine("Enter the size of the array: ");
            int arraySize = int.Parse(Console.ReadLine());
            int arraySum = 0;
            int arrayMax = 0;
            double arrayAverage;

            int[] newArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                newArray[i] = random.Next(1, 100);
                arraySum += newArray[i];

                if (newArray[i] > arrayMax)
                {
                    arrayMax = newArray[i];
                }
            }

            arrayAverage = (double)arraySum / (double)arraySize;

            int arrayMin = arrayMax;

            for (int i = 0; i < arraySize; i++)
            {
                if (newArray[i] < arrayMax)
                {
                    arrayMax = newArray[i];
                }
            }

            Console.WriteLine("Average: " + Math.Round(arrayAverage, 2));
            Console.WriteLine("Max: " + arrayMax);
            Console.WriteLine("Min: " + arrayMin);

            Console.Write("Array: ");

            foreach (int i in newArray)
            {
                Console.Write(i + " ");
            }
        }

        public static void Task3()
        {
            Random random = new Random();
            int[] firstArray = new int[5];
            int[] secondArray = new int[5];
            double firstArraySum = 0.0;
            double secondArraySum = 0.0;


            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = random.Next(1, 1000);
                firstArraySum += firstArray[i];

                secondArray[i] = random.Next(1, 1000);
                secondArraySum += secondArray[i];
            }

            double firstArrayAverage = firstArraySum / firstArray.Length;
            double secondArrayAverage = secondArraySum / secondArray.Length;

            Console.Write("First array: ");
            foreach (int i in firstArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.Write("Second array: ");
            foreach (int i in secondArray)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            if (firstArrayAverage > secondArrayAverage)
            {
                Console.WriteLine($"The average of the first array {firstArrayAverage} is " +
                    $"greater than the average of the second array {secondArrayAverage}.");
            } 
            else if (firstArrayAverage < secondArrayAverage)
            {
                Console.WriteLine($"The average of the first array {firstArrayAverage} is " +
                    $"less than the average of the second array {secondArrayAverage}.");
            } 
            else
            {
                Console.WriteLine($"The average of the first array {firstArrayAverage} is " +
                $"equal to the average of the second array {secondArrayAverage}.");
            }
        }

        public static void Task4()
        {
            Random random = new Random();
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    array[i] = random.Next(1, 10);
                    Console.Write(array[i] + " ");
                } else
                {
                    array[i] = random.Next(1, 10);
                    Console.WriteLine(array[i]);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 > 0)
                {
                    array[i] = 0;
                    Console.Write(array[i] + " ");
                }
                else
                {
                    Console.Write(array[i] + " ");
                }
            }
        }

        public static void Task5()
        {
            string[] array = new string[5] { "Ivan", "Nikolay", "Evgeniy", "Aleksandr", "Boris" };
            Array.Sort(array);

            foreach (string i in array)
            {
                Console.Write(i + " ");
            }
        }

        public static void Task6()
        {
            int[] array = new int[10] { 23, 5, 192, 4, 6, -102, -896, 35, 187, 0 };

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        int k = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = k;
                    }
                }
            }

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }

        public static void Task7()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6} };
            int sum = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }

            Console.WriteLine("Sum: " + sum);
        }
    }
}

