using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antz.Classes
{
    class World : City
    {

        public List<City> cities = new List<City>();

        public void addCities(string current)
        {
            cities.Add(new City
            {
                Name = current,
                isFood = new Random().Next(100) <= 10 ? true : false
            });
        }

        public void updateCities(string current, string neighbor, int steps)
        {
            foreach (City city in this.cities)
            {
                if (city.Name == neighbor)
                {
                    city.Neighbors.Add(new List<string> { current, steps.ToString() });
                }
            }

        }
    }
}
