using System;
using System.Collections.Generic;
using System.Text;

namespace _5._4__泛型接口
{
  public  interface IIndex<out T>
    {
        T this[int index] { get; }
        int Count { get; }
    }
}
