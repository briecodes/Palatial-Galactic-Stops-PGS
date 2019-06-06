using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalatialGalacticStops.Models
{
  public class PlaceRepository : IPlaceRepository
  {
    private readonly AppDbContext _appDbContext;

    public PlaceRepository(AppDbContext appDbContext)
    {
      _appDbContext = appDbContext;
    }

    public IEnumerable<PlaceModel> GetAllPlaces()
    {
      return _appDbContext.Places;
    }

    public PlaceModel GetPlaceById(int placeId)
    {
      return _appDbContext.Places.FirstOrDefault(place => place.Id == placeId);
    }
  }
}
