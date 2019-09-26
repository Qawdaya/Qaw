using System;
using System.Drawing;
namespace Chapter_3
{

    class PersonSta
    {
        private static string name;//静态字段
        public static string Name //静态属性
        {
            get
            {
                return name;
            }
        }
        static PersonSta() //静态构造函数，仅执行一次
        {
            Console.WriteLine("静态构造函数被调用了");


          name = "keep moving";
            
            Console.WriteLine("静态构造函数被调用了2");

        }

    }

    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine(PersonSta.Name);
           
            Console.WriteLine(PersonSta.Name);
        }

    }
        
    }
        
    
    
  
   

    

