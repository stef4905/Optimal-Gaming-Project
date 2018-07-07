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
    /// Interaction logic for GPUComponent.xaml
    /// </summary>
    public partial class GPUComponent : UserControl
    {

        ComponentController _ComponentController = new ComponentController();

        public GPUComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add a new gpu objec to the mongo database by the given infomation in the text fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSpecButton(object sender, RoutedEventArgs e)
        {
            // Create a size object
            Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size size = new Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size(Convert.ToDouble(HeightText.Text), Convert.ToDouble(WidthText.Text), Convert.ToDouble(DepthText.Text), Convert.ToDouble(WeightText.Text));

            //Split the text field that will en up as string arrays
            string[] _interface = InterfaceText.Text.Split(',');
            string[] apiCompability = APICompabilityText.Text.Split(',');
            string[] features = FeaturesText.Text.Split(',');
            string[] systemRequirements = SystemRequirementsText.Text.Split(',');



            //Create a new GPU object from the input in the text fields
            GPU gpu = new GPU(NameText.Text, Convert.ToDouble(PriceText.Text), BrandNameText.Text, size, BusTypeText.Text, Convert.ToDouble(KernelClockFrequenceText.Text), Convert.ToDouble(BoostClockFrequenceText.Text), VRReadyCheckbox.IsChecked.GetValueOrDefault(), _interface, apiCompability, features, Convert.ToDouble(VramSizeText.Text), VramTechnologyText.Text, Convert.ToDouble(VRamClockSpeedText.Text), VramBusText.Text, systemRequirements, Convert.ToInt32(PowerConsumptionText.Text));

            //Add to the mongo database
            _ComponentController._ComponentGPUController.AddToDatabase(gpu);
        }
    }
}
