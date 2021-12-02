using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        public void Add(Car car);
        public void Update(Car car);
        public void Delete(int Id);
        List<Car>GetById(int byId);
        List<Car> GetAll();

    }
}
