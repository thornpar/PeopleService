using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Primitives;
using Microsoft.IdentityModel.Protocols;

namespace netcore.Models
{
    public class PeopleContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {
        }

        public PeopleContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }

    class PeopleContextDbFactory : IDesignTimeDbContextFactory<PeopleContext>
    {
        private IConfigurationRoot Configuration { get; set; }

        public PeopleContextDbFactory()
        {
        }
        public PeopleContext CreateDbContext(string[] args)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            var connectionString = Configuration.GetSection("DOCKER_INSTANCE").Value == "TRUE"
                ? Configuration.GetSection("ConnectionStrings:DefaultConnection").Value
                : Configuration.GetSection("ConnectionStrings:MigrationConnection").Value;

            return new PeopleContext(new DbContextOptionsBuilder<PeopleContext>()
                .UseSqlServer(connectionString)
                .Options);
        }
    }

}
