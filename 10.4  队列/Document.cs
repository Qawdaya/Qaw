using System;
using System.Collections.Generic;
using System.Text;

namespace _10._4__队列
{
   public  class Document
    {
        public string Title { get; private set; }
        public string Content { get; private set; }

        public Document(string title,string content)
        {
            this.Title = title;
            this.Content = content;
        }
    }
}
