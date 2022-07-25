using Practicaweb.API.DBContexts;
using Practicaweb.API.Entities;

namespace Practicaweb.API.Services
{
    public class InfoUsersRepository : IInfoUsersRepository
    {
        private readonly InfoUsersContext _context;
        public InfoUsersRepository(InfoUsersContext context)
        {
            _context = context;
        }
        public IEnumerable<Bill> GetBillFromUser(int idUser)
        {
            return _context.bills.Where(p => p.UserId == idUser).ToList();
        }

        public Bill? getBillFromUser(int idUser, int idBill)
        {
            return _context.bills.Where(c => c.Id == idBill && c.UserId == idUser).FirstOrDefault();
        }

        public User? GetUser(int idUser)
        {
            return _context.Users.Where(p => p.Id == idUser).FirstOrDefault();

        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.OrderBy(c => c.Name).ToList();
        }
    }
}
