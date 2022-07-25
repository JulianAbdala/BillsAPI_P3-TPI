using System.ComponentModel.DataAnnotations;

namespace Practicaweb.API.Models
{
    public class billsCreacionDto
    {
        [Required]
        public string Nombre { get; set; } = string.Empty;
        [Required]
        public double Price { get; set; }
        [Required]
        public long CUIT { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
    }
}
