using CVDemo2020.Model;
using CVDemo2020.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVDemo2020.ViewModel
{
    class ProductViewModel
    {
        public  List<Product> Products { get; set; }

        public ProductViewModel()
        {
            Products = new ProductService().GetProductsList();
        }
    }
}
