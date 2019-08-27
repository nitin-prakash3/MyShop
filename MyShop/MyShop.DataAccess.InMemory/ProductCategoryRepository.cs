using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.InMemory
{
    public class ProductCategoryRepository
    {
        ObjectCache cache = MemoryCache.Default;
        List<ProductCategory> productCategories = new List<ProductCategory>();
        public ProductCategoryRepository()
        {
            productCategories = cache["productCategories"] as List<ProductCategory>;
            if (productCategories == null)
            {
                productCategories = new List<ProductCategory>();
            }
        }
        public void Commit()
        {
            cache["productCategories"] = productCategories;
        }

        public void Insert(ProductCategory p)
        {
            productCategories.Add(p);
        }

        public void Update(ProductCategory ProductCategory)
        {
            ProductCategory ProductCategoryToUpdate = productCategories.FirstOrDefault(p => p.Id == ProductCategory.Id);
            if (ProductCategoryToUpdate != null)
            {
                ProductCategoryToUpdate = ProductCategory;
            }
            else
            {
                throw new Exception("Product Category Not Found");
            }
        }
        public ProductCategory Find(string Id)
        {
            ProductCategory ProductCategory = productCategories.FirstOrDefault(p => p.Id == Id);
            if (ProductCategory != null)
            {
                return ProductCategory;
            }
            else
            {
                throw new Exception("Product Category Not Found");
            }

        }

        public IQueryable<ProductCategory> Collection()
        {
            return productCategories.AsQueryable();
        }

        public void Delete(string Id)
        {
            ProductCategory ProductCategoryToDelete = productCategories.FirstOrDefault(p => p.Id == Id);
            if (ProductCategoryToDelete != null)
            {
                productCategories.Remove(ProductCategoryToDelete);
            }
            else
            {
                throw new Exception("Product Category Not Found");
            }
        }
    }
}
