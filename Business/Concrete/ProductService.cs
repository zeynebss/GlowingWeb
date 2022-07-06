using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductDal _dal;
public ProductService(IProductDal dal)
        {
            _dal = dal;
        }

        public async Task<List<Product>> GetAllDiscounts()
        {
            var products = await _dal.GetAllInclude(x => x.Discount != 0 && x.Discount != null);
            return products;
        }


        public async Task<List<Product>> GetById(int? id)
        {
            return await _dal.GetById(x=>x.ID == id);
        }

        public Task<List<Product>> GetDiscount()
        {
            throw new NotImplementedException();
        }

       

        public async Task<List<Product>> GetFeatureds()
        {
           var products=await _dal.GetAllFeatureds(x=>!x.IsDeleted);
            return products;
        }

        public async Task<List<Product>> GetProductByCategory(int? categoryId)
        {
            var products=await _dal.GetAllInclude(x=>x.CategoryID==categoryId); 
            return products;    
        }

        public async Task<List<Product>> GetProducts()
        {
          
              var   products=await _dal.GetAllInclude(x=> !x.IsDeleted);
            return products;
        }

        public Task<List<Product>> GetRelateds()
        {
            throw new NotImplementedException();
        }


       
    }
}
