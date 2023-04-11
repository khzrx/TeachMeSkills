using System.Text;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            Task6();
        }

        /// <summary>
        /// Задать строку содержащую внутри цифры и несколько повторений слова test, 
        /// Заменить в строке все вхождения 'test' на 'testing'.
        /// </summary>
        public static void Task1()
        {
            string originText = "Some test failed. This test will be removed.";
            string newText = originText.Replace("test", "testing");
            Console.WriteLine(newText);
        }

        /// <summary>
        /// Создайте переменные, которые будут хранить следующие слова: (Welcome, to, the, TMS, lessons)
        /// выполните конкатенацию слов и выведите на экран следующую фразу:
        /// Каждое слово должно быть записано отдельно и взято в кавычки, например "Welcome". 
        /// Не забывайте о пробелах после каждого слова
        /// </summary>
        public static void Task2()
        {
            string welcomeWord = "Welcome";
            string toWord = "to";
            string theWord = "the";
            string tmsWord = "TMS";
            string lessonsWord = "lessons";

            string[] wordsArray = new string[] { welcomeWord, toWord, theWord, tmsWord, lessonsWord };

            for (int i = 0; i < wordsArray.Length; i++)
            {
                wordsArray[i] = wordsArray[i].Insert(0, "\"");
                wordsArray[i] = wordsArray[i].Insert(wordsArray[i].Length, "\"");
            }

            string concatedText = string.Join(" ", wordsArray);

            Console.WriteLine(concatedText);
        }

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart, 
        /// а также всё, что после них во вторую secondPart.
        /// </summary>
        public static void Task3()
        {
            string originText = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string textToFind = "abc";

            string firstPart = originText.Remove(originText.IndexOf(textToFind));
            string secondPart = originText.Substring(originText.IndexOf(textToFind) + textToFind.Length);

            Console.WriteLine(originText);
            Console.WriteLine(firstPart);
            Console.WriteLine(secondPart);
        }

        /// <summary>
        /// Дана строка: Good day
        /// Необходимо с помощью метода substring удалить слово "Good".
        /// После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        /// Заменить последний "!" на "?" и вывести результат на консоль.
        /// </summary>
        public static void Task4()
        {
            string originText = "Good day";
            string newText = originText.Substring(originText.IndexOf("Good") + "Good".Length);
            string insertedText1 = newText.Insert(0, "The best");
            string insertedText2 = insertedText1.Insert(insertedText1.Length, "!!!!!!!!!");
            string resultText = insertedText2.Replace("!", "?");

            Console.WriteLine(resultText);
        }

        /// <summary>
        /// Введите с консоли строку, которая будет содержать буквы и цифры. 
        /// Удалите из исходной строки все цифры и выведите их на экран.
        /// (Использовать метод Char.IsDigit(), его не разбирали на уроке, 
        /// посмотрите, пожалуйста, документацию этого метода самостоятельно)
        /// </summary>
        public static void Task5()
        {
            Console.WriteLine("Please enter a string that contains letters and numbers");
            string originText = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < originText.Length; i++)
            {
                if (char.IsDigit(originText[i]))
                {
                    result.Append(originText[i]);
                }
            }

            Console.WriteLine(result);
        }

        /// <summary>
        /// Задайте 2 предложения из консоли. 
        /// Для каждого слова первого предложения определите количество его вхождений во второе предложение.
        /// </summary>
        public static void Task6()
        {
            Console.WriteLine("Please enter the first sentence: ");
            string firstSentence = Console.ReadLine();
            Console.WriteLine("Please enter the second sentence: ");
            string secondSentence = Console.ReadLine();

            string[] firstSentenceArray = firstSentence.Split(" ");
            string[] secondSentenceArray = secondSentence.Split(" ");

            for (int i = 0; i < firstSentenceArray.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < secondSentenceArray.Length; j++)
                {
                    if ((firstSentenceArray[i].ToLower())
                        .Equals((secondSentenceArray[j].ToLower())))
                    {
                        count++;
                    }
                }
                Console.WriteLine($"The word \"{firstSentenceArray[i]}\" occurs {count} times in the second sentence.");
            }
        }
    }
}