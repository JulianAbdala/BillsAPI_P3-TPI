using Practicaweb.API.Entities;

namespace Practicaweb.API.Services
{
    public interface IInfoUsersRepository
    {
        public IEnumerable<User> GetUsers();
        public User? GetUser(int idUser);
        public IEnumerable<Bill> GetBillFromUser(int idUser);
        public Bill? getBillFromUser(int idUser, int idBill);

    }
}
