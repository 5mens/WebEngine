﻿// <auto-generated />
using System;
using Engine.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Engine.Data.Migrations.AppDb
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210806160911_Warehouse")]
    partial class Warehouse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArticleTag", b =>
                {
                    b.Property<int>("MyPropertyId")
                        .HasColumnType("int");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.HasKey("MyPropertyId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("ArticleTag");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DistrictId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("ContentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCommentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ContentId");

                    b.HasIndex("ParentCommentId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("District");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descr");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserRecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserRecipeId");

                    b.ToTable("Ingredient");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.IngredientCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IngredientCategory");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descr");

                    b.Property<bool>("IsMain")
                        .HasColumnType("bit");

                    b.Property<string>("Menutype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descr");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsHome")
                        .HasColumnType("bit");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<string>("Menutype")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ordering")
                        .HasColumnType("int")
                        .HasColumnName("sort");

                    b.Property<int?>("ParentIdId")
                        .HasColumnType("int");

                    b.Property<bool>("Published")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("ParentIdId");

                    b.ToTable("MenuItem");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.MyWarehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descr");

                    b.Property<DateTime>("OrderDateBegin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDateEnd")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderState")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Сustomer")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Tableware", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descr");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MyWarehouseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserRecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MyWarehouseId");

                    b.HasIndex("UserRecipeId");

                    b.ToTable("Tableware");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FamilyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.UserGroup", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameRu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.UserRecipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descr");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("OrderId");

                    b.ToTable("Recipe");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.UserRecipeCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Descr");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ShowDetails")
                        .HasColumnType("bit");

                    b.Property<int?>("UserRecipeCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserRecipeCategoryId");

                    b.ToTable("RecipeCategory");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.UserIngredient", b =>
                {
                    b.HasBaseType("Engine.Models.BaseClasses.Ingredient");

                    b.Property<decimal>("Count")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("MyWarehouseId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasIndex("MyWarehouseId");

                    b.ToTable("UserIngredient");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.UserTableware", b =>
                {
                    b.HasBaseType("Engine.Models.BaseClasses.Tableware");

                    b.Property<decimal>("Count")
                        .HasColumnType("decimal(18,2)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.ToTable("UserTableware");
                });

            modelBuilder.Entity("ArticleTag", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.Article", null)
                        .WithMany()
                        .HasForeignKey("MyPropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Engine.Models.BaseClasses.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Article", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Engine.Models.BaseClasses.Category", null)
                        .WithMany("Articles")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.City", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.District", "District")
                        .WithMany("Cities")
                        .HasForeignKey("DistrictId");

                    b.Navigation("District");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Comment", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Engine.Models.BaseClasses.Article", "Content")
                        .WithMany()
                        .HasForeignKey("ContentId");

                    b.HasOne("Engine.Models.BaseClasses.Comment", "ParentComment")
                        .WithMany()
                        .HasForeignKey("ParentCommentId");

                    b.Navigation("Author");

                    b.Navigation("Content");

                    b.Navigation("ParentComment");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Ingredient", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.IngredientCategory", "Category")
                        .WithMany("Ingredients")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Engine.Models.BaseClasses.UserRecipe", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("UserRecipeId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.MenuItem", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.Menu", "Menu")
                        .WithMany("MenuItems")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Engine.Models.BaseClasses.MenuItem", "ParentId")
                        .WithMany()
                        .HasForeignKey("ParentIdId");

                    b.Navigation("Menu");

                    b.Navigation("ParentId");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.MyWarehouse", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Tableware", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.MyWarehouse", null)
                        .WithMany("Tablewares")
                        .HasForeignKey("MyWarehouseId");

                    b.HasOne("Engine.Models.BaseClasses.UserRecipe", null)
                        .WithMany("Tablewares")
                        .HasForeignKey("UserRecipeId");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.User", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.UserRecipe", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.User", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Engine.Models.BaseClasses.UserRecipeCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("Engine.Models.BaseClasses.Order", null)
                        .WithMany("Recipes")
                        .HasForeignKey("OrderId");

                    b.Navigation("Author");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.UserRecipeCategory", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.UserRecipeCategory", null)
                        .WithMany("Category")
                        .HasForeignKey("UserRecipeCategoryId");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.UserIngredient", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.Ingredient", null)
                        .WithOne()
                        .HasForeignKey("Engine.Models.BaseClasses.UserIngredient", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Engine.Models.BaseClasses.MyWarehouse", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("MyWarehouseId");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.UserTableware", b =>
                {
                    b.HasOne("Engine.Models.BaseClasses.Tableware", null)
                        .WithOne()
                        .HasForeignKey("Engine.Models.BaseClasses.UserTableware", "Id")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Category", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.District", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.IngredientCategory", b =>
                {
                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Menu", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.MyWarehouse", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Tablewares");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.Order", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.UserRecipe", b =>
                {
                    b.Navigation("Ingredients");

                    b.Navigation("Tablewares");
                });

            modelBuilder.Entity("Engine.Models.BaseClasses.UserRecipeCategory", b =>
                {
                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
