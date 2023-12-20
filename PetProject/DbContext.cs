using Microsoft.EntityFrameworkCore;
using PetProject.Models.Entities;

namespace PetProject
{
    public class MyDbContext : DbContext
    {
        public IConfiguration _config {  get; set; }
        public MyDbContext(IConfiguration config)
        {
            _config = config;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }
        public DbSet<LoginInfo> LoginInfos { get; set; }
    }
}
