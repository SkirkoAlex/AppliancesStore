using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppliancesStore.Models
{
    public class ProductDbInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext db)
        {
            db.Products.Add(new Product { Id =Guid.NewGuid(), Name = "Смартфон IPhone 11", Category = "Смартфоны", Price = 55_990 });
            db.Products.Add(new Product { Id = Guid.NewGuid(), Name = "Ноутбук Honor MagicBook Pro ", Category = "Ноутбуки", Price = 58_990 });
            db.Products.Add(new Product { Id = Guid.NewGuid(), Name = "Ноутбук Honor MagicBook Pro ", Category = "Ноутбуки", Price = 45_990 });
            db.Products.Add(new Product { Id = Guid.NewGuid(), Name = "Телевизор Samsung UE43TU7170U", Category = "Телевизоры", Price = 25_990 });
            db.Products.Add(new Product { Id = Guid.NewGuid(), Name = "Кофеварка рожкового типа Vitek VT-1514", Category = "Кофеварки", Price = 13_990 });
            base.Seed(db);
        }
    }
}