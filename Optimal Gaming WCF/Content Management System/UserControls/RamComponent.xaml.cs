using Optimal_Gaming_Class_Library.Control_Layer;
using Optimal_Gaming_Class_Library.Model_Layer;
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
    /// Interaction logic for RamComponent.xaml
    /// </summary>
    public partial class RamComponent : UserControl
    {

        ComponentController _ComponentController = new ComponentController();

        public RamComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a new Ram object to the database by the given infomation in the input text fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSpecButton(object sender, RoutedEventArgs e)
        {
            // Create size object from the text fields
            Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size size = new Optimal_Gaming_Class_Library.Model_Layer.Components.Details.Size(Convert.ToDouble(HeightText.Text), Convert.ToDouble(WidthText.Text), Convert.ToDouble(DepthText.Text), Convert.ToDouble(WeightText.Text));

            //Create a new Ram object
            Ram ram = new Ram(NameText.Text, Convert.ToDouble(PriceText.Text), BrandNameText.Text, size, Convert.ToInt32(CapacityText.Text), Convert.ToInt32(RamSticksText.Text), TechnologyText.Text, ModelText.Text, Convert.ToInt32(FrequencySpeedText.Text));

            //Add the create Ram object to the mongo database
            _ComponentController._ComponentRamController.AddToDatabase(ram);

        }
    }
}
