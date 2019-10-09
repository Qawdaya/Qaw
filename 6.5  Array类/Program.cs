using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wrox.ProCSharp.Arrays
{
    class Program
    {
        static void Main()
        {
            SimpleArrays();
            ArrayClass();
            CopyArrays();

        }

        static void CopyArrays()
        {
            Person[] beatles = {
                     new Person { FirstName="John", LastName="Lennon" },
                     new Person { FirstName="Paul", LastName="McCartney" }
                   };

            Person[] beatlesClone = (Person[])beatles.Clone();

        }

        static void ArrayClass()
        {
            Array intArray1 = Array.CreateInstance(typeof(int), 5);
            for (int i = 0; i < 5; i++)
            {
                intArray1.SetValue(33, i);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(intArray1.GetValue(i));
            }

            int[] lengths = { 2, 3 };
            int[] lowerBounds = { 1, 10 };
            Array racers = Array.CreateInstance(typeof(Person), lengths, lowerBounds);

            racers.SetValue(new Person { FirstName = "Alain", LastName = "Prost" }, index1: 1, index2: 10);
            racers.SetValue(new Person
            {
                FirstName = "Emerson",
                LastName = "Fittipaldi"
            }, 1, 11);
            racers.SetValue(new Person { FirstName = "Ayrton", LastName = "Senna" }, 1, 12);
            racers.SetValue(new Person { FirstName = "Michael", LastName = "Schumacher" }, 2, 10);
            racers.SetValue(new Person { FirstName = "Fernando", LastName = "Alonso" }, 2, 11);
            racers.SetValue(new Person { FirstName = "Jenson", LastName = "Button" }, 2, 12);

            Person[,] racers2 = (Person[,])racers;
            Person first = racers2[1, 10];
            Person last = racers2[2, 12];
        }
        static void SimpleArrays()
        {
            Person[] myPersons = new Person[2];

            myPersons[0] = new Person { FirstName = "Ayrton", LastName = "Senna" };
            myPersons[1] = new Person { FirstName = "Michael", LastName = "Schumacher" };

            Person[] myPersons2 =
                  {
                new Person { FirstName="Ayrton", LastName="Senna"},
                new Person { FirstName="Michael", LastName="Schumacher"}
            };
        }
    }
}
