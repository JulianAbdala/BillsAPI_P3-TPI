using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practicaweb.API.Entities
{
    public class Bill // Consultas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public double Price { get; set; }
        [Required] 
        public long CUIT { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;

        [ForeignKey("UserId")]
        public User user { get; set; }

        public int UserId { get; set; }


        public Bill(string name)
        {
            Name = name;
        }

    }
}
