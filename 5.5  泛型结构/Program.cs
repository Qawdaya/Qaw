using System;

namespace _5._5__泛型结构
{
    public struct Nullable<T>
        where T:struct
    {
        public Nullable(T value)
        {
            
            this.hasValue = true;
            this.value = value;
        }
        private bool hasValue;
        public bool HasValue
        {
            get
            {
                return hasValue;
            }


        }
        private T value;
        public T Value
        {
            get
            {
                if(!hasValue)
                {
                    throw new InvalidOperationException("no value");

                }
                return value;
            }
        }
        public static explicit operator T(Nullable<T> value)
        {
            return value.Value;
        }
        public static implicit operator Nullable<T>(T value)
        {
            return new Nullable<T>(value);
        }
        public override string ToString()
        {
            if (!HasValue)
                return String.Empty;
            return this.value.ToString();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> nullable = 3;
            Console.WriteLine(nullable);
            int? y = null;
            Console.WriteLine(y);
            y = 9;
            Console.WriteLine(y);
        }
    }
}
