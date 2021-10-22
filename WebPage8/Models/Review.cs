using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebPage8.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public string Text { get; set; }
        public string Rating { get; set; }
        public int ComputerId { get; set; }
        public Computer Computer { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }         
    }
}
