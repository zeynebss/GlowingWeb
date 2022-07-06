using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFProductDal : EFEntityRepositoryBase<Product, GlowingDBcontext>, IProductDal
    {
        public Task<List<Product>> GetAllFeatureds(Expression<Func<Product, bool>>? filters)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllInclude(Expression<Func<Product, bool>>? filters)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetById(Expression<Func<Product, bool>>? filters)
        {
            throw new NotImplementedException();
        }
    }
}
