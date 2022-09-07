using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Yazlab2Proje3.entity;
using System.Data.Common;

namespace Yazlab2Proje3.data.Concrete.MySQL
{
    public class LoginContext:DbContext
    {   
        public DbSet<Login> Logins { get; set; }
        public DbSet<Register> Registers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseMySQL("server=localhost;user=root;database=users;password=YourPassword;port=YourPort");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginRegister>()
            .HasKey(c => new {c.LoginId,c.RegisterId});  
        } 

    }
}
