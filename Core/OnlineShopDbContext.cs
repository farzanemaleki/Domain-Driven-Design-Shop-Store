using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Core
{
    public class OnlineShopDbContext : DbContext
    {
        public OnlineShopDbContext(DbContextOptions options):base(options)
        {
            
        }
        DbSet<Product> Products => Set<Product>();
        
    }
}
