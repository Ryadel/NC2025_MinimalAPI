using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace NC2025_MinimalAPI_NET9.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        // One-to-Many relationship
        public List<Product>? Products { get; set; }
    }
}