using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Criar as migrations
            var connectionString = "Server=localhost;Port=3306;Database=dbMovie;Uid=root;Pwd=root";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseLazyLoadingProxies().UseMySql(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
