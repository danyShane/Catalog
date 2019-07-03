using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog
{
    public class Products
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
