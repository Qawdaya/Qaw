using System;

namespace Chapter_3
{
    class Program
    {
      
        static void Main(string[] args)
        {
            string Fullname(string firstname,string lastname)
        {
            return firstname + " " + lastname;
        }
           Console.WriteLine( Fullname("John", "Doe"));
            Console.WriteLine( Fullname(lastname: "Doe", firstname: "John"));
          
        }
    }
    
  }
   

    

