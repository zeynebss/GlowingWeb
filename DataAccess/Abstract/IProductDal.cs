using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        Task<List<Product>> GetAllInclude(Expression<Func<Product,bool>>? filters);  
        Task<List<Product>> GetAllFeatureds(Expression<Func<Product,bool>>? filters);
        Task<List<Product>> GetById(Expression<Func<Product, bool>>? filters);



    }
}
