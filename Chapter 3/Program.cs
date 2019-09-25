using System;

namespace Chapter_3
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneCustomer myCustomer = new PhoneCustomer();//类声明
            PhoneCustomerStruct myCustomer2 = new PhoneCustomerStruct();//结构声明
            myCustomer.FirstName = "Simon";//实例化对象，可直接使用Object.FieldName来访问
            myCustomer2.FirstName = "Sara";
            Console.WriteLine("{0}\n{1} ", myCustomer.FirstName,myCustomer2.FirstName);
        }
    }
    class  PhoneCustomer  //类（储存在堆上）
    {
        public const string DayOfSendingBill = "Monday";
        public int CustomerID;
        public string FirstName;
        public string LastName;

    }

    struct PhoneCustomerStruct  //结构（储存在栈上）
    {
        public const string DayOfSendingBill = "Monday";
        public int CustomerID;
        public string FirstName;
        public string LastName;
    }
}
