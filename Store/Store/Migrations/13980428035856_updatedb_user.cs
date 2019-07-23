﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Store.Migrations
{
    public partial class updatedb_user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "ContactUsMessages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    IsSeen = table.Column<bool>(nullable: false),
                    SendedDate = table.Column<DateTime>(type: "smalldatetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactUsMessages", x => x.MessageId);
                });

            migrationBuilder.CreateTable(
                name: "FAQs",
                columns: table => new
                {
                    FAQId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Question = table.Column<string>(nullable: false),
                    Answer = table.Column<string>(nullable: false),
                    OrderNumber = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQs", x => x.FAQId);
                });

            migrationBuilder.CreateTable(
                name: "MainCategories",
                columns: table => new
                {
                    MainCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategories", x => x.MainCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "NewsLetters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsLetters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ContactUs_Json = table.Column<string>(nullable: true),
                    Information_Json = table.Column<string>(nullable: true),
                    UserAccountLink_json = table.Column<string>(nullable: true),
                    SotialNetwork_Json = table.Column<string>(nullable: true),
                    AboutUsPage = table.Column<string>(nullable: true),
                    ContactUsPage = table.Column<string>(nullable: true),
                    ContactUsMapUrl = table.Column<string>(nullable: true),
                    Terms_ConditionsPage = table.Column<string>(nullable: true),
                    FAQPage = table.Column<string>(nullable: true),
                    BanerImageName = table.Column<string>(nullable: true),
                    BanerImageNameMob = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingId);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    SliderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageName = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    ImageNameMob = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    UrlText = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    UrlLink = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    IsShowInMainPage = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.SliderId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    MobileNo = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Address_Json = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Biography = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Gender = table.Column<bool>(nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Token = table.Column<string>(nullable: true),
                    Salt = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    ActivationCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ActivationCodeExpireDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    BlockedDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    IsBlock = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    FavorateProduct_Json = table.Column<string>(nullable: true),
                    ShopingCart_Json = table.Column<string>(nullable: true),
                    Role = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    OrderNumber = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsFavorate = table.Column<bool>(nullable: false),
                    MainCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_MainCategories_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategories",
                        principalColumn: "MainCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubMenus",
                columns: table => new
                {
                    SubMenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Url = table.Column<string>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    MenuId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubMenus", x => x.SubMenuId);
                    table.ForeignKey(
                        name: "FK_SubMenus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FinanceIsOk = table.Column<bool>(nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    OrderStatus = table.Column<int>(nullable: false),
                    OrderPrice = table.Column<decimal>(type: "decimal(16,3)", nullable: false),
                    OrderPriceNoDiscount = table.Column<decimal>(type: "decimal(16,3)", nullable: false),
                    TrackingCode = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ShopingCartDetails_Json = table.Column<string>(nullable: true),
                    AddressDetailes_Json = table.Column<string>(nullable: true),
                    IsCanceled = table.Column<bool>(nullable: false),
                    IsFinished = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    PaymentCode = table.Column<string>(nullable: true),
                    DiscountName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DiscountPrice = table.Column<decimal>(type: "decimal(16,3)", nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    TicketId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    IsSeen = table.Column<bool>(nullable: false),
                    SendedDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    MessageLevel = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<int>(nullable: false),
                    TicketDate = table.Column<DateTime>(nullable: false),
                    SenderUserId = table.Column<int>(nullable: false),
                    ReciverUserId = table.Column<int>(nullable: false),
                    ReplyedId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Ticket_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    SubCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    EName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    OrderNumber = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.SubCategoryId);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factors",
                columns: table => new
                {
                    FactorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SumPrice = table.Column<decimal>(type: "decimal(16,3)", nullable: false),
                    FactorDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Authority = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    RefID = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    OrderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factors", x => x.FactorId);
                    table.ForeignKey(
                        name: "FK_Factors_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(1000)", nullable: true),
                    MainDescription = table.Column<string>(nullable: true),
                    Images_Json = table.Column<string>(nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    BrandId = table.Column<int>(nullable: false),
                    SoldCount = table.Column<int>(nullable: false),
                    VisitedCount = table.Column<int>(nullable: false),
                    ExistCount = table.Column<int>(nullable: false),
                    MaxDiscountPrice = table.Column<decimal>(type: "decimal(16,3)", nullable: false),
                    Features = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    UnitType = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SalesPrice = table.Column<decimal>(type: "decimal(16,3)", nullable: false),
                    WrittenPrice = table.Column<decimal>(type: "decimal(16,3)", nullable: false),
                    IsSpecial = table.Column<bool>(nullable: false),
                    MinCountNotify = table.Column<int>(nullable: false),
                    InsertedDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Rating = table.Column<int>(nullable: false),
                    SubCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "SubCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommentText = table.Column<string>(type: "nvarchar(1000)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CommentedDate = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    IsSeen = table.Column<bool>(nullable: false),
                    IsVerified = table.Column<bool>(nullable: false),
                    IsShow = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "ActivationCode", "ActivationCodeExpireDate", "Address_Json", "Biography", "BlockedDate", "DeletedDate", "FavorateProduct_Json", "FullName", "Gender", "IsActive", "IsBlock", "IsDeleted", "IsVerified", "MobileNo", "Password", "RegisterDate", "Role", "Salt", "ShopingCart_Json", "Token", "UserName" },
                values: new object[] { 1, "f69848b78933438db1a2f3fe0354c6cf", new DateTime(2019, 7, 19, 8, 28, 56, 79, DateTimeKind.Local).AddTicks(5350), "", "", new DateTime(2019, 7, 19, 8, 28, 56, 96, DateTimeKind.Local).AddTicks(1557), new DateTime(2019, 7, 19, 8, 28, 56, 96, DateTimeKind.Local).AddTicks(2147), "", "مدیر سایت", true, true, false, false, true, "", "tYrR5KCiuiHwp5qG4ZLinQ==", new DateTime(2019, 7, 19, 8, 28, 56, 96, DateTimeKind.Local).AddTicks(3642), "Admin", "653079a1f0384eadb89279b7bebb4fba", "", "993ce7cd1ce2411b9c5e340451989f85", "Admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_MainCategoryId",
                table: "Categories",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ProductId",
                table: "Comments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Factors_OrderId",
                table: "Factors",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SubCategoryId",
                table: "Products",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubMenus_MenuId",
                table: "SubMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserId",
                table: "Ticket",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ContactUsMessages");

            migrationBuilder.DropTable(
                name: "Factors");

            migrationBuilder.DropTable(
                name: "FAQs");

            migrationBuilder.DropTable(
                name: "NewsLetters");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "SubMenus");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "MainCategories");
        }
    }
}