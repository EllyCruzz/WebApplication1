using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using WebApplication1.Models;
using WebApplication1.ViewModels;



namespace WebApplication1.Controllers
{
   


    public class DashboardController : Controller
    {
        //private readonly IConfiguration _configuration;
        //public DashboardController(IConfiguration configuration)
        //{
        //    _configuration = configuration;
        //}


        // GET: dashboard


        private readonly Contexto _context;
        public DashboardController(Contexto context)
        {
            _context = context;
        }

        // public IActionResult Index()
        //{

        //    return View();


        //}

        // não funciona

    //    public List<DashboardViewModel> listarDashboard = new List<DashboardViewModel>()
    //    {
    //        new DashboardViewModel() {IdCliente=1, IdSuporte=1, Local="fabrica", Status=0}
    //};
        public IActionResult Index()
        {



            DashboardViewModel dash = new DashboardViewModel();

            return View(dash.RecuperarLista());
        
            // int x = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));

            // var dashboard = _context.Agenda;
            //foreach (var item in _context.Cliente)
            //{
            //    if (item.IdCliente == x)
            //    {
            //        var y = item;
            //        return View(y);

            //    }


            //}
            //return View();
            //include não funciona
            //.Include(c => c.Cliente)
            // .AsNoTracking();


        }



        //     public async Task<IActionResult> Dashboard()
        //     {


        //        return View(await _context.Dashboard.ToListAsync());
        // return RedirectToAction("Dashboard");
        //
        //  public DBContext db = new DbContext();





    }
}