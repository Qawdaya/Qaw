using System;

namespace _6._5__Array类
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        static void ArrayClass()
        {
             Array intArrayl = Array.CreateInstance(typeof(int), 5);
            for(int i=0;i<5;i++)
            {
                intArrayl.SetValue(33, i);
            }
            for(int i=0;i<5;i++)
            {
                Console.WriteLine(intArrayl.GetValue(i));
            }
            int[] intArray2 = (int[])intArrayl;
            int[] lengths = { 2, 3 };
            int[] lowerBounds = { 1, 10 };
            Array racers = Array.CreateInstance(typeof(Person), lengths, lowerBounds);
            racers.SetValue(new Person { FirstName = "Alain", LastName = "Prost" }, index1: 1, index2: 10);
            racers.SetValue(new Person { FirstName = "Emerson", LastName = "Fittipaldi" }, 1,11);
            racers.SetValue(new Person { FirstName = "Ayrton", LastName = "Senna" }, 1, 12);
            racers.SetValue(new Person { FirstName = "Micheal", LastName = "Schumacher" }, 2, 10);
            racers.SetValue(new Person { FirstName = "Fernando", LastName = "Alonso" }, 2, 11);
            racers.SetValue(new Person { FirstName = "Jenson", LastName = "Button" }, 2, 12);
            Person[,] racers2 = (Person[,])racers;
            Person first = racers2[1, 10];
            Person last = racers2[2, 12];
        }
    }
}
