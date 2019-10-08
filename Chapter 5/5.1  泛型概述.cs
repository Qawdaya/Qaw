using System;
using System.Collections;
using System.Collections.Generic;    
/// 
/// </summary>
namespace Chapter_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(44);
            int il = (int)list[0];
            foreach(int i2 in list)
            {
                Console.WriteLine(i2);
            }
            /*List<T>类的泛型类型定义为int，所以int类型在JIT编译器动态生成的类中使用，不再进行装箱和拆箱操作*/
            var list2 = new List<int>();
            list2.Add(44);
            int i1 = list2[0];
            foreach(int i2 in list)
            {
                Console.WriteLine(i2);
            }
            
        }
    }
}
