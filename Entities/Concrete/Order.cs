using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
 public class Order:IEntity
    {
        public int ID { get; set; } 
        public string CustomerID { get; set; } = null!;
        public string CustomerName { get; set; } = null!;
        public string CustomerEmail { get; set; } = null!;
        public string CustomerPhone { get; set; } = null!;
        public string CustomerAddress { get; set; } = null!;
        public string OrderCode { get; set; } = null!;
        public int PaymentMethod { get; set; }
        public decimal TotalAmmount { get; set; }
        public decimal Discount { get; set; }
        public decimal DeliveryCharges { get; set; }
        public decimal FinalAmmount { get; set; }
        public DateTime PlacedOn { get; set; }

        public bool IsGuestOrder { get; set; }


    }
}
