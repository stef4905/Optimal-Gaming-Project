using Optimal_Gaming_Class_Library.Control_Layer;
using Optimal_Gaming_Class_Library.Model_Layer;
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
        GameController _GameController = null;
        
        public AddGame(Grid mainGrid)
        {
            InitializeComponent();
            MainGrid = mainGrid;
            _GameController = new GameController();
        }

        /// <summary>
        /// Adding the slected item (game) to the Mongo database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddGameButton(object sender, RoutedEventArgs e)
        {
            RootObject game = TableList.SelectedItem as RootObject;
            _GameController.CreateGame(game);
        }

        private void SerachButton(object sender, RoutedEventArgs e)
        {
            //Serach for a game and display it in the list underneath
            List<RootObject> list = _GameController.FindAllContaining(SearchField.Text);

            //Clear the current content in the table
            TableList.Items.Clear();

            //Add content to table
            foreach (var game in list)
            {
                TableList.Items.Add(game);
            }

            
        }
    }
}
