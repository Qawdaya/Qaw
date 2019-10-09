using System;

namespace _6._5._3__排序
{
    class Program
    {
        static void Main(string[] args)
        {
            name();
            Person[] persons = getPersons();
            SortPersons(persons);
            SortUsingPersonComparer(persons);

            Console.ReadKey();
        }

        static void name()
        {
            string[] names = { "Christina Aguilera",
                   "Shakira",
                   "Beyonce",
                   "Gwen Stefani"};
            Array.Sort(names);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
        static void SortUsingPersonComparer(Person[] persons)
        {
            Array.Sort(persons,
                new PersonComparer(PersonComparerType.FirstName));

            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }

        }
        static Person[] getPersons()
        {
            return new Person[] {
             new Person { FirstName="Damon", LastName="Hill" },
                new Person { FirstName="Niki", LastName="Lauda" },
                new Person { FirstName="Ayrton", LastName="Senna" },
                new Person { FirstName="Graham", LastName="Hill" } };
        }
        static void SortPersons(Person[] persons)
        {
            Array.Sort(persons);
            foreach (Person p in persons)
            {
                Console.WriteLine(p);
            }
        }

        static void SortNames()
        {
            string[] names = {
                   "Christina Aguilera",
                   "Shakira",
                   "Beyonce",
                   "Gwen Stefani"
                 };

        }

    }
}
