using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using ShoppingList.Models;

namespace ShoppingList.DAL
    //Shopping db context for image files to items
{
    public class ShoppingContext : DbContext
    {
        public ShoppingContext() : base("ShoppingContext")
        {
        }

        public DbSet<File> Files { get; set; }
        public DbSet<ShoppingListItem> ShoppingListItems { get; set; }
              

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}