using Microsoft.EntityFrameworkCore;
using Gouda.Models;

namespace Gouda.Database
{
    public class GoudaDbContext(DbContextOptions<GoudaDbContext> options) : DbContext(options)
    {
        public DbSet <UserModel> Users { get; set; }

        public DbSet <EventModel> Events { get; set; }
    }
}
