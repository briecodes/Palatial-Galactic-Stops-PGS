using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalatialGalacticStops.Models
{
  public class PlaceModel
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
  }
}
