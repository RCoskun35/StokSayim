using Microsoft.AspNetCore.Mvc;
using StokSayim.Core.Services;
using StokSayim.SecService;
using StokSayim.Web.Models;
using System.Diagnostics;

namespace StokSayim.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountService _service;
        private readonly IViewCountsService _viewCountsService;
        public HomeController( ICountService service, IViewCountsService viewCountsService)
        {
            
            _service = service;
            _viewCountsService = viewCountsService;
        }

        public async Task<IActionResult> Index()
        {
            var a = await _viewCountsService.GetAllAsync();
            return View (a);
           
        }

        [HttpPost]
        public async Task<IActionResult> GetCount()
        {
            var a = await _viewCountsService.GetAllAsync();


            return Json(a);
           
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}