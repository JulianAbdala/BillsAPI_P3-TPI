namespace Practicaweb.API.Models
{
    public class BillDto // Consultas
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public double Price { get; set; }
        public long CUIT { get; set; }

        public string Description { get; set; } = string.Empty;

    }
}
