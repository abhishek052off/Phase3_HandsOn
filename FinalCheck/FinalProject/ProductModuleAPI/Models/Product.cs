using System;
using System.Collections.Generic;

#nullable disable

namespace ProductModuleAPI.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public int Rating { get; set; }
        public bool IsAvailable { get; set; }
    }
}
