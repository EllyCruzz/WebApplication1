using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class DashboardController : Controller
    {
        private readonly Contexto _context;
        
        // GET: dashboard
        public async Task<IActionResult> Dashboard()
        {
            return View(await _context.Dashboard.ToListAsync());
            // return RedirectToAction("Dashboard");
        }

        public DashboardController(Contexto context)
        {
            _context = context;
        }
    }
}