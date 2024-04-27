using Microsoft.AspNetCore.Mvc;
using WebApplication1.Factories;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserFactory _userFactory;
        public UserController(IUserFactory userFactory)
        {
                _userFactory = userFactory;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Save(UserViewModel model)
        {
            _userFactory.InsertUser(model);
            return View();
        }
    }
}
