using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Repository
{
    public class SeedData
    {
        public static void SeedingData(DataContext _context) 

        {
            _context.Database.Migrate();
            if (!_context.Products.Any())
            {
                CategoryModel gucci = new CategoryModel { Name = "Gucci", slug = "gucci", Description = "Gucci in the top", status = 1 };
                CategoryModel LouisVuitton = new CategoryModel { Name = "Louis Vuitton", slug = "Louis Vuitton", Description = "Louis Vuitton in the top", status = 1 };
                
                BrandModel guuci1 = new BrandModel { name = "Gucci1", slug = "Gucci1", Description = "Gucci in the top", status = 1 };
                BrandModel LouisVuitton1 = new BrandModel { name = "louisVuitton1 ", slug = "Louis Vuitton", Description = "Louis Vuitton in the top", status = 1 };
                _context.Products.AddRange(

                    new ProductModel { Name = "gucci ", Slug = "Gucci ", Decription = "Gucci is Best", Image = "1.jpg", Category = gucci, Brand = guuci1, Price = 1233 },
                    new ProductModel { Name = "LouisVuitton ", Slug = "Dior ", Decription = "Dior is Best", Image = "1.jpg", Category = LouisVuitton, Brand = LouisVuitton1, Price = 1233 }

                );
                _context.SaveChanges();
            }
        }
    }
}
