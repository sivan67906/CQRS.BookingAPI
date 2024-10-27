using Domain.Entities.Administration;
using Domain.Entities.Apartments;
using Domain.Entities.Catalogs;
using Domain.Entities.Hotels;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class BookingDbContext : DbContext
{
    public BookingDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Feature> Features { get; set; }
    public DbSet<Photo> Photos { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Service> Services { get; set; }

    public DbSet<Apartment> Apartments { get; set; }
    public DbSet<ApartmentFeature> ApartmentFeatures { get; set; }
    public DbSet<ApartmentGuest> ApartmentGuests { get; set; }

    public DbSet<ApartmentPhoto> ApartmentPhotos { get; set; }
    public DbSet<ApartmentPrice> ApartmentPrices { get; set; }
    public DbSet<ApartmentReview> ApartmentReviews { get; set; }
    public DbSet<ApartmentType> ApartmentTypes { get; set; }
    public DbSet<GuestType> GuestTypes { get; set; }
    public DbSet<RoomType> RoomTypes { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<HotelFeature> HotelFeatures { get; set; }
    public DbSet<HotelGuest> HotelGuests { get; set; }
    public DbSet<HotelPhoto> HotelPhotos { get; set; }
    public DbSet<HotelPrice> HotelPrices { get; set; }
    public DbSet<HotelReview> HotelReviews { get; set; }
    public DbSet<HotelRoom> HotelRooms { get; set; }
}
