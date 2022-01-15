using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public IResult Add(Customer customer)
        {
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customer)
        {
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetByUserId(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(c => c.UserId == id));
        }

        public IResult Update(Customer customer)
        {
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
