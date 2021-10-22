using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebPage8.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime OrderFullfilled { get; set; }
        public int CustomerId { get; set; }        
        public Customer Customer { get; set; }
        public List<ComputerOrder> ComputerOrders { get; set; }        
        
    }
}
