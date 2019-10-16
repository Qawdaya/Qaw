using System;
using System.Text.RegularExpressions;
namespace _9._2__正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myText = @"This comprehensive compendium provides a broad and thorough 
                                 investigation of all aspects of programming with ASP.NET.Entirely revised and updated for the 
                                 fourth release of.NET,this book will give you the information you need to master ASP.NET and 
                                 build a dynamic,successful,enterprise Web application.";
            const string pattern = "ion";
            MatchCollection myMathes = Regex.Matches(myText, pattern, RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture);
            foreach(Match nextMatch in myMathes)
            {
                Console.WriteLine(nextMatch.Index);
            }
        }
    }
}
