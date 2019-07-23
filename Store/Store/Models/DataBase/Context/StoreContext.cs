using Microsoft.EntityFrameworkCore;
using Store.Models.DataBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models.DataBase.Context
{

    public class StoreContext : DbContext
    {
        #region DbSets
        //public DbSet<Address> Addresses { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        //public DbSet<City> Cities { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ContactUsMessage> ContactUsMessages{ get; set; }
        //public DbSet<Discount> Discounts { get; set; }
        public DbSet<Factor> Factors { get; set; }
        public DbSet<FAQ> FAQs { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        //public DbSet<Province> Provinces { get; set; }
        //public DbSet<Role> Roles { get; set; }
        public DbSet<Setting> Settings { get; set; }
        //public DbSet<ShopingCart> ShopingCarts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion
        public StoreContext(DbContextOptions<StoreContext> options) /*: base(options)*/
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=storedb;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AddressConfig());
            modelBuilder.ApplyConfiguration(new BrandConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            //modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new CommentConfig());
            modelBuilder.ApplyConfiguration(new ContactUsMessageConfig());
            //modelBuilder.ApplyConfiguration(new DiscountConfig());
            modelBuilder.ApplyConfiguration(new FactorConfig());
            modelBuilder.ApplyConfiguration(new FAQConfig());
            modelBuilder.ApplyConfiguration(new MainCategoryConfig());
            modelBuilder.ApplyConfiguration(new MenuConfig());
            modelBuilder.ApplyConfiguration(new NewsLetterConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            //modelBuilder.ApplyConfiguration(new ProvinceConfig());
            modelBuilder.ApplyConfiguration(new SettingConfig());
            modelBuilder.ApplyConfiguration(new SliderConfig());
            //modelBuilder.ApplyConfiguration(new ShopingCartConfig());
            modelBuilder.ApplyConfiguration(new SubCategoryConfig());
            modelBuilder.ApplyConfiguration(new SubMenuConfig());
            modelBuilder.ApplyConfiguration(new TicketConfig());
            modelBuilder.ApplyConfiguration(new UserConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
