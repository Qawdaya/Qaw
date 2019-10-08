using System;
using System.Collections;
namespace _5._3__泛型类的功能
{
    public class StaticDemo<T>
    {
        public static int x;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var dm = new DocumentManager<Document>();
            dm.Document(new Document("Title A", "Sample A"));
            dm.Document(new Document("Title B", "Sample B"));
            dm.DisplayAllDocument();
            if(dm.IsDocumentAvailable)
            {
                Document d = dm.GetDocument();
                Console.WriteLine(d.Content);
            }
            /*静态成员*/
            StaticDemo<string>.x = 4;
            StaticDemo<int>.x = 5;
            Console.WriteLine(StaticDemo<string>.x);
        }
    }
}
