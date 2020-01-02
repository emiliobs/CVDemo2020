using CVDemo2020.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CVDemo2020.Service
{
    public class ProductService
    {
      public List<Product> GetProductsList()
        {
            return new List<Product>
            {
                new Product{ ProductName = "Cats", Price = 800, ImageUrl = "gato.jpeg"},
                new Product{ ProductName = "Dogs", Price = 500, ImageUrl = "perro.jpg"},
                new Product{ ProductName = "Mobiles", Price = 1500, ImageUrl = "iPhonex.jpg"},
                new Product{ ProductName = "Watches", Price = 900, ImageUrl = "watch.jpg"},
                new Product{ ProductName = "Xiomi", Price = 741, ImageUrl = "xiaomim1a2.jpg"},
                new Product{ ProductName = "Boas", Price = 9512, ImageUrl = "boa.jpeg"},
                new Product{ ProductName = "Shop", Price = 13544, ImageUrl = "splash.jpg"},
            };
        }
    }
}
