using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._7__枚举
{
    public class HelloCollection
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "Hello";
            yield return "World";
        }
    }
    
    class Program
    {
       
        static void MusicTitles()
        {
            var titles = new MusicTitles();
            foreach (var title in titles)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();
            Console.WriteLine("reverse");
            foreach (var title in titles.Reverse())
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();
            Console.WriteLine("subset");
            foreach (var title in titles.Subset(2, 2))
            {
                Console.WriteLine(title);
            }
        }
         static void HelloWorld()
        {
            var helloCollection = new HelloCollection();
            foreach(var s in helloCollection)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
            HelloWorld();
            MusicTitles();
            var game = new GameMoves();

            IEnumerator enumerator = game.Cross();
            while (enumerator.MoveNext())
            {
                enumerator = enumerator.Current as IEnumerator;
            }
        }
    }
}
