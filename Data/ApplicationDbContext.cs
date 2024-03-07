using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using website_airQuality.Models;

//// ReSharper disable UnusedMember.Global
#pragma warning disable 108,114

namespace aspcore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {


        //public virtual DbSet<Airspeed> Airspeed { get; set; } = null!;
        public virtual DbSet<AirData> AirData { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }




    }
}