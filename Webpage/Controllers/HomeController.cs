using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Webpage.Models;

namespace Webpage.Controllers
{
    public class HomeController : Controller
    {
        private readonly datingsiteContext _context;
        private readonly ILogger<HomeController> _logger;
        public int UserId;
        public Profil User;
        public HomeController(ILogger<HomeController> logger, datingsiteContext context)
        {
            _logger = logger;
            _context = context;
            User = context.Profils.ToList().First();
        }

        public IActionResult Index()
        {
            return View(1);
        }
        public IActionResult UserProfile() 
        {
            return View(User);
        }
        public IActionResult Privacy()
        {
            return View(UserId);
        }
        [HttpPost]
        public IActionResult Privacy(int id) {
            UserId = id;
            return View(UserId);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
