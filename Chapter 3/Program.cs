using System;
using System.Drawing;
namespace Chapter_3
{
   public class Userpreferences
    {
        public static readonly Color BlackColor;
        static Userpreferences()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
                BlackColor = Color.Green;
            else
                BlackColor = Color.Red;
        }

    }
     
        
    class Program
    {
       static void Main(string[] args)
        {

            Console.WriteLine("user_preferences:blackcolor is:"+Userpreferences.BlackColor.ToString());
         
           
        }

    }
        
    }
        
    
    
  
   

    

