
using Content_Management_System.UserControls;
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
    /// Interaction logic for AddSpec.xaml
    /// </summary>
    public partial class AddSpec : UserControl
    {
        public AddSpec()
        {
            InitializeComponent();
        }

        private void OpenTemplateButton(object sender, RoutedEventArgs e)
        {
            SpecGrid.Children.Clear();
            // 0 = case, 1 = cpu, 2 = gpu, 3 = hdd, 4 = ssd, 5 = ram, 6 = motherboard, 7 = psu
            if (Combo.SelectedIndex == 0)
            {
                SpecGrid.Children.Add(new CaseComponent());
            }
            else if (Combo.SelectedIndex == 1)
            {
                SpecGrid.Children.Add(new CPUComponent());
            }
            else if (Combo.SelectedIndex == 2)
            {
                SpecGrid.Children.Add(new GPUComponent());
            }
            else if (Combo.SelectedIndex == 3)
            {
                SpecGrid.Children.Add(new HDDcomponent());
            }
            else if (Combo.SelectedIndex == 4)
            {
                SpecGrid.Children.Add(new SSDComponent());
            }
            else if (Combo.SelectedIndex == 5)
            {
                SpecGrid.Children.Add(new RamComponent());
            }
            else if (Combo.SelectedIndex == 6)
            {
                SpecGrid.Children.Add(new MotherboardComponent());
            }
            else if (Combo.SelectedIndex == 7)
            {
                SpecGrid.Children.Add(new PSUComponent());
            }
            else
            {
                Console.WriteLine("The number was not found or was higher than 7. The number was: " + Combo.SelectedIndex);
            }
        }
    }
}
