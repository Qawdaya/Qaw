using System;

namespace Chapter_4
{
    class mydrivedClass
    {
        public void setn(int i)
        {
            c = i;
            
        }
      public interface setn2
        {
            int getnu2(int a);
        }
    
        protected int c;
      
    }
    
    class my:mydrivedClass
        {
        public int Getnut()
        {
            return (c*c);
        }
        public int getnut2(int a)
        {
            return (a + 2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            my m = new my();
            int f;
            m.setn(3);
            f = m.Getnut();
            Console.WriteLine(m.Getnut());
            Console.WriteLine(m.getnut2(f));
        }
    }
}
