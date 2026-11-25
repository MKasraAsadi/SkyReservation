using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkyReservation.WebAPI.Entities;
using SkyReservation.WebAPI.Models;

namespace SkyReservation.WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base()
        {
            
        }
        public DbSet<User> Products { get; set; }
        public DbSet<Airport> Airports { get; set; }
        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AircraftManufacturer> AircraftManufacturers { get; set; }
    }
}
