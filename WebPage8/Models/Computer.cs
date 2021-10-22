using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebPage8.Models
{
    public class Computer
    {
        [Key]
        public int ComputerId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string HardDisk { get; set; }
        public string SystemType { get; set; }
        public string PenAndTouch { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Review> Reviews { get; set; }
        public List<ComputerOrder> ComputerOrders { get; set; }
    }
}
