﻿#define ENTERPRISE
#define W2K
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
#if Dragon
             Console.WriteLine("Dragon is defined");
#else
            Console.WriteLine("Dragon is not defined");
 #endif
            Console.ReadKey();

#if ENTERPEISE
#if W2K
#endif
#elif PROFESSIONAL
#else
#endif


        }



    }
}

