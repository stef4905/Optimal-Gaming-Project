
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
                
            }
            else if (Combo.SelectedIndex == 2)
            {

            }
            else if (Combo.SelectedIndex == 3)
            {

            }
            else if (Combo.SelectedIndex == 4)
            {

            }
            else if (Combo.SelectedIndex == 5)
            {

            }
            else if (Combo.SelectedIndex == 6)
            {

            }
            else if (Combo.SelectedIndex == 7)
            {

            }
            else
            {
                Console.WriteLine("The number was not found or was higher than 7. The number was: " + Combo.SelectedIndex);
            }
        }
    }
}
