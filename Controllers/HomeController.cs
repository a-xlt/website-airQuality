using aspcore.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using website_airQuality.Models;

namespace website_airQuality.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public ApplicationDbContext _context { get; }


        public HomeController(ILogger<HomeController> logger , ApplicationDbContext context)
        {
            _context = context;

            _logger = logger;
        }

        public IActionResult Index()
        {

            var databaseDAta = _context.AirData.ToList();
            if (databaseDAta.Count > 0)
            {

                List<ViewData> vData = new List<ViewData>();

                foreach (var item in databaseDAta)
                {
                    var tempdata = item.rowData!.Split(',');
                    vData.Add(
                        new ViewData
                        {
                            Id = item.Id,
                            time = Convert.ToDateTime(item.Time),
                            Humd = Convert.ToInt32(tempdata[0]),
                            Temp = Convert.ToInt32(tempdata[1]),
                            Tvoc = Convert.ToInt32(tempdata[2]),
                            Co2 = Convert.ToInt32(tempdata[3]),
                            Dust = Convert.ToInt32(tempdata[4]),
                            O3 = Convert.ToInt32(tempdata[5]),

                        }
                        );
                }
                return View(vData);
            }

          
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
