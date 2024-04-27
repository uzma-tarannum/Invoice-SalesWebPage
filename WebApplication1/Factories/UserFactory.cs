using WebApplication1.Models.DataAccess;
using WebApplication1.Models.Entitties;
using WebApplication1.ViewModels;

namespace WebApplication1.Factories
{
    public class UserFactory : IUserFactory
    {
        private readonly IUserRepository _userRepository;
        public UserFactory(IUserRepository userRepository)
        {
                _userRepository = userRepository;
        }
        public void InsertUser(UserViewModel user)
        {
            var model = new User
            {
                Id = user.Id,
                Name = user.UserName,
                Password = user.Password,
            };
            _userRepository.AddUser(model);
        }
    }
}
