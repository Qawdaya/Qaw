using System;
using System.Collections.Generic;
using System.Text;

namespace _5._4__泛型接口
{
      public interface IDsplay<in T>
    {
        void Show(T item);
    }
}
