using System.ComponentModel.DataAnnotations;

namespace EventEaseBookingSystem_ST10448834.Models
{
    // Represents a confirmed booking between an event and a venue
    public class Booking
    {
        public int BookingId { get; set; } // Primary key

        [Required]
        public DateTime BookingDate { get; set; } // Date the venue is booked for the event

        public int EventId { get; set; } // Foreign key to the event
        public Event? Event { get; set; } // Navigation property

        public int VenueId { get; set; } // Foreign key to the venue
        public Venue? Venue { get; set; } // Navigation property
    }
}

