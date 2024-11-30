using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProjectMVC.Models;
using Microsoft.AspNetCore.Identity;

namespace FinalProjectMVC.Areas.Identity.Data;

// Add profile data for application users by adding properties to the AppUser class
public class AppUser : IdentityUser
{
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }

    // Relationships
    public DriverLicense DriverLicense { get; set; } // One-to-One Relationship
    public ICollection<Car> RentedCars { get; set; } // One-to-Many Relationship

    public ICollection<Reservation> Reservations { get; set; }

    // Additional fields
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;

}

