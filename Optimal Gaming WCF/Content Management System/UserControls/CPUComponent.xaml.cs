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
    /// Interaction logic for CPUComponent.xaml
    /// </summary>
    public partial class CPUComponent : UserControl
    {
        private ComponentController _ComponentController = new ComponentController();

        public CPUComponent()
        {
            InitializeComponent();
        }

        private void AddSpecButton(object sender, RoutedEventArgs e)
        {
            //Split the text field that will end up as string arrays
            string[] compatibleSockets = CompatibleSocketsText.Text.Split(',');
            string[] compatibleChipsets = CompatibleChipsetsText.Text.Split(',');

            //Create new CP object from the text inputs
            CPU cpu = new CPU(NameText.Text, Convert.ToDouble(PriceText.Text), BrandNameText.Text, Convert.ToInt32(CoresText.Text), Convert.ToInt32(ThreadsText.Text), Convert.ToInt32(CacheText.Text), Convert.ToDouble(ClockFrequenceText.Text), Convert.ToDouble(TurboFrequenceText.Text), compatibleChipsets, compatibleChipsets, Convert.ToInt32(ProductionProcessText.Text), DesignDetailsText.Text, FunctionalititesText.Text, IntegrateddGraphicsText.Text);

            //Create the new CPU in mongo database
            _ComponentController._ComponentCPUController.AddToDatabase(cpu);
        }
    }
}
