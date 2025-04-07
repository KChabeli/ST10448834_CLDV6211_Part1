using Microsoft.EntityFrameworkCore;
using EventEaseBookingSystem_ST10448834.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace EventEaseBookingSystem_ST10448834.Data
{
    // Database context for EF Core to manage Venues, Events, and Bookings
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Tables in the database
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        // Configure entity relationships and rules
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Prevents double bookings on the same venue and date
            modelBuilder.Entity<Booking>()
                .HasIndex(b => new { b.VenueId, b.BookingDate })
                .IsUnique();
        }
    }
}

