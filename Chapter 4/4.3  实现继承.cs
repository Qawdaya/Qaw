using System;

namespace Chapter_4
{

    public abstract class genericcustmer
    {
        private string name;
        public genericcustmer(string name)
        {
            this.name=name;
        }

    }
    class neverore60custmer:genericcustmer
    {
        private uint highcostminutesused;
        public neverore60custmer(string name):base(name)
        {
            Console.WriteLine(name);
        }
        
        public neverore60custmer(string name,string referername):base(name)
        {
            this.referername = referername;
           
        }
        private string referername;
      
      
    } 


    class Program
    {
        static void main(string[] args)
        {

          genericcustmer genericcustmer= new neverore60custmer("Arabel");

            Console.ReadKey();
           
        }
    }
}
