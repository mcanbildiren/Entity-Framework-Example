using DBExample2.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

var context = new BootcampContext();

//var category = context.Categories.Find(2);

//category.Products.Add(new() { Name = "Silgi 5", Price = 100, Stock = 10 });

//context.Categories.Update(category);
//context.SaveChanges();

//var category = new Category { Name = "Kalemler" };

//var product1 = new Product() { Name = "Kalem 1", Price = 100, Stock = 200, IsPublish = true, CategoryId = category.Id };

//category.Products.Add(product1);

//context.Categories.Add(category);
//context.SaveChanges();

//var category = context.Categories.First();

//var product = new Product() { Name = "Kalem X", Price = 100, Stock = 10, IsPublish = true, Category = category };

//product.ProductFeature = new ProductFeature() { Color = "Red", Height = 10, Width = 20 };

//context.Products.Add(product);
//context.SaveChanges();


//var newStudent = new Student() { Name = "Can" };

//newStudent.Teachers.Add(new() { Name = "Teacher 1" });
//newStudent.Teachers.Add(new() { Name = "Teacher 2" });
//newStudent.Teachers.Add(new() { Name = "Teacher 3" });

//var newTeacher = new Teacher() { Name = "Teacher 4" };

//newTeacher.Students.Add(new() { Name = "Student 2" });
//newTeacher.Students.Add(new() { Name = "Student 3" });
//newTeacher.Students.Add(new() { Name = "Student 4" });

//context.Add(newStudent);
//context.Add(newTeacher);
//context.SaveChanges();

var product = context.Products.Include(x => x.Category).Include(x => x.ProductFeature).First(x => x.Id == 3);

Console.WriteLine(product.Category.Name);