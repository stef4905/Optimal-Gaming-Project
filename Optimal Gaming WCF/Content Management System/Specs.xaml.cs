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
    /// Interaction logic for Specs.xaml
    /// </summary>
    public partial class Specs : UserControl
    {

        Grid MainGrid = null;

        //All controllers handelig the specs
        ComponentController _ComponentController = new ComponentController();

        public Specs(Grid mainGrid)
        {
            InitializeComponent();
            MainGrid = mainGrid;
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

        private void DeleteSelectedPart(object sender, RoutedEventArgs e)
        {

        }

        private void SearchForPart(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Show all specs in the Mongo Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAllParts(object sender, RoutedEventArgs e)
        {
            GetAllSpecsAndRefresh();
        }


        public void GetAllSpecsAndRefresh()
        {
            //Does not work yet, because some of the databases has not yet been created

            //First get lists of all specs in the mongo database
            List<Case> caseList = _ComponentController._ComponentCaseController.GetAllCase();
            //List<CPU> cpuList = _ComponentController._ComponentCPUController.GetAllCPU();
            //List<GPU> gpuList = _ComponentController._ComponentGPUController.GetAllGPU();
            //List<HDD> hddList = _ComponentController._ComponentHDDController.GetAllHDD();
            //List<Motherboard> motherboardList = _ComponentController._ComponentMotherboardController.GetAllMotherboard();
            //List<PSU> psuList = _ComponentController._ComponentPSUController.GetAllPSU();
            //List<Ram> ramList = _ComponentController._ComponentRamController.GetAllRam();
            //List<SSD> ssdList = _ComponentController._ComponentSSDController.GetAllSSD();


            //Clear the current list
            TableList.Items.Clear();

            //Merge them into the table
            foreach (var _case in caseList)
            {
                TableList.Items.Add(_case);
            }



        }
    }
}
