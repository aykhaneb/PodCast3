using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PodCast.DAL.Entities;

namespace PodCast.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Footer> Footer { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }
    }
}
