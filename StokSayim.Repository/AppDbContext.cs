using Microsoft.EntityFrameworkCore;
using StokSayim.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokSayim.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Authority> Authoritys { get; set; }
        public DbSet<Count> Counts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Terminal> Terminals { get; set; }
        public DbSet<TerminalSetting> TerminalSettings { get; set; }
        public DbSet<GetCounts> GetCounts { get; set; }
        public DbSet<ViewCounts> ViewCounts { get; set; }
        public DbSet<ViewStocks> ViewStocks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<GetCounts>()
            .ToView(nameof(GetCounts))
            .HasKey(t => t.StokKodu);;



            modelBuilder
       .Entity<ViewCounts>()
       .ToView(nameof(ViewCounts))
       .HasKey(t => t.StokKodu); ;



            modelBuilder
       .Entity<ViewStocks>()
       .ToView(nameof(ViewStocks))
       .HasKey(t => t.StokKodu); ;

        }

    }
}
