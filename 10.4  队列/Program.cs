using System;
using System.Threading;

namespace _10._4__队列
{
    class Program
    {
        static void Main(string[] args)
        {
            var dm = new DocumentManager();
            ProcessDocuments.Start(dm);
            for(int i=0;i<1000;i++)
            {
                var doc = new Document("Doc" + i.ToString(), "content");
                dm.AddDocument(doc);
                Console.WriteLine("Added document {0}", doc.Title);
                Thread.Sleep(new Random().Next(20));
            }
        }
    }
}
