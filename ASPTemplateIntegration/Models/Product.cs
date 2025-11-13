using System.ComponentModel.DataAnnotations;

namespace ASPTemplateIntegration.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string?  Name { get; set; }

        public decimal Price { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }
    }
}
