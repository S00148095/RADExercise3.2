using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise3c.Models;

namespace Exercise3c.DAL
{
    public class ProductRepository : IProductRepository
    {
        private SampleDBEntities context;

        public ProductRepository(SampleDBEntities context)
        {
            this.context = context;
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public List<Product> GetProducts()
        {
            return context.Products.ToList();
        }
    }
}