using account_crud_verification_api.Entities;
using Microsoft.EntityFrameworkCore;

namespace account_crud_verification_api.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        private readonly IConfiguration Configuration;
        
        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqllite database
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
        }
    }
}
