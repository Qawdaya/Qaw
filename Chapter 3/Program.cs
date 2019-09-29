using System;
using System.Drawing;
namespace Chapter_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var captain = new { firstname = "James", middlename = "T", Lastname = "Kirk" };
            Console.WriteLine(captain);
            var doctor = new { firstname = "tony", middlename = "", Lastname = "Kirk" };
            Console.WriteLine(doctor);
            doctor = captain;
            Console.WriteLine(doctor);
            var captain2 = new { doctor.firstname, doctor.middlename, doctor.Lastname };
            Console.WriteLine(captain2);
        }

    }

}

