using System.ComponentModel.DataAnnotations;

namespace BookService.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        public string Make { get; set; }
        public int Year { get; set; }

        // Foreign Key
        public int ManufacturerId { get; set; }
        // Navigation property
        public Manufacturer Manufacturer { get; set; }
    }
}