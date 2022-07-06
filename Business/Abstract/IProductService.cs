using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task<List<Product>> GetFeatureds();
        Task<List<Product>> GetAllDiscounts();
        Task<List<Product>> GetById( int? id);


        Task<List<Product>> GetRelateds();
        Task<List<Product>> GetProductByCategory( int? categoryId);





    }
}
