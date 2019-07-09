using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericMethodSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic method example to check any type of list to check items");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("List<String> Example: ");
            List<string> lstString = new List<string>();
            lstString.Add("String 1");
            lstString.Add("String 2");
            lstString.Add("String 3");
            if (!CompareList<string>(lstString))
            {
                Console.WriteLine("List contains no items");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("List<Int> Example: ");
            List<int> lstInt = new List<int>();
            lstInt.Add(1);
            lstInt.Add(2);
            if (!CompareList<int>(lstInt))
            {
                Console.WriteLine("List contains no items");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("List<Person> Example: ");
            List<Person> lstPerson = new List<Person>();
            lstPerson.Add(new Person { Name = "Person 1", Age = 25 });
            lstPerson.Add(new Person { Name = "Person 2", Age = 28 });
            lstPerson.Add(new Person { Name = "Person 3", Age = 28 });
            lstPerson.Add(new Person { Name = "Person 4", Age = 28 });
            if (!CompareList<Person>(lstPerson))
            {
                Console.WriteLine("List contains no items");
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Empty List Example: ");
            List<string> lst = new List<string>();
            if (!CompareList<string>(lst))
            {
                Console.WriteLine("List contains no items");
            }


            Console.ReadLine();
        }

        public static bool CompareList<T>(List<T> lstItems)
        {
            if (lstItems != null && lstItems.Count() > 0)
            {
                Console.WriteLine(string.Format("List contains {0} itmes.", lstItems.Count()));
                return true;
            }

            return false;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
