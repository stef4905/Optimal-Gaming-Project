using Optimal_Gaming_Class_Library.Control_Layer;
using Optimal_Gaming_Class_Library.Model_Layer.Components;
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
    /// Interaction logic for PcParts.xaml
    /// </summary>
    public partial class PcParts : UserControl
    {
        Grid MainGrid = null;
        ComponentController _ComponentController = new ComponentController();
        
        public PcParts(Grid mainGrid)
        {
            InitializeComponent();
            MainGrid = mainGrid;
            GetAllSpecsAndRefresh();
        }

        /// <summary>
        /// Displayes all pc parts from the mongo db in the table list
        /// </summary>
        private void GetAllSpecsAndRefresh()
        {
            //Clear the table first
            TableList.Items.Clear();

            //Get all pc parts through their individual controller
            List<Case> Case = _ComponentController._ComponentCaseController.GetAllCase();

            //Foreach over each pc part list and insert them into the table
            foreach (var _case in Case)
            {
                TableList.Items.Add(_case);
            }
        }

        private void SearchForPart(object sender, RoutedEventArgs e)
        {

        }

        private void ShowAllParts(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteSelectedPart(object sender, RoutedEventArgs e)
        {
            //Get the selected item in the list
            var selectedItem = TableList.SelectedItem;

            //Check for the type of the object. Used to dertermain wich controller to act on.
            if (selectedItem.GetType() == typeof(Case))
            {
                _ComponentController._ComponentCaseController.DeleteFromDatabase(selectedItem as Case);
            }

            //Refresh the list of all the pc parts
            GetAllSpecsAndRefresh();
        }

        private void EditSelectedPart(object sender, RoutedEventArgs e)
        {

        }

        private void AddNewPart(object sender, RoutedEventArgs e)
        {
            MainGrid.Children.Clear();
            MainGrid.Children.Add(new AddSpec());
        }
    }
}
