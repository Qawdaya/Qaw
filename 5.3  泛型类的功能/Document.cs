using System;
using System.Collections.Generic;
using System.Text;

namespace _5._3__泛型类的功能
{/*5.3.2约束*/
    public interface IDocument
    {
        string Title { get; set; }
        string Content { get; set; }

    }
    public class Document:IDocument
    {
        public Document()
        { }
        public Document(string title,string content)
        {
            this.Title = title;
            this.Content = content;
        }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
