﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using v3x.Models;
using v3x.Data;

namespace v3x.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly v3xContext _context;

        public IActionResult Index()
        {
            return View();
        }

        public HomeController(ILogger<HomeController> logger, v3xContext context)
        {
            _logger = logger;
            _context = context;

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



        [HttpPost]
        public async Task<IActionResult> Login(string Name, string Password)
        {            

            var people = await _context.People.FirstOrDefaultAsync(m => m.Name == Name && m.Password == Password);

            if(people==null)
            {
                Response.WriteAsync("<script>alert('Invalid user or password')</script>");
                return View("Index");
            }

            HttpContext.Session.SetInt32("Session_Id", people.Id);
            HttpContext.Session.SetString("Session_Role", people.Role);
            HttpContext.Session.SetString("Session_Name", people.Name);

            var role = char.ToUpper(people.Role[0]) + people.Role.Substring(1);

            return View($"../{role}/Index", people);

        }

        public IActionResult Logout()
        {
            
            HttpContext.Session.Clear();

            foreach (var cookie in Request.Cookies.Keys)
            {
                Response.Cookies.Delete(cookie);
            }

            return View("Index");
        }

    }
}
