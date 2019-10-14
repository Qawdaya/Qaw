using System;
using System.Collections.Generic;
using System.Text;

namespace _8._4__事件
{
    class Consumer
    {
        private string name;
        public Consumer(string name)
        {
            this.name = name;
        }
        public void NewCarIsHere(object sender,CarInfoEventArgs e)
        {
            Console.WriteLine("{0}:car{1} is new", name, e.Car);
        }
    }
}
