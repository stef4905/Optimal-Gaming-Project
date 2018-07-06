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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Grid _MainGrid = null;
        

        public MainWindow()
        {
            InitializeComponent();
            _MainGrid = MainGrid;
            MainGrid.Children.Add(new Home());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new Game(_MainGrid));
        }

        private void OverViewButton(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new Home());
        }

        private void SpecButton_Click(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new PcParts(_MainGrid));
        }

        private void BuildButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void WebsiteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
