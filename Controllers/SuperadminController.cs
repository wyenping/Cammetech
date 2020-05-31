﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using v3x.Models;
using v3x.Data;
using System.Diagnostics;

namespace v3x.Controllers
{
    public class SuperadminController : Controller
    {
        private readonly ILogger<SuperadminController> _logger;
        private readonly v3xContext _context;

        public SuperadminController(ILogger<SuperadminController> logger, v3xContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AdminTable()
        {
            var admin = _context.People.Where(a => a.Role == "Admin");
            ViewData["Admin"] = admin.ToList();

            return View();
        }

        public IActionResult AddAdmin()
        {
            return View();
        }
        
        public async Task<IActionResult> DeleteAdmin(int id)
        {
            var people = await _context.People.FindAsync(id);
            _context.People.Remove(people);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(AdminTable));
            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create_Ad([Bind("Id,Name,Password,Role,Tel,Email,Nationality,DateOfBirth,Address")] People people)
        {
            Debug.WriteLine($"Value: {people.Name}, {people.Email}");
            if (CheckExist(people.Name))
            {
                Debug.WriteLine("This run");
                return RedirectToAction(nameof(AdminTable));
            }

            if (ModelState.IsValid)
            {
                Debug.WriteLine("Model valid");
                _context.Add(people);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(AdminTable));
            }
            return RedirectToAction(nameof(AdminTable));
        }

        private bool CheckExist(string Name)
        {
            var admin = _context.People.FirstOrDefault(a => a.Name == Name);

            if (admin != null)
            {
                return true;
            }

            return false;
        }
    }
}