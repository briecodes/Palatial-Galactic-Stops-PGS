using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PalatialGalacticStops.Models;
using PalatialGalacticStops.ViewModels;

namespace PalatialGalacticStops.Controllers
{
  public class HomeController : Controller
  {
    private readonly IPlaceRepository _placeRepository;

    public HomeController(IPlaceRepository placeRepository)
    {
      _placeRepository = placeRepository;
    }

    // GET: /<controller>/
    public IActionResult Index()
    {
      var places = _placeRepository.GetAllPlaces().OrderBy(p => p.Name);
      var homeViewModel = new HomeViewModel()
      {
        Title = $"Number of places: {places.Count()}",
        Places = places.ToList(),
      };

      return View(homeViewModel);
    }
  }
}
