using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PalatialGalacticStops.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PalatialGalacticStops.Controllers
{
  public class HomeController : Controller
  {
    // GET: /<controller>/
    public IActionResult Index()
    {

      var homeViewModel = new HomeViewModel()
      {
        Title = "Welcome to PGS!"
      };

      return View(homeViewModel);
    }
  }
}
