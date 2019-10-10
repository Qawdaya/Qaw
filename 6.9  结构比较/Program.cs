using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace _6._9__结构比较
{
    class TupleComparer : IEqualityComparer
    {
        #region IEqualityComparer Members

        public new bool Equals(object x, object y)
        {
            bool result = x.Equals(y);
            return result;
        }

        public int GetHashCode(object obj)
        {
            return obj.GetHashCode();
        }

        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
            var janet = new Person { FirstName = "Janet", LastName = "Jackson" };
            Person[] person1 =
            {
                new Person
                {
                    FirstName ="Michael",
                    LastName="Jackson"
                },
                janet
            };
            Person[] person2 =
           {
                new Person
                {
                    FirstName ="Michael",
                    LastName="Jackson"
                },
                janet
            };
            if (person1 != person2)
                Console.WriteLine("not the same reference");
            if ((person1 as IStructuralEquatable).Equals(person2, EqualityComparer<Person>.Default))
            {
                Console.WriteLine("the same content");
            }
            var t1 = Tuple.Create<int, string>(1, "Stephanie");
            var t2 = Tuple.Create<int, string>(1, "Stephanie");
            if(t1!=t2)
            {
                Console.WriteLine("not the same reference to the tuple");
            }
            if (t1.Equals(t2))
                Console.WriteLine("the same content");
            
        }
    }
}
