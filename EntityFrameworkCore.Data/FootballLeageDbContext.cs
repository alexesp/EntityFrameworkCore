using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFrameworkCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;

namespace EntityFrameworkCore.Data
{
    public class FootballLeageDbContext : DbContext
    {
        //public FootballLeageDbContext()
        //{
        //    var folder = Environment.SpecialFolder.LocalApplicationData;
        //    var path = Environment.GetFolderPath(folder);
        //    DbPath = Path.Combine(path, "FoorballLeageEfCore.db");
        //}
        public DbSet<Team> Teams { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public string DbPath { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Using SQL Server
            //optionsBuilder.UseSqlServer("Data Source=DEVOPS\\SQLEXPRESS;" +
            //    "Inital Catalog=FoorballLeage_EfCore;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            optionsBuilder.UseSqlServer("Server=DEVOPS\\SQLEXPRESS;Database=FoorballLeageEfCore; Encrypt=False;TrustServerCertificate=True;Trusted_Connection=True;")
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors();

            //optionsBuilder.UseSqlite($"Data Source={DbPath}")
            //    .LogTo(Console.WriteLine, LogLevel.Information)
            //    .EnableSensitiveDataLogging()
            //    .EnableDetailedErrors();

            //Usando Sqlite
            //optionsBuilder.UseSqlite($"Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog=FoorballLeage_EfCore; Encrypt=False;");
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    TeamId = 1,
                    Name = "Real Madrid F.C",
                    CreateDate = DateTime.Now,
                },
                new Team
                {
                    TeamId = 2,
                    Name = "Tivoli Gardens F.C",
                    CreateDate = DateTimeOffset.UtcNow.DateTime,
                },
                new Team
                {
                    TeamId = 3,
                    Name = "Waterhouse F.C",
                    CreateDate = DateTimeOffset.UtcNow.DateTime,
                },
                new Team
                {
                    TeamId = 4,
                    Name = "Humble Lions F.C",
                    CreateDate = DateTimeOffset.UtcNow.DateTime,
                }
                );
        }
    }
}
