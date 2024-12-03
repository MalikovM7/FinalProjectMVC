using FinalProjectMVC.Identity.Data;

namespace FinalProjectMVC.Models
{
    public class Reservation
    {
        public int Id { get; set; } // Primary Key


        // Reservation details
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }

        // Status of the reservation (Pending, Accepted, Rejected)
        public string Status { get; set; }
    }
}