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
    public class ColorManager : IColorService
    {
        IColorDal _colordal;
        public IResult Add(Color color)
        {
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Color>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Color color)
        {
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
