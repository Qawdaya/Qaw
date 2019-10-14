using System;

namespace _8._4__事件
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new CarDealer();
            var michael = new Consumer("Michael");
            dealer.NewCarInfo += michael.NewCarIsHere;
            dealer.NewCar("Ferrari");
            var sebastian = new Consumer("Sebastian");
            dealer.NewCarInfo += sebastian.NewCarIsHere;
            dealer.NewCar("Mercedes");
            dealer.NewCarInfo -= michael.NewCarIsHere;
            dealer.NewCar("Red Bull Racing");
        }
    }
}
