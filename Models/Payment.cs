namespace FinalProjectMVC.Models
{
    public class Payment
    {
        public int Id { get; set; } // Primary Key
        public int ReservationId { get; set; } // Foreign Key
        public Reservation Reservation { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; set; } // e.g., Paid, Pending, Failed
    }
}
