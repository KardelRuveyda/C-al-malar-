using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using(ETradeWorkContext context = new ETradeWorkContext())
            {
                return context.Products.ToList();
            }
        }

        public void Add(Product product)
        {
            using(ETradeWorkContext context = new ETradeWorkContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public void Update(Product product)
        {
            using (ETradeWorkContext context = new ETradeWorkContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Product product)
        {
            using (ETradeWorkContext context = new ETradeWorkContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
