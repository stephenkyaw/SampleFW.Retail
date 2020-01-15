using Microsoft.AspNet.Identity.EntityFramework;
using SampleFW.Retail.Core.Entities;
using System.Data.Entity;

namespace SampleFW.Retail.Core.Identity
{
    public class ApplicaitonDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Currency> Currencies { get; set; }

        public DbSet<Category> Categories { get; set; }
        
        public DbSet<Product> Products { get; set; }

        public DbSet<SaleOrderHeader> SaleOrderHeaders { get; set; }

        public DbSet<SaleOrderDetail> SaleOrderDetails { get; set; }

    }
}
