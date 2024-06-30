using Company.Storage.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Company.Storage.Entities
{
    public class CompanyDbContext : DbContext
    {
        private IConfiguration _configuration { get; }

        public DbSet<StorageEntities.Company> Companies { get; set; } = null!;
        public DbSet<CompanyAddress> CompanyAddresses { get; set; } = null!;
        public DbSet<JobPosition> JobPositions { get; set; } = null!;
        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryTranslation> CountryTranslations { get; set; }

        public CompanyDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=company;Trusted_Connection=True;",
                x => x.MigrationsHistoryTable("__EFMigrationsHistory", "Company"));

            options.LogTo(x => System.Diagnostics.Debug.WriteLine(x));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new JobPositionConfiguration());
        }
    }
}
