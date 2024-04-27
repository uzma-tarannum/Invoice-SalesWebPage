using WebApplication1.Models.Entitties;

namespace WebApplication1.Models.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private readonly EBMContext _db;
        public UserRepository(EBMContext db)
        {
                _db = db;
        }
        public void AddUser(User user)
        {
            _db.User.Add(user);
            _db.SaveChanges();
        }
    }
}
