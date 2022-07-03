using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public  class OrderItem
    {
        public int OrderID { get; set; }

   public int ID { get; set; }
        public string? ProductName { get; set; }
        public int ProductID { get; set; }
        public decimal ItemPrice { get; set; }

        public int Quantity { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}
