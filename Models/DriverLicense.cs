using FinalProjectMVC.Identity.Data;

namespace FinalProjectMVC.Models
{
    public class DriverLicense
    {
        public int Id { get; set; } 

        public string LicenseNumber { get; set; } 

        public string ImagePath { get; set; }

        public string AppUserId { get; set; } // Foreign key for AppUser
        public AppUser AppUser { get; set; }
    }
}
