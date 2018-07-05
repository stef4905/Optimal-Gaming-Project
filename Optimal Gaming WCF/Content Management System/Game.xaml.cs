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
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : UserControl
    {

        Grid MainGrid = null;
        
        public Game(Grid mainGrid)
        {
            InitializeComponent();
            MainGrid = mainGrid;
        }

        private void AddNewGame(object sender, RoutedEventArgs e)
        {
            //Not currently set to do anything
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new AddGame(MainGrid));
        }

        private void ShowAllGames(object sender, RoutedEventArgs e)
        {
            // Not currently set to do anything
        }

        private void SearchForGame(object sender, RoutedEventArgs e)
        {
            // Not currently set to do anything
        }

        private void DeleteSelectedGame(object sender, RoutedEventArgs e)
        {
            // Not currently set to do anything
        }
    }
}
