using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //generic, class:referans tip, IEntity olabilir veya Ientity implemente eden bir nesne olabilir, newlenebilir olmalı.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//filtremelek için kullanıyoruz. İstersek null verip filtresiz çağırabiliriz. Bu şekilde yazarak ayrı ayrı metod kullanmadan filtremele işleme yapabiliriz.
        T Get(Expression<Func<T, bool>> filter);
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
