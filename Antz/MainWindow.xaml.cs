using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Antz.Classes;

namespace Antz
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private World world = new World();
        private Nest nest = new Nest();

        public MainWindow()
        {
            InitializeComponent();
            this.addNest();
        }

        private void sldNumber_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.lblNumber.Content = this.sldNumber.Value;
        }

        private void addWorld()
        {
            //foreach()
            this.world.addCities("");

            //foreach()
            this.world.updateCities("", "", 0);
        }
        private void addNest()
        {
            this.nest.addAnts(100);
            this.nest.showAnts();
        }
    }
}
