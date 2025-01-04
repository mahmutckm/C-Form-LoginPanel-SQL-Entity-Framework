using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form_Homework
{
    internal class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-JFM5B8D\\SQLEXPRESS;Database=ProjectDB;uid=sa;pwd=1;TrustServerCertificate=true");
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Logs> Logs { get; set; }
    }
}
