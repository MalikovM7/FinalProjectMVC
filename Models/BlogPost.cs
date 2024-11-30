namespace FinalProjectMVC.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CarId { get; set; } // Foreign key to Car

        // Navigation property
        public Car Car { get; set; }
    }
}
