using System;
using System.Linq;
using Microsoft.Data.Entity;
using TestE7;

namespace TestProgram
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProductContext>();
            optionsBuilder.UseInMemoryDatabase();

            using (var context = new ProductContext(optionsBuilder.Options))
            {
                context.Products.Add(new Product
                {
                    Name = "Test"
                });
                context.SaveChanges();

                var product = context.Products.Single(x => x.Id == 1);

                Console.WriteLine($"{product.Name}");

                product.Name = "Change";
                context.SaveChanges();

                var changeProduct = context.Products.Single(x => x.Id == 1);

                Console.WriteLine($"{changeProduct.Name}");

                Console.ReadLine();

            }
        }
    }
}
