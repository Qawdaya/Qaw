using System;
using System.Collections.Generic;
using System.Text;

namespace _5._4__泛型接口
{
   public class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override string ToString()
        {
            return string.Format("Width:{0},Height:{1}", Width, Height);
        }
    }
    public class Rectangle:Shape
    {

    }
}
