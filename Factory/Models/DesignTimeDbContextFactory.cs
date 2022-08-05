// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Design;
// using Microsoft.Extensions.Configuration;
// using System.IO;

// namespace Factory.Models
// {
//   public class FactoryContextFactory : IDesignTimeDbContextFactory<ToDoListContext>
//   {

//     ToDoListContext IDesignTimeDbContextFactory<FactoryContext>.CreateDbContext(string[] args)
//     {
//       IConfigurationRoot configuration = new ConfigurationBuilder()
//           .SetBasePath(Directory.GetCurrentDirectory())
//           .AddJsonFile("appsettings.json")
//           .Build();

//       var builder = new DbContextOptionsBuilder<ToDoListContext>();

//       builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

//       return new ToDoListContext(builder.Options);
//     }
//   }
// }