using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Diamond.DataAccess.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var adminRoleId = "589465c3-7396-46a4-8bf0-40203342faae";
            var mannagerRoleId = "aa2cf69c-a91a-4967-ba8c-18b8f6d54f60";
            var customerRoleId = "a446eafe-5096-4d8c-889c-b4c92f5d6e63";

            // Seed Roles (User, Admin, Super Admin)
            var roles = new List<IdentityRole>
            {
                new IdentityRole()
                {
                    Name = "Admin",
                    NormalizedName = "Admin",
                    Id = adminRoleId,
                    ConcurrencyStamp = adminRoleId
                },
                new IdentityRole()
                {
                    Name = "Mangager",
                    NormalizedName = "Mangager",
                    Id = mannagerRoleId,
                    ConcurrencyStamp = mannagerRoleId
                },
                new IdentityRole()
                {
                    Name = "Customer",
                    NormalizedName = "Customer",
                    Id = customerRoleId,
                    ConcurrencyStamp = customerRoleId
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);

            // Seed Super Admin User
            var adminId = "c052ffb4-245b-4c3c-8390-f1bd806828e2";
            var superAdminUser = new IdentityUser()
            {
                Id = adminId,
                UserName = "admin@gmail.com",
                Email = "admin@gmail.com",
                NormalizedEmail = "admin@gmail.com".ToUpper(),
                NormalizedUserName = "admin@gmail.com".ToUpper(),
                EmailConfirmed = true
            };

            superAdminUser.PasswordHash = new PasswordHasher<IdentityUser>()
                                    .HashPassword(superAdminUser, "admin123");

            builder.Entity<IdentityUser>().HasData(superAdminUser);

            // Add All Roles To Super Admin User
            var superAdminRoles = new List<IdentityUserRole<string>>()
            {
                new IdentityUserRole<string>
                {
                    RoleId = adminRoleId,
                    UserId = adminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = mannagerRoleId,
                    UserId = adminId
                },
                new IdentityUserRole<string>
                {
                    RoleId = customerRoleId,
                    UserId = adminId
                },
            };

            builder.Entity<IdentityUserRole<string>>().HasData(superAdminRoles);
        }
    }
}
