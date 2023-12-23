using Microsoft.EntityFrameworkCore;
using PetProject.Models.Entities;

namespace PetProject.Models
{
    public class MyDbContext : DbContext
    {
        //public IConfiguration _config { get; set; }
        public MyDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        //}
        public DbSet<LoginInfo> LoginInfos { get; set; }
    }
}
