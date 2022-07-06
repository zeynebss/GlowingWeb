using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class ProductDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public string PhotoUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public int CategoryId { get; set; }
        public decimal? Raiting { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public string Description { get; set; }


    }
}
