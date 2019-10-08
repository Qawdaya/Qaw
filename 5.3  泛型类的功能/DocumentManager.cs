using System;
using System.Collections.Generic;

namespace _5._3__泛型类的功能
{

  public  class DocumentManager<T>
        where T : IDocument
    {
        private readonly Queue<T> documentQueue = new Queue<T>();
        public void Document(T doc)
        {
            lock(this)
            {
                documentQueue.Enqueue(doc);
            }
        }
        /*5.3.1  默认值*/
        public bool IsDocumentAvailable
        {
            get { return documentQueue.Count > 0; }
        }
        public void DisplayAllDocument()
        {
            foreach(T doc in documentQueue)
            {
               // Console.WriteLine(((IDocument)doc).Title);
                Console.WriteLine(doc.Title);
            }
        }   
        public T GetDocument()
    {
        T doc = default(T);
        lock (this)
        {
                doc = documentQueue.Dequeue();
        }
            return doc;
    }
    }
    
   
}
