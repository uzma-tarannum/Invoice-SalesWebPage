using WebApplication1.Models.Entitties;

namespace WebApplication1.Models.DataAccess
{
    public interface IUserRepository
    {
        void AddUser(User user);
    }
}
