using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                 new Car { Id = 1, BrandId = 1, ColorId = 4, ModelYear = 2009, DailyPrice = 120000, Description = "Fiat Linea  1.4 Fire Active Plus " },
                 new Car { Id = 2, BrandId = 2, ColorId = 1, ModelYear = 2015, DailyPrice = 180000, Description = "Ford Fiesta  1.5 TDCi Titanium " },
                 new Car { Id = 3, BrandId = 1, ColorId = 1, ModelYear = 2011, DailyPrice = 140000, Description ="Fiat Punto EVO 1.3 Multijet"},
                 new Car { Id = 4, BrandId = 2, ColorId = 3, ModelYear = 2018, DailyPrice = 380000, Description = " Volkswagen Golf 1.4 TSI Comfortline" } 
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(int Id)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == Id);
            _cars.Remove(carToDelete);
        }

        public void Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
        }

        public List<Car> GetAll()
        {
            return _cars;
        }
        List<Car> GetById(int byId)
        {
            return _cars.Where(c => c.Id == byId).ToList();

        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
