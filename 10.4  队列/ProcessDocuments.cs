using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10._4__队列
{
 public   class ProcessDocuments
    {
        public static void Start(DocumentManager dm)
        {
            Task.Factory.StartNew(new ProcessDocuments(dm).Run);
        }
        protected ProcessDocuments(DocumentManager dm)
        {
            if (dm == null)
                throw new ArgumentNullException("dm");
            documentManager = dm;
        }
        private DocumentManager documentManager;
       private void Run()
        {
            while(true)
            {
                if(documentManager.IsDocumentAvailable)
                {
                    Document doc = documentManager.GetDocument();
                    Console.WriteLine("Processing document {0}", doc.Title);
                }
                Thread.Sleep(new Random().Next(20));
            }
        }
    }
}

