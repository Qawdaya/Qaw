using System;

namespace _6._6__数组作为参数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ar1 = { 1, 4, 5, 11, 13, 18 };
            int[] ar2 = { 3, 4, 5, 18, 21, 27, 33 };
            var segments = new ArraySegment<int>[2]
            {
                new ArraySegment<int>(ar1,0,3),
                new ArraySegment<int>(ar2,3,3)
            };
            var sum = SumOfSegments(segments);
            Console.WriteLine(sum);
        }
        static int SumOfSegments(ArraySegment<int>[]segments)
        {
            int sum = 0;
            foreach(var segment in segments)
            {
                for(int i=segment.Offset;i<segment.Offset+segment.Count;i++)
                {
                    sum += segment.Array[i];
                }
            }
            return sum;
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
        static void DisplayArray(object[] data)
        {
        }

    }
}
