using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookService.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}