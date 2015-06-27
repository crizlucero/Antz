using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antz.Classes
{
    class City
    {
        public string Name { get; set; }
        public List<List<string>> Neighbors = new List<List<string>>();
        public bool isFood { get; set; }
        public bool isNest { get; set; }
        /// <summary>
        /// Muestra los vecinos de la ciudad
        /// </summary>
        public void showNeighbors()
        {
            Console.WriteLine(this.Name);
            foreach (List<string> neighbor in this.Neighbors)
            {
                Console.WriteLine(neighbor[0] + ": " + neighbor[1]);
            }
        }

    }
}
