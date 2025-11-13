using System.ComponentModel.DataAnnotations;

namespace ASPTemplateIntegration.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string? FullName { get; set; }

        public string? Email { get; set; } = string.Empty;

        public DateTime RegisteredOn { get; set; }
    }
}
