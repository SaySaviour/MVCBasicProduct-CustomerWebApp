using Entities.Concrate;
using Microsoft.VisualBasic;
using System.Collections.Generic;

namespace MvcWebUI.Models
{
    public class ProductListViewModel
    {
        public List<Product> Products { get; set; }
        public Product Product { get; set; }
    }
}
