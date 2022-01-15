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
            var result = carmanager.GetCarDetails();
            if (result.Succcess == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice + "\n");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {
                FirstName = "Alperen",
                LastName = "Sazak",
                Email = "crazy_boy@gmail.com",
                Password = "1234",


            });
            var userresult = userManager.GetAll();
            if (userresult.Succcess == true)
            {
                foreach (var users in userresult.Data)
                {
                    Console.WriteLine(users.FirstName + " " + users.LastName + " " + users.Email);
                }
            }

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                Id = 1,
                UserId = 1,
                CompanyName = "Ziyagil"
            });





        }
    }
}
