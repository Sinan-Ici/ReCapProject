using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            //foreach (var car in carmanager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine(car.ModelYear+" "+car.Description);
            //}
            carmanager.Add(new Car {Id=5, BrandId = 4, ColorId = 3, ModelYear = 2014, DailyPrice = 432500, Description = "Volkswagen 1.6 TDI BlueMotion Comfortline" });
            foreach (var car in carmanager.GetAll())
            {
                Console.WriteLine(car.ModelYear + " " + car.Description);
            }


        }
    }
}
