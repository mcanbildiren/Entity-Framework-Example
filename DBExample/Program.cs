using DBExample.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using (var dbContext = new AppDbContext())
{
    var product = new Product() { Name = "kalem 1", Price = 100, Stock = 10, IsPublish = false };
    var product2 = new Product() { Name = "kalem 2", Price = 100, Stock = 10, IsPublish = false };

    dbContext.Products.Add(product);
    dbContext.Products.Add(product2);
    dbContext.SaveChanges();

    Console.WriteLine(product);
    Console.WriteLine(product2);

}

using (var dbContext = new AppDbContext())
{
    var products = dbContext.Products.AsNoTracking().ToList();

    //products[0].Name = "asdasd";
    //dbContext.Products.Update(products[0]);

    //1.yol
    //dbContext.Products.Remove(products.First());

    //2. yol, track edilmeyen data ile kullanılabilir. update için de kullanılabilir.
    dbContext.Entry(products[0]).State = EntityState.Deleted;

    products.ForEach(x => Console.WriteLine(dbContext.Entry(x).State));

    dbContext.SaveChanges();
    Console.WriteLine("----------------------------------");

    dbContext.Products.AsNoTracking().ToList().ForEach(x => Console.WriteLine(x));
}


