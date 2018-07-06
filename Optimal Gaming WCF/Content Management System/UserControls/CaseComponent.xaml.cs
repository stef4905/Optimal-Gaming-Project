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

namespace Content_Management_System.UserControls
{
    /// <summary>
    /// Interaction logic for CaseComponent.xaml
    /// </summary>
    public partial class CaseComponent : UserControl
    {

        private ComponentController _ComponentController = new ComponentController();

        public CaseComponent()
        {
            InitializeComponent();
        }

        private void AddSpecButton(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Doing the stuff");
            // Create size object from the text inputs
            Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size size = new Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size(Convert.ToDouble(HeightText.Text), Convert.ToDouble(WidthText.Text), Convert.ToDouble(DepthText.Text), Convert.ToDouble(WeightText.Text));
            NameText.Text = "2";

            //Split the text field that will end up as string arrays
            string[] compatibleMotherboards = CompatibleMotherboardsText.Text.Split(',');
            string[] material = MaterialText.Text.Split(',');
            string[] cooling = CoolingText.Text.Split(',');
            string[] storageExpansion = StorageExpantionText.Text.Split(',');
            string[] _interface = InterfaceText.Text.Split(',');

            // Create new Case object from the text inputs
            Case _case = new Case(NameText.Text, Convert.ToDouble(PriceText.Text), BrandNameText.Text, size, ModelText.Text, compatibleMotherboards, material, cooling, Convert.ToInt32(MaxCPUCoolerHeightText.Text), Convert.ToInt32(MaxGPULengthText.Text), storageExpansion, _interface);

            //Create the new case in mongo database
            _ComponentController._ComponentCaseController.AddToDatabase(_case);
            Console.WriteLine("Case has been added to the database");


        }
    }
}
