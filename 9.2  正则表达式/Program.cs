using System;
using System.Text.RegularExpressions;
namespace _9._2__正则表达式
{
    class Program
    {
        static void WriteMatch(string text,MatchCollection matches)
        {
            Console.WriteLine("Original text was:\n\n" + text + "\n");
            Console.WriteLine("NO.of matches:" + matches.Count);
            foreach(Match nextMatch in matches)
            {
                int index = nextMatch.Index;
                string result = nextMatch.ToString();
                int charsBefore = (index < 5) ? index : 5;
                int fromEnd = text.Length - index - result.Length;
                int charsAfter = (fromEnd < 5) ? fromEnd : 5;
                int charToDisplay = charsBefore + charsAfter + result.Length;
                Console.WriteLine("Index:{0},\tString:{1},\t{2}", index, result, text.Substring(index - charsBefore, charToDisplay));
            }
        }
        static void Find2()
        {
            string text = @"This comprehensive compendium provides a broad and thorough investigation of all aspects of programming with ASP.NET.Entirely revised and updated for the 3.5 Release of.NET,this book will give you the information you need to master ASP.NET and build a dynamic,successful,enterprise Web application.";
            string pattern = @"\ba";
            MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
            WriteMatch(text, matches);
         }
        static void Main(string[] args)
        {
            Find2();
            Console.ReadLine();

        }
    }
}
