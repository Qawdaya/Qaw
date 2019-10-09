using System;
using System.Collections.Generic;
using System.Text;

namespace _5._4__泛型接口
{
     public  class ShapeDisplay:IDsplay<Shape>
    {
        public void Show(Shape s)
        {
            Console.WriteLine("{0}Width:{1},Height:{2}", s.GetType().Name, s.Width, s.Height);
        }
    }
}
