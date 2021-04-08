using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Qa.EntityFrameworkCore
{
    public class QaHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<QaHttpApiHostMigrationsDbContext>
    {
        public QaHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<QaHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Qa"));

            return new QaHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
