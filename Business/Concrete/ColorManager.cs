using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
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
        public ColorManager(IColorDal colorDal)
        {
            _colordal = colorDal;
        }
        public IResult Add(Color color)
        {
            ValidationTool.Validate(new ColorValidator(), color);
            _colordal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
        }

        public IResult Delete(Color color)
        {
            return new SuccessResult(Messages.ColorDeleted);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colordal.GetAll());
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
