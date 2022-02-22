using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car,ReCapProjectContext>,ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto { Id = c.Id, 
                                 CarName = c.Description, 
                                 BrandName = b.Name,
                                 ColorName = co.Name, 
                                 DailyPrice = c.DailyPrice,
                                 ModelYear=c.ModelYear, 
                                 CarImages = ((from ci in context.CarImages
                                                          where (c.Id == ci.CarId)
                                                          select new CarImage
                                                          {
                                                              Id = ci.Id,
                                                              CarId = ci.CarId,
                                                              Date = ci.Date,
                                                              ImagePath = ci.ImagePath
                                                          }).ToList()) };
                return filter is null ? result.ToList() : result.Where(filter).ToList();
            }
        }
        
        
    }
}
