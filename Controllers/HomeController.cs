using Microsoft.AspNetCore.Mvc;
using MyPortfolio.Models;
using System.Diagnostics;

namespace MyPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Portfolio> _portfolios = new List<Portfolio>()
        {
            new Portfolio { Id = 1,Title="Manama",Image="01.jpg",Description="این اولین پروژه ی من بود"},
            new Portfolio { Id = 2,Title="Iran Asbab",Image="02.jpg",Description="این دومین پروژه ی من بود"},
            new Portfolio { Id = 3,Title="Arya",Image="03.jpg",Description="این سومین پروژه ی من بود"},
            new Portfolio { Id = 4,Title="AliBaba",Image="04.jpg",Description="این چهارمین پروژه ی من بود"},
            new Portfolio { Id = 5,Title="BarSava",Image="05.jpg",Description="این سومین پروژه ی من بود"},
            new Portfolio { Id = 6,Title="Montazeri",Image="06.jpg",Description="این سومین پروژه ی من بود"},

        };
        public IActionResult Index()
        {
            ViewData["HeadingTitle"] = "به وب سایت شخصی مهیار شریفی خوش آمدید";
            ViewData["HeadingText"] = "به وب سایت شخصی مهیار شریفی خوش آمدید به وب سایت شخصی مهیار شریفی خوش آمدید به وب سایت شخصی مهیار شریفی خوش آمدید به وب سایت شخصی مهیار شریفی خوش آمدید به وب سایت شخصی مهیار شریفی خوش آمدید به وب سایت شخصی مهیار شریفی خوش آمدید به وب سایت شخصی مهیار شریفی خوش آمدید به وب سایت شخصی مهیار شریفی خوش آمدید به وب سایت شخصی مهیار شریفی خوش آمدید";
            return View(_portfolios);
        }

        public IActionResult Contact()
        {
            var contact = new Contact() { Email = "MahyarSharifi82@Gmail.Com", Phone = "09107633956", Github = "MahyarSharifii" };
            return View(contact);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}