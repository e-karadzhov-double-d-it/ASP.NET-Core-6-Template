using Microsoft.AspNetCore.Mvc;
using Service.Service.User;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;
        private readonly IUserService userService;

        public HomeController(ILogger<HomeController> logger, IUserService userService)
        {
            _logger = logger;
            this.userService = userService;

        }

        public async Task<IActionResult> Index()
        {


            var user = await this.userService.GetUserByIdAsync("a83b9fde-b70b-435d-9e38-dd4bfe84a481");
            Console.WriteLine(user);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}