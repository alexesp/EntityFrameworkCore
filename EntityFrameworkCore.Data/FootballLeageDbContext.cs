using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkCore.Data
{
    public class FootballLeageDbContext : DbContext
    {
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Using SQL Server
            optionsBuilder.UseSqlServer("Data Source=DEVOPS\\SQLEXPRESS;" +
                "Inital Catalog=FoorballLeage_EfCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False").LogTo(Console.WriteLine, LogLevel.Information);
            
            //Usando Sqlite
            //optionsBuilder.UseSqlite($"Data Source =(localdb)\\MSSQLLocalDB;Inital Catalog=FoorballLeage_EfCore; Encrypt=False;");

        }
    }
}
