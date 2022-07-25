using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Practicaweb.API.Models;

namespace Practicaweb.API.Controllers
{
    [ApiController]
    [Route("api/Users/{iduser}/bills")] // Forzamos a que los bills dependan de una user
    public class billsController : ControllerBase
    {
        private readonly UsersData _UsersData;
        public billsController(UsersData usersData)
        {
            _UsersData = usersData;
        }
        [HttpGet]
        public ActionResult<List<BillDto>> Getbills(int iduser)
        {
            var user = _UsersData.Users.Where(x => x.Id == iduser).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user.bills);
        }

        [HttpGet("{idbills}", Name = "Getbills")]


        public ActionResult<BillDto> Getbills(int iduser, int idbills)
        {
            var user = _UsersData.Users.Where(x => x.Id == iduser).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }

            var bills = user.bills.Where(x => x.Id == idbills).FirstOrDefault();
            if (bills == null)
            {
                return NotFound();
            }
            return Ok(bills);
        }

        [HttpPost] //Crear

        public ActionResult<BillDto> CrearBill(int iduser, billsCreacionDto BillACrear)
        {
            var user = _UsersData.Users.Where(x => x.Id == iduser).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }

            var idMaxbills = _UsersData.Users.SelectMany(c => c.bills).Max(p => p.Id);  //Selectmany crea una lista a partir de las lista seleccionada dentro
            //Se selecciona la IP máxima en bills y se crea un nuevo Bill
            var nuevoBill = new BillDto
            {
                Id = idMaxbills + 1, // se le suma +1 a la lista de bills
                Name = BillACrear.Nombre,
                CUIT = BillACrear.CUIT,
                Description = BillACrear.Description,
                Price = BillACrear.Price
            };

            user.bills.Add(nuevoBill);

            return CreatedAtRoute("Getbills",
                new
                {
                    iduser,
                    idbills = nuevoBill.Id
                },
                nuevoBill);

        }
        [HttpPut("{idbills}")] //Modificar

        public ActionResult<BillDto> ModificarBill(int iduser, int idbills, billsActualizarDto BillActualizado)
        {
            var user = _UsersData.Users.Where(x => x.Id == iduser).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }

            var BillAActualizar = user.bills.Where(x => x.Id == idbills).FirstOrDefault();
            if (BillAActualizar == null)
            {
                return NotFound();
            }

            BillAActualizar.Name = BillActualizado.Nombre;

            return NoContent();
        }

        [HttpDelete("{idbills}")]

        public ActionResult EliminarBill(int iduser, int idbills)
        {
            var user = _UsersData.Users.Where(x => x.Id == iduser).FirstOrDefault();
            if (user == null)
            {
                return NotFound();
            }

            var BillAEliminar = user.bills.Where(x => x.Id == idbills).FirstOrDefault();
            if (BillAEliminar == null)
            {
                return NotFound();
            }

            user.bills.Remove(BillAEliminar);

            return NoContent();
        }
    }
}
