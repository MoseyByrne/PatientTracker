using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace PatientTracker.Models
{
    public class
    PatientTrackerContextFactory
    : IDesignTimeDbContextFactory<PatientTrackerContext>
    {
        PatientTrackerContext
        IDesignTimeDbContextFactory<PatientTrackerContext>.CreateDbContext(
            string[] args
        )
        {
            IConfigurationRoot configuration =
                new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                    .Build();

            var builder = new DbContextOptionsBuilder<PatientTrackerContext>();

            builder
                .UseMySql(configuration["ConnectionStrings:DefaultConnection"],
                ServerVersion
                    .AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

            return new PatientTrackerContext(builder.Options);
        }
    }
}
