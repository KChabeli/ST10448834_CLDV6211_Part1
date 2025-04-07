using System.ComponentModel.DataAnnotations;

namespace EventEaseBookingSystem_ST10448834.Models
{
    // Represents a planned event (e.g., wedding, conference)
    public class Event
    {
        public int EventId { get; set; } // Primary key

        [Required]
        public string EventName { get; set; } // Name of the event

        [Required]
        public DateTime EventDate { get; set; } // Date of the event

        public string? Description { get; set; } // Description/details about the event

        public int? VenueId { get; set; } // Optional link to a venue
        public Venue? Venue { get; set; } // Navigation property to the venue

        public ICollection<Booking>? Bookings { get; set; } // List of bookings for this event
    }
}

