using DBExample2.Models;

Console.WriteLine("Hello, World!");

var context = new BootcampContext();

var category = context.Categories.Find(2);

category.Products.Add(new() { Name = "Silgi 5", Price = 100, Stock = 10 });

context.Categories.Update(category);
context.SaveChanges();

//var category = new Category { Name = "Kalemler" };

//var product1 = new Product() { Name = "Kalem 1", Price = 100, Stock = 200, IsPublish = true, CategoryId = category.Id };

//category.Products.Add(product1);

//context.Categories.Add(category);
//context.SaveChanges();