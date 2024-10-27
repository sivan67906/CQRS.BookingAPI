using Domain.Entities.Administration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class BookingDbContext : DbContext
{
    public BookingDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Feature> Features { get; set; }
    public DbSet<Review> Reviews { get; set; }
}
