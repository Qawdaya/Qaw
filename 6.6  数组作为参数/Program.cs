using System;

namespace _6._6__数组作为参数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static Person[] GetPerson()
            {
            return new Person[]
            {
                new Person{FirstName="damon",LastName="Hill"},
                 new Person{FirstName="Niki",LastName="Lauda"},
                  new Person{FirstName="Ayrton",LastName="Sonna"},
                   new Person{FirstName="Graham",LastName="Hill"},
            };
            }
        static void DisplayArray(object[]data)
        {

        }
    }
}
