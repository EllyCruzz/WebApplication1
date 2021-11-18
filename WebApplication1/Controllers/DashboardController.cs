using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using WebApplication1.Models;
using WebApplication1.ViewModels;



namespace WebApplication1.Controllers
{
    public class DashboardController : Controller
    {

        // GET: dashboard


        private readonly Contexto _context;
        public DashboardController(Contexto context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            return View();


        }

        // TENTEI MAPEAR MAS NÃO CONSEGUI FAZER FUNCIONAR

        /* public async Task<IActionResult> Index(ModelBuilder builder)
        {
            var dashboard = _context.Dashboard;
         
                            builder.Entity<DashboardViewModel>()
                 .HasKey(s => s.IdCliente);

                .Include(c => c.IdCliente)

                .Include(c => c.IdSuporte)
                .AsNoTracking();
            return View(await dashboard.ToListAsync());
        }

        */


        //     public async Task<IActionResult> Dashboard()
        //     {


        //        return View(await _context.Dashboard.ToListAsync());
        // return RedirectToAction("Dashboard");
        //
        //  public DBContext db = new DbContext();





    }
}