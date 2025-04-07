using System.ComponentModel.DataAnnotations;

namespace EventEaseBookingSystem_ST10448834.Models
{
    // Represents a physical venue where events can be hosted
    public class Venue
    {
        public int VenueId { get; set; } // Primary key

        [Required]
        public string VenueName { get; set; } // Name of the venue

        [Required]
        public string Location { get; set; } // Physical address/location of the venue

        [Required]
        public int Capacity { get; set; } // Maximum number of guests the venue can hold

        public string? ImageUrl { get; set; } // URL of the venue image (optional)

        public ICollection<Booking>? Bookings { get; set; } // List of bookings associated with this venue
    }
}

