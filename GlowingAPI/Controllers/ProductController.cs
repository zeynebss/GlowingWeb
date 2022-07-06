using AutoMapper;
using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GlowingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ProductController : ControllerBase
    {
        // GET: api/<ProductController>
        IProductService _service;
        private readonly IMapper _mapper;

        public ProductController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IEnumerable<ProductDTO>> Get()
        {
            var products = await _service.GetProducts();
            var _mapperProducts = _mapper.Map<List<Product>, List<ProductDTO>>(products);
            return _mapperProducts;
        }

        // GET api/<ProductController>/5
        [HttpGet("featured")]
        public async Task<IEnumerable<ProductDTO>> GetFeatureds()
        {
            var products = await _service.GetFeatureds();
            var _mapperProducts = _mapper.Map<List<Product>, List<ProductDTO>>(products);
            return _mapperProducts;
        }
        [HttpGet("discount")]
        public async Task<IEnumerable<ProductDTO>> GetAllDiscounts()
        {
            var products = await _service.GetAllDiscounts();
            var _mapperProducts = _mapper.Map<List<Product>, List<ProductDTO>>(products);
            return _mapperProducts;
        }
    
        [HttpGet("category/{categoryId}")]
        public async Task<List<ProductDTO>> GetProductByCategory(int? categoryId)
        {
            var product = await _service.GetProductByCategory(categoryId);
            var _mapperProducts = _mapper.Map<List<Product>, List<ProductDTO>>(product);
            return _mapperProducts;
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
