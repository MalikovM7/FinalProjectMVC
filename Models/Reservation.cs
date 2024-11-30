using FinalProjectMVC.Areas.Identity.Data;

namespace FinalProjectMVC.Models
{
    public class Reservation
    {
        public int Id { get; set; } // Primary Key

        // Change the type of UserId to string
        public string UserId { get; set; } // Foreign Key

        // Navigation property
        public AppUser AppUser { get; set; }

        public int CarId { get; set; } // Foreign Key
        public Car Car { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } // e.g., Pending, Accepted, Rejected
    }
}
