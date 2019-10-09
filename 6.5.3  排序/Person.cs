using System;
using System.Collections.Generic;
using System.Text;

namespace _6._5._3__排序
{
    public class Person:IComparable<Person>
    { public string LastName { get; set; }
        public string FirstName { get; set; }
        public override string ToString()
        {
            return String.Format("{0} {1}",
                  FirstName, LastName);
        }
        public int CompareTo(Person other)
        {
            if (other == null) return 1;
            int result = string.Compare(this.LastName, other.LastName);
            if(result==0)
            {
                result = string.Compare(this.LastName, other.LastName);
            }
            return result;
        }
      
        
    }
}
