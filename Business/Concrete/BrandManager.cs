using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        public IResult Add(Brand brand)
        {
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Brand brand)
        {
            return new SuccessResult(Messages.BrandUpdated);
        }
    }
}
