using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using MH_Engine.Models;
using Microsoft.Extensions.Logging;
using MH_Engine.Models.ViewModels;

namespace MH_Engine.Controllers
{
    public class HomeController : Controller
    {
    //    private readonly SignInManager<ApplicationUser> _signInManager;
    //    private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger _logger;

        public HomeController(
            ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<AccountController>();
        }

        // GET: /Home/Index, /
        public IActionResult Index()
        {
            return RedirectToAction("Login", "AccountController");
        }

        // GET: /Home/Credits
        public IActionResult Credits()
        {
            var model = new PageViewModel("Credits");
            return View(model);
        }

        // GET: /Home/Links
        public IActionResult Links()
        {
            var model = new PageViewModel("Links");
            return View(model);
        }

        // GET: /Home/Manuals
        public IActionResult Manuals()
        {
            var model = new PageViewModel("Manuals");
            return View(model);
        }

        // GET: /Home/Error
        public IActionResult Error()
        {
            return View();
        }
    }
}
