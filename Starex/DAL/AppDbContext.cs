using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Starex.Models;

namespace Starex.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Advantage> Advantages { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Depo> Depos { get; set; }
        public DbSet<HowWorkCard> HowWorkCards { get; set; }
        public DbSet<HowWorkTitle> HowWorkTitles { get; set; }
        public DbSet<Newness> Newnesses { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Store> Stores { get; set; }





    }
}
