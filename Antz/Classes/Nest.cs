using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antz.Classes
{
    class Nest
    {
        private List<Ant> ants = new List<Ant>();
        private City origin;
        /// <summary>
        /// Agrega las hormigas al hormiguero
        /// </summary>
        /// <param name="total"></param>
        public void addAnts(int total)
        {
            for (int i = 0; i < total; i++)
                this.ants.Add(new Ant { ID = i });

        }
        /// <summary>
        /// Agrega la ciudad donde se aloja el hormiguero
        /// </summary>
        /// <param name="city">Ciudad seleccionada</param>
        public void setOrigin(City city)
        {
            this.origin = city;
        }
        /// <summary>
        /// Muestra la cantidad de feromona que tiene la hormiga
        /// </summary>
        public void showAnts()
        {
            foreach (Ant ant in ants)
            
                Console.WriteLine("Ant #" + ant.ID + ": feromona" + ant.pheromone);
            
        }
    }
}
