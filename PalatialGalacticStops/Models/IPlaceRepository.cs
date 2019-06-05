using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalatialGalacticStops.Models
{
  interface IPlaceRepository
  {
    IEnumerable<PlaceModel> GetAllPlaces();
    PlaceModel GetPlaceById(int placeId);
  }
}
