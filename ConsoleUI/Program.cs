using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
     class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetByDailyPrice(500,1000))
            {
                Console.Write(car.CarName+" - ");
                Console.Write(car.Description+" - ");
                Console.WriteLine(car.DailyPrice+"TL");

            }
            
        }
    }
}
