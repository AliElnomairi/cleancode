using cleancode.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace cleancode.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Parking> Parkings { get; set; }

        private string connectionString;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            connectionString = "Data Source=" + Path.Join(path, "ParkingDB_Master.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(connectionString);
    }
}
