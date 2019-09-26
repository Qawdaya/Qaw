using System;
namespace runoob
{
    class Student
    {

        private string name = "not known";
        private int age = 0;

  

        // 声明类型为 string 的 Name 属性
        public string Name  //只读
        {
            get
            {
                return name;
            }
         /*  set
            {
                name = value;
            }*/
        }

        // 声明类型为 int 的 Age 属性
        public int Age //只读
        {
            get
            {
                return age;
            }
           /* set
            {
                if(age<0)
                {
                    age = 0;
                }
                else
                age = value;
            }*/
        }
        //重写了object类的ToString()方法
        public override string ToString()  
        {
            return  " Name = " + Name + ", Age = " + Age;
        }
    }
    class ExampleDemo
    {
        public static void Main()
        {
            // 创建一个新的 Student 对象
            Student s = new Student();

            // 设置 student 的 name 和 age
           // s.Name = "Zara";
           // s.Age = 9;
            Console.WriteLine("Student Info: {0}", s);
            // 增加年龄
           // s.Age += 1;
            Console.WriteLine("Student Info: {0}", s);
            Console.ReadKey();
        }
    }
}