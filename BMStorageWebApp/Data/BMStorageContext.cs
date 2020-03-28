using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BMStorage.Models;

namespace BMStorage.Data
{
   public class BMStorageContext : DbContext
   {
      public BMStorageContext(DbContextOptions<BMStorageContext> options)
          : base(options)
      {
      }

      public DbSet<UserType> UserTypes { get; set; }
      public DbSet<User> Users { get; set; }
      public DbSet<UnitType> UnitTypes { get; set; }
      public DbSet<Unit> Units { get; set; }
      public DbSet<Contract> Contracts { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {

      }

      public DbSet<Contract> Contract { get; set; }
      public DbSet<Unit> Unit { get; set; }
      public DbSet<UserType> UnitType { get; set; }

      public DbSet<User> User { get; set; }
      public DbSet<UserType> UserType { get; set; }
      public DbSet<BMStorage.Models.UnitType> UnitType_1 { get; set; }



   }
}