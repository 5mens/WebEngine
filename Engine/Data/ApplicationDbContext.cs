using Engine.Models.BaseClasses;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<UserGroup> AspNetRoles { get; set; }
        public DbSet<User> AspNetUsers { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<District> District { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<Country> Country { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Article> Article { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<UserGroup> AspNetRoles { get; set; }
        public DbSet<User> AspNetUsers { get; set; }
        public DbSet<Ingredient> Ingredient { get; set; }
        public DbSet<IngredientCategory> IngredientCategory { get; set; }
        public DbSet<Tableware> Tableware { get; set; }
        public DbSet<UserRecipe> Recipe { get; set; }
        public DbSet<UserRecipeCategory> RecipeCategory { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<MyWarehouse> Warehouse { get; set; }
        public DbSet<UserIngredient> UserIngredient { get; set; }
        public DbSet<UserTableware> UserTableware { get; set; }




        /// <summary>
        /// Dispose pattern.
        /// </summary>
        public override void Dispose()
        {
            Debug.WriteLine($"{ContextId} context disposed.");
            base.Dispose();
        }

        /// <summary>
        /// Dispose pattern.
        /// </summary>
        /// <returns>A <see cref="ValueTask"/></returns>
        public override ValueTask DisposeAsync()
        {
            Debug.WriteLine($"{ContextId} context disposed async.");
            return base.DisposeAsync();
        }
    }
}
