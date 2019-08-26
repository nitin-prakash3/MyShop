using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using MyShop.Core;
using MyShop.Core.Models;

namespace MyShop.DataAccess.InMemory
{
    public class ProductRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<Product> products = new List<Product>();
        public ProductRepository()
        {
            products = cache["products"] as List<Product>;
            if (products == null)
            {
                products = new List<Product>();
            }
        }
        public void Commit()
        {
            cache["products"] = products;
        }

        public void Insert(Product p)
        {
            products.Add(p);
        }

        public void Update(Product product)
        {
            Product ProductToUpdate = products.FirstOrDefault(p => p.Id == product.Id);
            if(ProductToUpdate != null)
            {
                ProductToUpdate = product;
            }
            else
            {
                throw new Exception("Product Not Found");
            }
        }
        public Product Find(string Id)
        {
            Product Product = products.FirstOrDefault(p => p.Id == Id);
            if (Product != null)
            {
                return Product;
            }
            else
            {
                throw new Exception("Product Not Found");
            }

        }

        public IQueryable<Product> Collection(){
            return products.AsQueryable();
        }

        public void Delete(string Id)
        {
            Product ProductToDelete = products.FirstOrDefault(p => p.Id == Id);
            if (ProductToDelete != null)
            {
                products.Remove(ProductToDelete);
            }
            else
            {
                throw new Exception("Product Not Found");
            }
        }
    }
}
