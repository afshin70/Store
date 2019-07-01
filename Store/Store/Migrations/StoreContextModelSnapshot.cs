﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.Models.DataBase.Context;

namespace Store.Migrations
{
    [DbContext(typeof(StoreContext))]
    partial class StoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Store.Models.DataBase.Entities.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TumbImageUrl")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(250)");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsEnabled");

                    b.Property<bool>("IsFavorate");

                    b.Property<int>("MainCategoryId");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrderNumber");

                    b.HasKey("CategoryId");

                    b.HasIndex("MainCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProvinceId");

                    b.HasKey("CityId");

                    b.HasIndex("ProvinceId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("CommentedDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ProductId");

                    b.HasKey("CommentId");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("smalldatetime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("MaxPercent");

                    b.Property<decimal>("MaxPrice")
                        .HasColumnType("decimal(16,3)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("smalldatetime");

                    b.HasKey("DiscountId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Factor", b =>
                {
                    b.Property<int>("FactorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FactorDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("SumPrice")
                        .HasColumnType("decimal(16,3)");

                    b.HasKey("FactorId");

                    b.HasIndex("OrderId");

                    b.ToTable("Factors");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.MainCategory", b =>
                {
                    b.Property<int>("MainCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MainCategoryId");

                    b.ToTable("MainCategories");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IsDeleted");

                    b.Property<bool>("IsSeen");

                    b.Property<int>("MessageLevel");

                    b.Property<int>("ReciverUserId");

                    b.Property<int>("ReplyedId");

                    b.Property<string>("SendedDate")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 48)))
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SenderUserId");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("UserId");

                    b.HasKey("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.NewsLetter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsVerified");

                    b.Property<DateTime>("VerifiedDate");

                    b.Property<string>("VerifyCode");

                    b.Property<DateTime>("VerifyCodeDate");

                    b.HasKey("Id");

                    b.ToTable("NewsLetters");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressDetailes_Json");

                    b.Property<bool>("BuyIsOk");

                    b.Property<int>("BuyStatus");

                    b.Property<DateTime>("BuyTime")
                        .HasColumnType("datetime");

                    b.Property<int>("DiscountId");

                    b.Property<bool>("FinanceIsOk");

                    b.Property<bool>("IsCanceled");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsFinished");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("PayCost")
                        .HasColumnType("decimal(16,3)");

                    b.Property<string>("ShopingCartDetails_Json");

                    b.Property<decimal>("SumPrice")
                        .HasColumnType("decimal(16,3)");

                    b.Property<decimal>("SumPriceNoDiscount")
                        .HasColumnType("decimal(16,3)");

                    b.Property<string>("Telphone")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TrackingCode")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("UserId");

                    b.HasKey("OrderId");

                    b.HasIndex("DiscountId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandId");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("ExistCount");

                    b.Property<string>("Features_Json");

                    b.Property<string>("Images_Json");

                    b.Property<DateTime>("InsertedDate")
                        .HasColumnType("smalldatetime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsSpecial");

                    b.Property<string>("MainDescription");

                    b.Property<decimal>("MaxDiscountPrice")
                        .HasColumnType("decimal(16,3)");

                    b.Property<int>("MinCountNotify");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Rating");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(16,3)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("SoldCount");

                    b.Property<int>("SubCategoryId");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("UnitType")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("VisitedCount");

                    b.Property<decimal>("WrittenPrice")
                        .HasColumnType("decimal(16,3)");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Province", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProvinceId");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUsPage");

                    b.Property<string>("ContactUsMapUrl");

                    b.Property<string>("ContactUsPage");

                    b.Property<string>("ContactUs_Json");

                    b.Property<string>("FAQPage");

                    b.Property<string>("Information_Json");

                    b.Property<string>("SotialNetwork_Json");

                    b.Property<string>("Terms_ConditionsPage");

                    b.Property<string>("UserAccountLink_json");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Title");

                    b.Property<string>("UrlLink");

                    b.Property<string>("UrlText");

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("EName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("OrderNumber");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivationCode")
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ActivationCodeExpireDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("BlockedDate")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("CityId");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FavorateProduct_Json");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("Gender");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsBlock");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsVerified");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Token");

                    b.Property<string>("UserIpRegistered")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.HasIndex("CityId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Category", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.MainCategory", "MainCategory")
                        .WithMany()
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.City", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Comment", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Factor", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Message", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Order", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.Discount", "Discount")
                        .WithMany()
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Store.Models.DataBase.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Product", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.Brand", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Store.Models.DataBase.Entities.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.SubCategory", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.User", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
