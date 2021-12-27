using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Repositories;

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
        private DashboardRespository _repository;

        public DashboardController(Contexto context, DashboardRespository respository)
        {
            _context = context;
            _repository = respository;
        }

        // public IActionResult Index()
        // {
        //     return View();
        // }

        // não funciona

        // public List<DashboardViewModel> listarDashboard = new List<DashboardViewModel>()
        // {
        //     new DashboardViewModel() {IdCliente=1, IdSuporte=1, Local="fabrica", Status=0}
        // };
        public IActionResult Index()
        {
            return View(_repository.Obter());
        
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

        // public async Task<IActionResult> Dashboard()
        // {
        //        return View(await _context.Dashboard.ToListAsync());
        //        return RedirectToAction("Dashboard");
        //
        // public DBContext db = new DbContext();
    }
}