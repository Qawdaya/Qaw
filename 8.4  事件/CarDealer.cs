using System;
using System.Collections.Generic;
using System.Text;

namespace _8._4__事件
{
   public class CarInfoEventArgs:EventArgs
    {
        public CarInfoEventArgs(string car)
        {
            this.Car = car;
        }
        public string Car { get; set; }
    }
    public  class CarDealer
    {
        public event EventHandler<CarInfoEventArgs> newCarInfo;
        public void NewCar(string car)
        {
            Console.WriteLine("CarDealer,new car{0}", car);
            RaiseNewCarInfo(car);
        }
        protected virtual void RaiseNewCarInfo(string car)
        {
            EventHandler<CarInfoEventArgs> newCarInfo = newCarInfo;
        if(newCarInfo!=null)
            {
                newCarInfo(this, new CarInfoEventArgs(car));
            }

        }
    }
}
