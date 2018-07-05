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
    /// Interaction logic for Specs.xaml
    /// </summary>
    public partial class Specs : UserControl
    {

        Grid MainGrid = null;

        public Specs(Grid mainGrid)
        {
            InitializeComponent();
            MainGrid = mainGrid;
        }

        private void EditSelectedPart(object sender, RoutedEventArgs e)
        {

        }

        private void AddNewPart(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteSelectedPart(object sender, RoutedEventArgs e)
        {

        }

        private void SearchForPart(object sender, RoutedEventArgs e)
        {

        }

        private void ShowAllParts(object sender, RoutedEventArgs e)
        {

        }
    }
}
