using Contoso.SurfaceTemperatureGuard.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Contoso.SurfaceTemperatureGuard.API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        DbSet<Device> Devices { get; set; }
        DbSet<Region> Regions { get; set; }
        DbSet<Config> Configs { get; set; }       
        DbSet<DeviceTemperatureLog> DeviceTemperatureLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
