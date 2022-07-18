using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{    
      class Program
      {
            public delegate bool Comparer(object obj1, object obj2);
        /// <summary>
        /// клас сортировки персон
        /// </summary>
            static class Sorter
            {
            /// <summary>
            /// метод для здійснювання сортировки пузирком
            /// </summary>
            /// <param name="array">масив елементів ПІБ</param>
            /// <param name="del">Порівнює два об'екта на еквівалентність</param>
            static public void BubbleSort(object[] array, Comparer del)
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = i + 1; j < array.Length; j++)
                        {
                            if (del(array[j], array[i]))
                            {
                                object temporary = array[i];
                                array[i] = array[j];
                                array[j] = temporary;
                            }
                        }
                    }
                }
            }
        /// <summary>
        /// узагальнений клас, який представляє людину
        /// </summary>
        public class Person <T>
            {
                public T FirstName;
                public T LastName;
                public DateTime Birthday;
            /// <summary>
            /// конструктор класа
            /// </summary>
            /// <param name="FirstName">поле, яке зберігає ім'я</param>
            /// <param name="LastName">поле, яке зберігає прізвище</param>
            /// <param name="Birthday">поле, яке зберігає дату народження</param>
                public Person(T FirstName, T LastName, DateTime Birthday)
                {
                    this.FirstName = FirstName;
                    this.LastName = LastName;
                    this.Birthday = Birthday;
                }
            /// <summary>
            /// успадкований метод, який повертає строку
            /// </summary>
            /// <returns>Замінює елементи формату в рядку на рядкове представлення трьох указаних об’єктів та повертає їх</returns>
            public override string ToString()
                {
                    return string.Format(
                        "Iм'я: {0, -10} Прiзвище: {1, -12} Дата народження: {2:dd.MM.yyyy}.",
                        FirstName, LastName, Birthday);
                }
            }
        /// <summary>
        /// статичний метод для порівнювання двох персон по іменам по спаданню
        /// </summary>
        /// <param name="o1">ім'я першої людини</param>
        /// <param name="o2">ім'я другої людини</param>
        /// <returns>повертає відсотрований рядок</returns>
        /// <exception cref="Exception">виключення у разі помилки</exception>

        static public bool PersonFirstnameDownComparer(object o1, object o2)
            {
                Person<string> left = o1 as Person<string>;
                Person<string> right = o2 as Person<string>;

                if (left == null || right == null)
                    throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                        + o1.GetType() + " та " + o2.GetType());

                return left.FirstName.CompareTo(right.FirstName) < 0;
            }
        /// <summary>
        /// статичний метод для порівнювання двох персон по дням народження по спаданню
        /// </summary>
        /// <param name="o1">дата народження першої людини</param>
        /// <param name="o2">дата народження другої людини</param>
        /// <returns>повертає відсотрований рядок</returns>
        /// <exception cref="Exception">виключення у разі помилки</exception>
        static public bool PersonDateofbirthdayDownComparer(object o1, object o2)
        {
            Person<string> left = o1 as Person<string>;
            Person<string> right = o2 as Person<string>;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.Birthday.CompareTo(right.Birthday) < 0;
        }
        /// <summary>
        /// статичний метод для порівнювання двох персон по дням народження по зростанню
        /// </summary>
        /// <param name="o1">дата народження першої людини</param>
        /// <param name="o2">дата народження другої людини</param>
        /// <returns>повертає відсотрований рядок</returns>
        /// <exception cref="Exception">виключення у разі помилки</exception>
        static public bool PersonDateofbirthdayUpComparer(object o1, object o2)
        {
            Person<string> left = o1 as Person<string>;
            Person<string> right = o2 as Person<string>;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.Birthday.CompareTo(right.Birthday) > 0;
        }
        /// <summary>
        /// статичний метод для порівнювання двох персон по прізвищам по спаданню
        /// </summary>
        /// <param name="o1">прізвище першої людини</param>
        /// <param name="o2">прізвище другої людини</param>
        /// <returns>повертає відсотрований рядок</returns>
        /// <exception cref="Exception">виключення у разі помилки</exception>
        static public bool PersonLastnameDownComparer(object o1, object o2)
        {
            Person<string> left = o1 as Person<string>;
            Person<string> right = o2 as Person<string>;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.LastName.CompareTo(right.LastName) < 0;
        }
        /// <summary>
        /// статичний метод для порівнювання двох персон по прізвищам по зростанню
        /// </summary>
        /// <param name="o1">прізвище першої людини</param>
        /// <param name="o2">прізвище другої людини</param>
        /// <returns>повертає відсотрований рядок</returns>
        /// <exception cref="Exception">виключення у разі помилки</exception>
        static public bool PersonLastnameUpComparer(object o1, object o2)
        {
            Person<string> left = o1 as Person<string>;
            Person<string> right = o2 as Person<string>;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.LastName.CompareTo(right.LastName) > 0;
        }
        /// <summary>
        /// статичний метод для порівнювання двох персон по прізвищу
        /// </summary>
        /// <param name="o1">прізвище першої людини</param>
        /// <param name="o2">прізвище другої людини</param>
        /// <returns>повертає відсотрований рядок</returns>
        /// <exception cref="Exception">виключення у разі помилки</exception>
        static public bool PersonLastnameComparer(object o1, object o2)
        {
            Person<string> left = o1 as Person<string>;
            Person<string> right = o2 as Person<string>;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.LastName.Length.CompareTo(right.LastName.Length) > 0;
        }
        /// <summary>
        /// статичний метод для порівнювання двох персон по іменам 
        /// </summary>
        /// <param name="o1">ім'я першої людини</param>
        /// <param name="o2">ім'я другої людини</param>
        /// <returns>повертає відсотрований рядок</returns>
        /// <exception cref="Exception">виключення у разі помилки</exception>
        static public bool PersonFirstnameUpComparer(object o1, object o2)
        {
            Person<string> left = o1 as Person<string>;
            Person<string> right = o2 as Person<string>;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.FirstName.CompareTo(right.FirstName) > 0;
        }
        /// <summary>
        /// точка входу
        /// </summary>
        static void Main()
         {
             object[] persons = {
             new Person<string>("Юрiй", "Каратаєв", new DateTime(1996, 1, 1)),
             new Person<string>("Володимир", "Коч", new DateTime(1992, 11, 6)),
             new Person<string>("Станiслав", "Петровський", new DateTime(1991, 5, 11)),
             new Person<string>("Iгор", "Плахотнюк", new DateTime(1990, 10, 8)),
             new Person<string>("Вiктор", "Пiвторак", new DateTime(1989, 6, 14)),
             new Person<string>("Олександр", "Ванновський", new DateTime(1984, 10, 8)),
             new Person<string>("Дмитро", "Грищук", new DateTime(1995, 6, 14)),
             new Person<string>("Олександр", "Гурнiк", new DateTime(1993, 7, 1)),
             new Person<string>("Свiтлана", "Сироткiна", new DateTime(1988, 7, 1)),
             new Person<string>("Олег", "Смолiнський", new DateTime(1987, 1, 1)),
             new Person<string>("Юрiй", "Соломон", new DateTime(1986, 11, 6)),
             new Person<string>("Сергiй", "Яцишин", new DateTime(1985, 5, 11))
             };

            Console.WriteLine("Несортований список:\n");
            foreach (object person in persons) Console.WriteLine(person);

            Console.WriteLine("\nВiдсортований за iменами (А-Я) список:\n");
            Sorter.BubbleSort(persons, PersonFirstnameDownComparer); 
            foreach (object person in persons) Console.WriteLine(person);

            Console.WriteLine("\n");

            Console.WriteLine("\nВiдсортований за датою народження (вiд старших до молодших) список:\n");
            Sorter.BubbleSort(persons, PersonDateofbirthdayDownComparer);
            foreach (object person in persons) Console.WriteLine(person);
            Console.WriteLine("\n");

            Console.WriteLine("\nВiдсортований за датою народження (вiд молодших до старших) список:\n");
            Sorter.BubbleSort(persons, PersonDateofbirthdayUpComparer);
            foreach (object person in persons) Console.WriteLine(person);
            Console.WriteLine("\n");

            Console.WriteLine("\nВiдсортований за прiзвищем (А-Я) список:\n");
            Sorter.BubbleSort(persons, PersonLastnameDownComparer);
            foreach (object person in persons) Console.WriteLine(person);
            Console.WriteLine("\n");

            Console.WriteLine("\nВiдсортований за прiзвищем (Я-А) список:\n");
            Sorter.BubbleSort(persons, PersonLastnameUpComparer);
            foreach (object person in persons) Console.WriteLine(person);
            Console.WriteLine("\n");

            Console.WriteLine("\nВiдсортований за розмiром прiзвища список:\n");
            Sorter.BubbleSort(persons, PersonLastnameComparer);
            foreach (object person in persons) Console.WriteLine(person);
            Console.WriteLine("\n");

            Console.WriteLine("\nВiдсортований за iменами (Я-А) список:\n");
            Sorter.BubbleSort(persons, PersonFirstnameUpComparer); 
            foreach (object person in persons) Console.WriteLine(person);

            Console.WriteLine("\n");
        }
      }    
}
