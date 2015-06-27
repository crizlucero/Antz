using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antz.Classes
{
    class Ant
    {
        public int ID { get; set; }
        public List<City> route { get; set; }
        public int pheromone = GlobalVars.MAXPHEROMONE;

        public void step(City city)
        {
            if (route.Exists(x => x == city))
            {
                route.Add(city);
                if (!city.isFood)
                    pheromone--;
                else
                    pheromone = GlobalVars.MAXPHEROMONE;
            }
        }
    }
}
