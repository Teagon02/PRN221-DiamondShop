using Diamond.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond.DataAccess.Configuration
{
    public class CategoryConfiguaration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Nhẫn kim cương",
                    Description = "Description",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Bông tai kim cương",
                    Description = "Description",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Lắc/Vòng tay kim cương",
                    Description = "Description",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Category
                {
                    CategoryId = 4,
                    CategoryName = "Mặt dây chuyền kim cương",
                    Description = "Description",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Category
                {
                    CategoryId = 5,
                    CategoryName = "Bộ trang sức kim cương",
                    Description = "Description",
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                }
                );
        }
    }
}
