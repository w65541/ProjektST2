﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Storage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Webpage.Models;
using Storage.Models;
namespace Webpage.Controllers
{
    public class HomeController : Controller
    {
        private readonly datingsiteContext _context;
        private readonly ILogger<HomeController> _logger;
        public int UserId;
        public Profil Userr;
        public HomeController(ILogger<HomeController> logger, datingsiteContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Login()
        {
            Userr = null;
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View(Userr);
        }
        public IActionResult UserProfile() 
        {
            return View(Userr);
        }

        [HttpGet]
        public IActionResult Index(int id) {

                Userr = _context.Profils.Where(x => x.IdUser == id).ToList().First();
                return View(Userr);

        }
        [HttpGet]
        public IActionResult UserProfile(int id)
        {

            Userr = _context.Profils.Where(x => x.IdUser == id).ToList().First();
            return View(Userr);

        }
        [HttpGet]
        public IActionResult Profile(int id1, int id2,int id3) {
            ProfileData temp = new ProfileData(_context.Profils.Where(x => x.Id == id2).ToList().First(),id1,id3);
            return View(temp);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
