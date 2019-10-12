using System;
using System.Collections.Generic;
using System.Text;

namespace _8._2._5__BubbleSorter示例
{
    class Employee
    {
        public Employee(string name,decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public override string ToString()
        {
            return string.Format("{0},{1:c}", Name, Salary);
        }
        public static bool CompareSalary(Employee e1,Employee e2)
        {
            return e1.Salary < e2.Salary;
        }
    }
}
