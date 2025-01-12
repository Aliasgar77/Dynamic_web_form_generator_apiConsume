using library_system.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace library_system.Controllers

{
    public class HomeController : Controller
    {
        Uri baseAddress = new Uri("http://localhost:10356/api/Form");
        private readonly HttpClient _client;

        public HomeController()
        {
            _client = new HttpClient();
            _client.BaseAddress = baseAddress;

        }
        #region Dynamic_WebForm Screen Page
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        #endregion

        #region Send Field To API_Forms_Insert
        [HttpPost]
        public IActionResult Index([FromBody] List<FieldModel> fields)
        {
            return View();
        }
        #endregion   

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Dynamic_Report()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Help_Guide()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
