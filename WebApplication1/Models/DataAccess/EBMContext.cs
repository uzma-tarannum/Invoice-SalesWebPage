using Microsoft.EntityFrameworkCore;
using WebApplication1.Models.Entitties;

namespace WebApplication1.Models.DataAccess
{
    public class EBMContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=192.168.2.11\\SQL2017;Initial Catalog=Uzma_Db;Integrated Security=True;Persist Security Info=True;Trust Server Certificate=True");
        }
        public DbSet<User> User { get; set; }
        public DbSet<Product> product { get; set; }
        public DbSet<ProductCategory> productCategory { get; set; }
        public DbSet<ProductBrand> productBrand { get; set; }



    }
}
