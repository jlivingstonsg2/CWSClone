using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Models;

namespace WebPage8.ViewModels
{
    public class CategoryViewModel
    {
        public List<Category> Categories = new List<Category>();
        public string Search { get; set; }
    }
}
