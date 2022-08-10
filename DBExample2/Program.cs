using DBExample2.Models;

Console.WriteLine("Hello, World!");

var context = new BootcampContext();

var products = context.Products.ToList();

products.ForEach(p =>
{
    Console.WriteLine(p.Name);
});
