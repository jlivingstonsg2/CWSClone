using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebPage8.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string BrandUrl { get; set; }
        public string Description { get; set; }        
        public List<Computer> Computers { get; set; }
    }
}