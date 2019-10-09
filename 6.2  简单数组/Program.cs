using System;

namespace _6._2__简单数组
{
    public class Persom
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[] { 1, 2, 3, 4 };
            int v1 = myarray[0];
            int v2 = myarray[1];
            int v3 = myarray[2];
            Console.WriteLine("{0} {1} {2}", v1, v2, v3);
            for(int i=0;i<myarray.Length;i++)
            {
                Console.WriteLine(myarray[i]);
            }
            foreach(int i in myarray)
            {
                Console.WriteLine(i);
            }
            Persom[] persoms = new Persom[2];
            persoms[0] = new Persom { FirstName = "Amy", LastName = "Senna" };
            persoms[1] = new Persom { FirstName = "Michael", LastName = "Schumacher" };
            for(int c=0;c<persoms.Length;c++)
            {
                Console.WriteLine(persoms[c]);
            }
            Persom[] persoms1 = { new Persom { FirstName = "Amy", LastName = "Senna" },
                                  new Persom { FirstName = "Michael", LastName = "Schumacher" }
                                 };
            for(int e=0;e<persoms1.Length;e++)
            {
                Console.WriteLine(persoms1[e]);
            }
        }
      

        
    }
}
