using System;
using System.Collections.Generic;
using System.Text;

namespace _6._6__数组作为参数
{
    class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
}
