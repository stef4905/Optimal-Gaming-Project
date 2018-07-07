using Optimal_Gaming_Class_Library.Control_Layer;
using Optimal_Gaming_Class_Library.Model_Layer;
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
            List<CPU> cpu = _ComponentController._ComponentCPUController.GetAllCPU();
            List<GPU> gpu = _ComponentController._ComponentGPUController.GetAllGPU();
            List<HDD> hdd = _ComponentController._ComponentHDDController.GetAllHDD();
            List<SSD> ssd = _ComponentController._ComponentSSDController.GetAllSSD();
            List<Ram> ram = _ComponentController._ComponentRamController.GetAllRam();
            List<Motherboard> motherboard = _ComponentController._ComponentMotherboardController.GetAllMotherboard();
            List<PSU> psu = _ComponentController._ComponentPSUController.GetAllPSU();

            //Foreach over each pc part list and insert them into the table
            foreach (var _case in Case)
            {
                TableList.Items.Add(_case);
            }
            foreach (var _cpu in cpu)
            {
                TableList.Items.Add(_cpu);
            }
            foreach (var _gpu in gpu)
            {
                TableList.Items.Add(_gpu);
            }
            foreach (var _hdd in hdd)
            {
                TableList.Items.Add(_hdd);
            }
            foreach (var _ssd in ssd)
            {
                TableList.Items.Add(_ssd);
            }
            foreach (var _ram in ram)
            {
                TableList.Items.Add(_ram);
            }
            foreach (var _motherboard in motherboard)
            {
                TableList.Items.Add(_motherboard);
            }
            foreach (var _psu in psu)
            {
                TableList.Items.Add(_psu);
            }
        }

        private void SearchForPart(object sender, RoutedEventArgs e)
        {

        }

        private void ShowAllParts(object sender, RoutedEventArgs e)
        {
            GetAllSpecsAndRefresh();
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
            if (selectedItem.GetType() == typeof(CPU))
            {
                _ComponentController._ComponentCPUController.DeleteFromDatabase(selectedItem as CPU);
            }
            if (selectedItem.GetType() == typeof(GPU))
            {
                _ComponentController._ComponentGPUController.DeleteFromDatabase(selectedItem as GPU);
            }
            if (selectedItem.GetType() == typeof(HDD))
            {
                _ComponentController._ComponentHDDController.DeleteFromDatabase(selectedItem as HDD);
            }
            if (selectedItem.GetType() == typeof(SSD))
            {
                _ComponentController._ComponentSSDController.DeleteFromDatabase(selectedItem as SSD);
            }
            if (selectedItem.GetType() == typeof(Ram))
            {
                _ComponentController._ComponentRamController.DeleteFromDatabase(selectedItem as Ram);
            }
            if (selectedItem.GetType() == typeof(Motherboard))
            {
                _ComponentController._ComponentMotherboardController.DeleteFromDatabase(selectedItem as Motherboard);
            }
            if (selectedItem.GetType() == typeof(PSU))
            {
                _ComponentController._ComponentPSUController.DeleteFromDatabase(selectedItem as PSU);
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
