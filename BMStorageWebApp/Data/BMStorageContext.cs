using Microsoft.EntityFrameworkCore;
using BMStorage.Models;

namespace BMStorage.Data
{
   public class BMStorageContext : DbContext
   {
      public BMStorageContext(DbContextOptions<BMStorageContext> options)
          : base(options)
      {
      }

      public override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Contract>().HasRequired(m => m.TenantID)
                                 .WithMany(m => m.Contract).HasForeignKey(m => m.TenantID);
         modelBuilder.Entity<Contract>().HasRequired(m => m.EmployeeID)
                                 .WithMany().HasForeignKey(m => m.EmployeeID);
      }

      public DbSet<Contract> Contract { get; set; }
      public DbSet<Unit> Unit { get; set; }
      public DbSet<UserType> UnitType { get; set; }

      public DbSet<User> User { get; set; }
      public DbSet<UserType> UserType { get; set; }
      public DbSet<BMStorage.Models.UnitType> UnitType_1 { get; set; }



   }
}