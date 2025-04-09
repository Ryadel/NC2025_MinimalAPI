using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NC2025_MinimalAPI_NET9.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public decimal Price { get; set; }

        // Foreign key
        public int CategoryId { get; set; }


        // Navigation property
        [JsonIgnore]
        public Category? Category { get; set; }
    }
}