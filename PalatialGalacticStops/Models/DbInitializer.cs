using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalatialGalacticStops.Models
{
  public class DbInitializer
  {
    public static void Seed(AppDbContext context)
    {
      if (!context.Places.Any())
      {
        context.AddRange(
          new PlaceModel { Name = "Foodcourtia", Location = "Irken Corner", Description = "Foodcourtia is one of many planets under the control of the Irken Empire. It's likely that Foodcourtia is the name given to this planet by the Irkens rather than the original title. In the tradition of Irken efficiency, the planet was assigned a very specific purpose; in this case, to serve as an intergalactic food court.", ImageUrl = "https://vignette.wikia.nocookie.net/zimwiki/images/1/1f/Foodcourtia_%28The_Frycook_What_Came_From_All_That_Space%29.png/revision/latest?cb=20121214000153" },
          new PlaceModel { Name = "Shloogorgh's Flavor Monster", Location = "Foodcourtia", Description = "Shloogorgh's Flavor Monster is a fast food restaurant located on Foodcourtia . It's owned and administrated by the Irken Frylord Sizz-Lorr. After ruining Operation Impending Doom, Zim was sentenced to work at this restaurant for the rest of his life.", ImageUrl = "https://vignette.wikia.nocookie.net/zimwiki/images/7/79/Shloogorgh%27s1.png/revision/latest?cb=20140409210607" },
          new PlaceModel { Name = "Snacky Cabs", Location = "Foodcourtia", Description = "Like the taxi cabs on Earth, Foodcourtia's Snacky Cabs use small, yellow vehicles to transport people from one part of the planet to another. The only difference is that the latter service uses spaceships instead. These vehicles are maneuverable and deceptively small in appearance, and can in fact hold about three to four people and a good deal of luggage. However, their metal hulls are also rather weak, and were easily pierced by Sizz-Lorr's large spatula when he was pursuing Zim.", ImageUrl = "https://vignette.wikia.nocookie.net/zimwiki/images/e/e8/Sdljadssakjladjsads.png/revision/latest?cb=20121103221353" },
          new PlaceModel { Name = "MacMeaties", Location = "Earth", Description = "MacMeaties is a fast food restaurant featured in many episodes of the Invader Zim series. It's a parody of the McDonald's fast food chain and is where Zim went for his Career Day field trip after being assigned a life career of fast food preparation, only to have his temporary employment terminated by the shift captain when his molting went out of control. It's also where Mortos first went to power up.", ImageUrl = "https://vignette.wikia.nocookie.net/zimwiki/images/a/ab/Mac_Meaties_1.jpg/revision/latest?cb=20130816225838" }
        );
        context.SaveChanges();
      }
    }
  }
}
