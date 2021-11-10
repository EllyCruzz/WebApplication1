using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using System.Web;
using System.Data.SqlClient;

namespace WebApplication1.Controllers
{
    public class DashboardController : Controller
    {

        // GET: dashboard



        //     public async Task<IActionResult> Dashboard()
        //     {


        //        return View(await _context.Dashboard.ToListAsync());
        // return RedirectToAction("Dashboard");
        //
      //  public DBContext db = new DbContext();
        public IActionResult Index()
        {
          
            return View(Contexto.Agenda.ToList());
       

        }
        private readonly Contexto _context;

        public DashboardController(Contexto context)
        {
            _context = context;
        }




    }
}