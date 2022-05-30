﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{    
      class Program
      {
            public delegate bool Comparer(object obj1, object obj2);

            static class Sorter
            {
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

            public class Person
            {
                public string FirstName;
                public string LastName;
                public DateTime Birthday;

                public Person(string FirstName, string LastName, DateTime Birthday)
                {
                    this.FirstName = FirstName;
                    this.LastName = LastName;
                    this.Birthday = Birthday;
                }

                public override string ToString()
                {
                    return string.Format(
                        "Iм'я: {0, -10} Прiзвище: {1, -12} Дата народження: {2:dd.MM.yyyy}.",
                        FirstName, LastName, Birthday);
                }
            }

            static public bool PersonFirstnameDownComparer(object o1, object o2)
            {
                Person left = o1 as Person;
                Person right = o2 as Person;

                if (left == null || right == null)
                    throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                        + o1.GetType() + " та " + o2.GetType());

                return left.FirstName.CompareTo(right.FirstName) < 0;
            }

        static public bool PersonDateofbirthdayDownComparer(object o1, object o2)
        {
            Person left = o1 as Person;
            Person right = o2 as Person;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.Birthday.CompareTo(right.Birthday) < 0;
        }
        static public bool PersonDateofbirthdayUpComparer(object o1, object o2)
        {
            Person left = o1 as Person;
            Person right = o2 as Person;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.Birthday.CompareTo(right.Birthday) > 0;
        }
        static public bool PersonLastnameDownComparer(object o1, object o2)
        {
            Person left = o1 as Person;
            Person right = o2 as Person;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.LastName.CompareTo(right.LastName) < 0;
        }
        static public bool PersonLastnameUpComparer(object o1, object o2)
        {
            Person left = o1 as Person;
            Person right = o2 as Person;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.LastName.CompareTo(right.LastName) > 0;
        }

        static public bool PersonLastnameComparer(object o1, object o2)
        {
            Person left = o1 as Person;
            Person right = o2 as Person;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.LastName.Length.CompareTo(right.LastName.Length) > 0;
        }

        static public bool PersonFirstnameUpComparer(object o1, object o2)
        {
            Person left = o1 as Person;
            Person right = o2 as Person;

            if (left == null || right == null)
                throw new Exception("Вибачте, але вам би слід порівняти двох Персон, а не оце все: "
                    + o1.GetType() + " та " + o2.GetType());

            return left.FirstName.CompareTo(right.FirstName) > 0;
        }

        static void Main()
         {
             object[] persons = {
             new Person("Юрiй", "Каратаєв", new DateTime(1996, 1, 1)),
             new Person("Володимир", "Коч", new DateTime(1992, 11, 6)),
             new Person("Станiслав", "Петровський", new DateTime(1991, 5, 11)),
             new Person("Iгор", "Плахотнюк", new DateTime(1990, 10, 8)),
             new Person("Вiктор", "Пiвторак", new DateTime(1989, 6, 14)),
             new Person("Олександр", "Ванновський", new DateTime(1984, 10, 8)),
             new Person("Дмитро", "Грищук", new DateTime(1995, 6, 14)),
             new Person("Олександр", "Гурнiк", new DateTime(1993, 7, 1)),
             new Person("Свiтлана", "Сироткiна", new DateTime(1988, 7, 1)),
             new Person("Олег", "Смолiнський", new DateTime(1987, 1, 1)),
             new Person("Юрiй", "Соломон", new DateTime(1986, 11, 6)),
             new Person("Сергiй", "Яцишин", new DateTime(1985, 5, 11))
             };

            Console.WriteLine("Несортований список:\n");
            foreach (object person in persons) Console.WriteLine(person);

            Console.WriteLine("\nВiдсортований за iменами (А-Я) список:\n");
            Sorter.BubbleSort(persons, PersonFirstnameDownComparer); // сортируем по именам
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
            Sorter.BubbleSort(persons, PersonFirstnameUpComparer); // сортируем по именам
            foreach (object person in persons) Console.WriteLine(person);

            Console.WriteLine("\n");
        }
      }    
}
