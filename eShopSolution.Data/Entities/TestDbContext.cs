using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class TestDbContext
    {
        public String CreateDbContext()
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //  .SetBasePath(Directory.GetCurrentDirectory())
            //  .AddJsonFile("appsettings.json")
            //  .Build();

            var s1 = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory());
            var s2 = s1.AddJsonFile("appsettings.json").Build();


            var ConnectionString = s2.GetConnectionString("eShopSolutionDb");

            return ConnectionString;
        }
    }
}
