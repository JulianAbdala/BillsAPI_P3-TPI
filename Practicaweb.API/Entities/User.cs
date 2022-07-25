using Practicaweb.API.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Practicaweb.API.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } //Esto es vacio no nulo
        public string? Description { get; set; }

        public ICollection<Bill> Bill { get; set; }

        public User(string name)
        {
            Name = name;
        }
    }
}
