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
    public class ProductConfiguaration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "BÔNG TAI KIM CƯƠNG 18K ERA00100",
                    CategoryId = 2,
                    Description = "Đây là mô tả",
                    Price = 33000000,
                    Status = true,
                    MainStoneSize = "Round 5ly",
                    SideStoneType = "Kim cương",
                    SideStoneQuantity = 124,
                    SideStoneWeight = 0.75,
                    GoldType = "Vàng trắng",
                    GoldKarat = "18K",
                    GoldWeight = 1.18,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Product
                {
                    ProductId = 2,
                    Name = "NHẪN KIM CƯƠNG NỮ 18K 01141N",
                    CategoryId = 1,
                    Description = "Đây là mô tả",
                    Price = 44000000,
                    Status = true,
                    MainStoneSize = "Round 5ly",
                    SideStoneType = "Kim cương",
                    SideStoneQuantity = 19,
                    SideStoneWeight = 0.2,
                    GoldType = "Vàng trắng",
                    GoldKarat = "18K",
                    GoldWeight = 0.85,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                },
                new Product
                {
                    ProductId = 3,
                    Name = "MẶT DÂY CHUYỀN KIM CƯƠNG 18K",
                    CategoryId = 4,
                    Description = "Đây là mô tả",
                    Price = 55000000,
                    Status = true,
                    MainStoneSize = "Round 5ly",
                    SideStoneType = "Kim cương",
                    SideStoneQuantity = 24,
                    SideStoneWeight = 1.05,
                    GoldType = "Vàng trắng",
                    GoldKarat = "18K",
                    GoldWeight = 0.53,
                    DateCreated = DateTime.Now,
                    DateModified = DateTime.Now
                }
                );
        }
    }
}
