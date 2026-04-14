using ArshinGroup.DAL.SqlServer.Configuration;
using ArshinGroup.Domain.Models.Abstractions.BaseEntities;
using ArshinGroup.Domain.Models.Entities.Products;
using ArshinGroup.Domain.Models.Entities.Services;
using ArshinGroup.Domain.Models.Entities.Settings;
using ArshinGroup.Domain.Models.Entities.Solutions;
using ArshinGroup.Domain.Models.Entities.Users;
using ArshinGroup.Domain.Models.Enums;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ArshinGroup.DAL.SqlServer.Context
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public AppDbContext() : base()
        {
            Database.EnsureCreated();
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductDeliveryMethod> ProductDeliveryMethods { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductScpec> ProductVariants { get; set; }
        public DbSet<ServiceCategory> ServiceCategories { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }
        public DbSet<ServiceFeature> ServiceFeatures { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<NavigationItem> NavigationItems { get; set; }
        public DbSet<NavigationMenu> NavigationMenus { get; set; }
        public DbSet<NewsItem> NewsItems { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<SolutionFeature> SolutionFeatures { get; set; }
        public DbSet<SolutionProduct> SolutionProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //optionsBuilder
            // .UseSqlServer("ваша-строка-подключения")
            // .UseSnakeCaseNamingConvention();  

            builder
                .ApplyConfigurationsFromAssembly(typeof(UserConfiguration).Assembly)
                ;
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            // Глобальное правило: все строки по умолчанию будут nvarchar(50) / varchar(50)
            configurationBuilder.Properties<string>().HaveMaxLength(DefaultConstraints.DefaultLength);
            configurationBuilder.Properties<decimal>().HavePrecision(DefaultConstraints.DefaultMaxPrecision, DefaultConstraints.DefaultMaxPrecisionDecimalPoint);
            configurationBuilder.Properties<double>().HavePrecision(DefaultConstraints.DefaultMaxPrecision, DefaultConstraints.DefaultMaxPrecisionDecimalPoint);
        }
    }
}
