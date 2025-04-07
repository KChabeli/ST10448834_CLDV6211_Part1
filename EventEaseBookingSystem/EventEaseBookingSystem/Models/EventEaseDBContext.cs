namespace EventEaseBookingSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EventEaseDBContext : DbContext
    {
        public EventEaseDBContext()
            : base("name=EventEaseDBContext")
        {
        }

        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
