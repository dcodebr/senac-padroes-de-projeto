using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Senac.ADS.PPFA.SenacEduca.Repositories
{
    public class SenacEducaContextFactory : IDesignTimeDbContextFactory<SenacEducaContext>
    {
        public SenacEducaContext CreateDbContext(string[]? args = null)
        {
            var builder = new DbContextOptionsBuilder<SenacEducaContext>();
            var connectionString = "server=localhost;user=root;password=Senac123;database=senaceducadb;";

            builder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            return new SenacEducaContext(builder.Options);
        }

    }
}
