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
    /// Interaction logic for PSUComponent.xaml
    /// </summary>
    public partial class PSUComponent : UserControl
    {
        ComponentController _ComponentController = new ComponentController();

        public PSUComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a new PSU object to the mongo database by the given infomation in the input textfields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSpecButton(object sender, RoutedEventArgs e)
        {
            // Create size object from the text inputs
            Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size size = new Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size(Convert.ToDouble(HeightText.Text), Convert.ToDouble(WidthText.Text), Convert.ToDouble(DepthText.Text), Convert.ToDouble(WeightText.Text));

            //split the text field that will end up as string arrays
            string[] powerOutlets = PowerOutletsText.Text.Split(',');

            //Create a new PSU object from the inputs in the text fields
            PSU psu = new PSU(NameText.Text, Convert.ToDouble(PriceText.Text), BrandNameText.Text, size, FormFactorText.Text, powerOutlets, Convert.ToInt32(Watt.Text), ModularCheckbox.IsChecked.GetValueOrDefault());

            //Add the created PSU to the mongo database
            _ComponentController._ComponentPSUController.AddToDatbase(psu);
        }
    }
}
