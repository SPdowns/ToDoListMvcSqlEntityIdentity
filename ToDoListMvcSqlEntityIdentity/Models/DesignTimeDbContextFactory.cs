using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ToDoListMvcSqlEntityIdentity.Models
{
  public class ToDoListMvcSqlEntityIdentityContextFactory : IDesignTimeDbContextFactory<ToDoListMvcSqlEntityIdentityContext>
  {

    ToDoListMvcSqlEntityIdentityContext IDesignTimeDbContextFactory<ToDoListMvcSqlEntityIdentityContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<ToDoListMvcSqlEntityIdentityContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new ToDoListMvcSqlEntityIdentityContext(builder.Options);
    }
  }
}