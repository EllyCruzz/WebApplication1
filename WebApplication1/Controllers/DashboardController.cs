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

        // public IActionResult Index()
        //{

        //    return View();


        //}

        // TENTEI MAPEAR MAS NÃO CONSEGUI FAZER FUNCIONAR

        public async Task<IActionResult> Index()
        {
            var date = Convert.ToDateTime("2021-12-07"); //DateTime.Today;

            var agenda = _context.Agenda
                .FromSqlRaw("SELECT C.Nome, C.Local, A.Horario, A.Status, S.Nome" +
                " FROM Agenda AS A " +
                " INNER JOIN Cliente AS C ON A.ClienteIdCliente = C.IdCliente" +
                " INNER JOIN Suporte AS S ON A.SuporteIdCliente = S.IdSuporte" +
                " WHERE A.Data >=" + date + " AND A.Data < " + date.AddDays(1))
                .ToList();

            return View();
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