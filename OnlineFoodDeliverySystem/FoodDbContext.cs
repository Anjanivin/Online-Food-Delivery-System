using Microsoft.EntityFrameworkCore;

namespace OnlineFoodDeliverySystem
{
    public class FoodDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
