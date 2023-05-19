using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class LinqMethods
    {
        // Метод возвращает первое слово из последовательности слов, содержащее только одну букву.

        public string FirstWordWithOneSymbol(string s)
        {
            string[] stringArray = s.Split(' ');
            return stringArray.FirstOrDefault(s => stringArray.Length == 1);
        }

        // метод, возвращающий последнее слово, содержащее в себе подстроку «ее». Реализовать, используя только 1 метод LINQ

        public string LastWordWithSubstring(string someString)
        {
            string[] stringArray = someString.Split(' ');
            return stringArray.LastOrDefault(w => w.Contains("ее"));
        }

        // Реализовать метод для возврата последнего слова, соответствующего условию:
        // длина слова не меньше min и не больше max.
        // Если нет слов, соответствующих условию, метод возвращает null.

        public string LastWordWithCondition(string someString, int min, int max)
        {
            string[] stringArray = someString.Split(' ');
            return stringArray.LastOrDefault(w => w.Length >= min && w.Length <= max, null);
        }


        // Напишите метод, который возвращает количество уникальных значений в массиве.

        public int CountUnique(string someString)
        {
            string[] stringArray = someString.Split(' ');
            return stringArray.Distinct().Count();
        }

        //Напишите метод, который принимает список и извлекает значения с 5  элемента (включительно)
        //те значение которые содержат 3

        public List<int> ShortestWordLength(List<int> list)
        {
            List<int> result = new List<int>();

            foreach (int i in list.Skip(4))
            {
                if (i == 3)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        // Метод возвращает длину самого короткого слова

        public int ShortestWordLength(string someString)
        {
            string[] stringArray = someString.Split(' ');
            string[] orderedStringArray = stringArray.OrderBy(s => s.Length).ToArray();
            return orderedStringArray.First().Length;
        }

        // Напишите метод, который преобразует словарь в список и меняет местами каждый ключ и значение

        public List<KeyValuePair<string, int>> DictToList(Dictionary<int, string> dict)
        {
            List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            Dictionary<string, int> dict2 = new Dictionary<string, int>();


            foreach (KeyValuePair<int, string> kw in dict)
            {
                dict2.Add(kw.Value, kw.Key);
            }

            list = dict2.ToList();

            return list;
        }
    }

    public class User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public User(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        //- Напишите метод, который возвращает "<FirstName> <MiddleName> <LastName>",
        //если отчество присутствует Или "<FirstName> <LastName>", если отчество отсутствует.

        public string ReturnFIO(User user)
        {
            string fio;
            if (user.MiddleName.Any())
            {
                fio = ($"{user.FirstName} {user.MiddleName} {user.LastName}");
            }
            else
            {
                fio = ($"{user.FirstName} {user.LastName}");
            }

            return fio;
        }

        //Напишите метод, который возвращает предоставленный список пользователей,
        //упорядоченный по LastName в порядке убывания.

        public List<User> OrderedUsers(List<User> users)
        {
            var sortedUsers = users.OrderByDescending(x => x.LastName).ToList();
            return sortedUsers;
        }
    }
}
