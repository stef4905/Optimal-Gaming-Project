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
    /// Interaction logic for MotherboardComponent.xaml
    /// </summary>
    public partial class MotherboardComponent : UserControl
    {

        ComponentController _ComponentController = new ComponentController();

        public MotherboardComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a new 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSpecButton(object sender, RoutedEventArgs e)
        {
            //Create size object from the text inputs
            Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size size = new Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size(Convert.ToDouble(HeightText.Text), Convert.ToDouble(WidthText.Text), Convert.ToDouble(DepthText.Text), Convert.ToDouble(WeightText.Text));

            //Split the text field tha will end up as string arrays
            string[] expansionsOpenings = ExpansionsOpeningsText.Text.Split(',');
            string[] storageInterface = StorageInterfaceText.Text.Split(',');
            string[] _interface = InterfaceText.Text.Split(',');
            string[] internInterface = InternInterfaceText.Text.Split(',');
            string[] powerAdaptor = PowerAdaptorText.Text.Split(',');
            string[] ramBusClock = RamBusClockText.Text.Split(',');

            //Create a new Motherboard object with the inputs in the text fields
            Motherboard motherboard = new Motherboard(NameText.Text, Convert.ToDouble(PriceText.Text), BrandNameText.Text, size, FormFactorText.Text, ChipsetText.Text, ProcessorSocketText.Text, RamTechnologyText.Text, Convert.ToInt32(MaxSupportedRamText.Text), ramBusClock, Convert.ToInt32(RamSlots.Text), AudioTypeText.Text, AudioCodecText.Text, NetworkInterfaceText.Text, expansionsOpenings, storageInterface, _interface, internInterface, powerAdaptor, BiosTypeText.Text);

            //Add the created Motherboard object to the mongo database
            _ComponentController._ComponentMotherboardController.AddToDatabase(motherboard);

        }
    }
}
