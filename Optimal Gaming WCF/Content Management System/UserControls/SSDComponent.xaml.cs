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
    /// Interaction logic for SSDComponent.xaml
    /// </summary>
    public partial class SSDComponent : UserControl
    {

        ComponentController _ComponentController = new ComponentController();

        public SSDComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a new SSD object to the mongo database by the given information in the input text fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSpecButton(object sender, RoutedEventArgs e)
        {
            //Create size object from the text inputs
            Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size size = new Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size(Convert.ToDouble(HeightText.Text), Convert.ToDouble(WidthText.Text), Convert.ToDouble(DepthText.Text), Convert.ToDouble(WeightText.Text));

            //Split the text field that will end up as string arrays
            string[] _interface = InterfaceText.Text.Split(',');
            string[] features = FeaturesText.Text.Split(',');

            //Create a new SSD object from the input in the text fields
            SSD ssd = new SSD(NameText.Text, Convert.ToDouble(PriceText.Text), BrandNameText.Text, size, Convert.ToInt32(StorageSizeText.Text), ModelSizeText.Text, _interface, Convert.ToInt32(BufferSizeText.Text), features, Convert.ToInt32(ReadSpeedText.Text), Convert.ToInt32(WriteSpeedText.Text), Convert.ToInt32(ExpectedLifeTimeText.Text), Convert.ToDouble(PowerConsumptionUnderLoad.Text));

            //Add the new SSD object to the mongo database
            _ComponentController._ComponentSSDController.AddToDatabase(ssd);
        }
    }
}
