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
        static void main(string[] args)
        {

            var list = new List<int>();
            list.Add(44);
            var stringlist = new List<string>();
            stringlist.Add("mystring");
            var myclasslist=new List<myclass>();
            myclasslist.Add(new myclass());
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            foreach (string i2 in stringlist)
            {
                Console.WriteLine(i2);
            }
            
        }
    }
}
