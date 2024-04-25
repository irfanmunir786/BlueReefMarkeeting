using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueReef.Models
{
    public class Database:DbContext
    {
        private const string ConnectionString = @"server=DESKTOP-B7IVV58\SQLEXPRESS01; database=blue;trusted_connection=true;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-7QK1TLV;Database=blue;Trusted_Connection=True;MultipleActiveResultSets=true");
           
            optionsBuilder.UseSqlServer(ConnectionString);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Registraion>()
                .HasOne<RoleManagement>(u => u.RoleManagement);
        }
        public DbSet<Registraion> Registraions  { get; set; }
        public DbSet<RoleManagement> RoleManagements  { get; set; }
        public DbSet<SendEmail> sendEmails { get; set; }

    }
}
