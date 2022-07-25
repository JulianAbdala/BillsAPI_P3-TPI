using Practicaweb.API.Models;

namespace Practicaweb.API.Models
{
    public class userDto //Consultas
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty; //Esto es vacio no nulo
        public IList<BillDto> bills { get; set; } = new List<BillDto>(); // Creamos una lista de bills como propiedad de cada user
        public int CantidadDebills
        {
            get { return bills.Count; }
        }
    }
}
