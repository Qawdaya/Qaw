using System;
using System.Collections;
using System.Collections.Generic;    
/// 
/// </summary>
namespace Chapter_5
{ class myclass
    {
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<int>();
            list.Add(44);
            //list.Add("mystring");
            //list.Add(new myclass());
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
