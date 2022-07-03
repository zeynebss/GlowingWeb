using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;  
        public decimal Price { get; set; }  
        public decimal Discount { get; set; }   
        public string PhotoUrl { get; set; }    
        public bool IsDeleted { get; set; } 
        public int CategoryID { get; set; } 

    }
}
