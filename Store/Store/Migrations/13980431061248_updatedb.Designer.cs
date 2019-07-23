﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Store.Models.DataBase.Context;

namespace Store.Migrations
{
    [DbContext(typeof(StoreContext))]
    [Migration("13980431061248_updatedb")]
    partial class updatedb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .IsUnicode(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .IsUnicode(true);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsFavorate");

                    b.Property<int>("MainCategoryId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OrderNumber");

                    b.HasKey("CategoryId");

                    b.HasIndex("MainCategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("CommentedDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsSeen");

                    b.Property<bool>("IsShow");

                    b.Property<bool>("IsVerified");

                    b.Property<int>("ProductId");

                    b.HasKey("CommentId");

                    b.HasIndex("ProductId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.ContactUsMessage", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsSeen");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("SendedDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MessageId");

                    b.ToTable("ContactUsMessages");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.FAQ", b =>
                {
                    b.Property<int>("FAQId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Answer")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<int>("OrderNumber");

                    b.Property<string>("Question")
                        .IsRequired();

                    b.HasKey("FAQId");

                    b.ToTable("FAQs");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Factor", b =>
                {
                    b.Property<int>("FactorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Authority")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("FactorDate")
                        .HasColumnType("datetime");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("OrderId");

                    b.Property<string>("RefID")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(100)");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .IsUnicode(true);

                    b.Property<int>("OrderNumber");

                    b.HasKey("MainCategoryId");

                    b.ToTable("MainCategories");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("MenuId");

                    b.ToTable("Menus");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.NewsLetter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .IsUnicode(true);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("NewsLetters");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressDetailes_Json");

                    b.Property<string>("DiscountName")
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("DiscountPrice")
                        .HasColumnType("decimal(16,3)");

                    b.Property<bool>("FinanceIsOk");

                    b.Property<bool>("IsCanceled");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsFinished");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime");

                    b.Property<decimal>("OrderPrice")
                        .HasColumnType("decimal(16,3)");

                    b.Property<decimal>("OrderPriceNoDiscount")
                        .HasColumnType("decimal(16,3)");

                    b.Property<int>("OrderStatus");

                    b.Property<string>("PaymentCode");

                    b.Property<string>("ShopingCartDetails_Json");

                    b.Property<string>("TrackingCode")
                        .HasColumnType("nvarchar(50)")
                        .IsUnicode(true);

                    b.Property<int>("UserId");

                    b.HasKey("OrderId");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .IsUnicode(true);

                    b.Property<int>("ExistCount");

                    b.Property<string>("Features");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Rating");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("decimal(16,3)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("SoldCount");

                    b.Property<int>("SubCategoryId");

                    b.Property<string>("Tags")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("UnitType")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("VisitedCount");

                    b.Property<decimal>("WrittenPrice")
                        .HasColumnType("decimal(16,3)");

                    b.HasKey("ProductId");

                    b.HasIndex("BrandId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Setting", b =>
                {
                    b.Property<int>("SettingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutUsPage");

                    b.Property<string>("BanerImageName");

                    b.Property<string>("BanerImageNameMob");

                    b.Property<string>("ContactUsMapUrl");

                    b.Property<string>("ContactUsPage");

                    b.Property<string>("ContactUs_Json");

                    b.Property<string>("FAQPage");

                    b.Property<string>("Information_Json");

                    b.Property<string>("SotialNetwork_Json");

                    b.Property<string>("Terms_ConditionsPage");

                    b.Property<string>("UserAccountLink_json");

                    b.HasKey("SettingId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Slider", b =>
                {
                    b.Property<int>("SliderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ImageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ImageNameMob")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsShowInMainPage");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("UrlLink")
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("UrlText")
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("SliderId");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .IsUnicode(true);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("OrderNumber");

                    b.HasKey("SubCategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("SubCategories");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.SubMenu", b =>
                {
                    b.Property<int>("SubMenuId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive");

                    b.Property<int>("MenuId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("SubMenuId");

                    b.HasIndex("MenuId");

                    b.ToTable("SubMenus");
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IsDeleted");

                    b.Property<bool>("IsSeen");

                    b.Property<int>("MessageLevel");

                    b.Property<int>("ReciverUserId");

                    b.Property<int>("ReplyedId");

                    b.Property<DateTime>("SendedDate")
                        .HasColumnType("smalldatetime");

                    b.Property<int>("SenderUserId");

                    b.Property<DateTime>("TicketDate");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserId");

                    b.HasKey("TicketId");

                    b.HasIndex("UserId");

                    b.ToTable("Ticket");
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

                    b.Property<string>("Address_Json")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Biography")
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("BlockedDate")
                        .HasColumnType("smalldatetime");

                    b.Property<DateTime>("DeletedDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("FavorateProduct_Json");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Gender");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsBlock");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsVerified");

                    b.Property<string>("MobileNo")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("RegisterDate")
                        .HasColumnType("smalldatetime");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Salt")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ShopingCart_Json");

                    b.Property<string>("Token");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            ActivationCode = "a5a17372ba0c4291a207edcfce471aef",
                            ActivationCodeExpireDate = new DateTime(2019, 7, 22, 10, 42, 47, 845, DateTimeKind.Local).AddTicks(9020),
                            Address_Json = "",
                            Biography = "",
                            BlockedDate = new DateTime(2019, 7, 22, 10, 42, 47, 849, DateTimeKind.Local).AddTicks(4430),
                            DeletedDate = new DateTime(2019, 7, 22, 10, 42, 47, 849, DateTimeKind.Local).AddTicks(5835),
                            FavorateProduct_Json = "",
                            FullName = "مدیر سایت",
                            Gender = true,
                            IsActive = true,
                            IsBlock = false,
                            IsDeleted = false,
                            IsVerified = true,
                            MobileNo = "",
                            Password = "ah96NkysmupODN1qDNR4sg==",
                            RegisterDate = new DateTime(2019, 7, 22, 10, 42, 47, 849, DateTimeKind.Local).AddTicks(9166),
                            Role = "Admin",
                            Salt = "e3b21e9fe75f4409ab26b80e8255e3c1",
                            ShopingCart_Json = "",
                            Token = "4a270d56f2a74b499eb3444c8f171df8",
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Category", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.MainCategory", "MainCategory")
                        .WithMany()
                        .HasForeignKey("MainCategoryId")
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

            modelBuilder.Entity("Store.Models.DataBase.Entities.Order", b =>
                {
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

            modelBuilder.Entity("Store.Models.DataBase.Entities.SubMenu", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Store.Models.DataBase.Entities.Ticket", b =>
                {
                    b.HasOne("Store.Models.DataBase.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
