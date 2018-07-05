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

namespace Content_Management_System
{
    /// <summary>
    /// Interaction logic for AddGame.xaml
    /// </summary>
    public partial class AddGame : UserControl
    {
        Grid MainGrid = null;
        
        public AddGame(Grid mainGrid)
        {
            InitializeComponent();
            MainGrid = mainGrid;
        }

        private void AddGameButton(object sender, RoutedEventArgs e)
        {

        }

        private void SerachButton(object sender, RoutedEventArgs e)
        {

        }
    }
}
