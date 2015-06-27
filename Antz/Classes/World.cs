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
        /// <summary>
        /// Se agregan las ciudades al mundo
        /// </summary>
        /// <param name="current"></param>
        public void addCities(string current)
        {
            cities.Add(new City
            {
                Name = current,
                isFood = new Random().Next(100) <= 10 ? true : false
            });
        }
        /// <summary>
        /// Se le agregan los vecinos a las ciudades
        /// </summary>
        /// <param name="current"></param>
        /// <param name="neighbor"></param>
        /// <param name="steps"></param>
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
