using System;
using System.Collections.Generic;
using System.Text;

namespace _6._5._3__排序
{  public enum PersonComparerType
        {
            FirstName,LastName
        }
    class PersonComparer:IComparer<Person>
    {
        
            private PersonComparerType comparerType;
            public PersonComparer(PersonComparerType comparerType)
            {
                this.comparerType = comparerType;
            }
            public int Compare(Person x,Person y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return 1;
                if (y == null) return -1;
                switch(comparerType)
                {
                    case PersonComparerType.FirstName:
                        return x.FirstName.CompareTo(y.FirstName);
                    case PersonComparerType.LastName:
                        return x.LastName.CompareTo(y.LastName);
                    default:
                        throw new ArgumentException(
                              "unexpected compare type");
                }
            }
        
    }
}
