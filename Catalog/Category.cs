using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog
{
    public class Category
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }        
        public List<Products> Products { get; set; }

        public static Category ContructorCategory(Categories cat, List<Products> lista)
        {
            return new Category
            {
                Id = cat.Id,
                Name = cat.Name,
                Description = cat.Description,
                Products = lista
            };
        }
    }
}
