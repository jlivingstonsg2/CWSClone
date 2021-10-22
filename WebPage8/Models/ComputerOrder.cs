using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebPage8.Models
{
    public class ComputerOrder
    {
        [Key]
        public int ComputerOrderId { get; set; }
        public int Quantity { get; set; }
        public int ComputerId { get; set; }
        public Computer Computer { get; set; }
        public int OrderId { get; set; }      
        public Order Order { get; set; }
    }
}
