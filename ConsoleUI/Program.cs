﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new InMemoryCarDal());
            foreach (var car in carmanager.GetAll())
            {
                Console.WriteLine(car.ModelYear+" "+car.Description);
            }
        }
    }
}
