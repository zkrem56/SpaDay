using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        // GET: /user
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // GET: /user/add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // POST: /user
        [HttpPost("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            // Check the password to match verify
            if (newUser.Password.Equals(verify))
            {
                ViewBag.user = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Passwords do Not Match";
                ViewBag.name = newUser.Name;
                ViewBag.username = newUser.Username;
                ViewBag.email = newUser.Email;
                return View("Add");
            }
        }
    }
}
