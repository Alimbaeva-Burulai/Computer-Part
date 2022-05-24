using Computer_2ndTry.Model;
using Computer_2ndTry.ViewModel;
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
using System.Windows.Shapes;

namespace Computer_2ndTry
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public EditWindow(ComputerPart part)
        {
            InitializeComponent();
            EditViewModel vm = new EditViewModel();
            vm.Setup(part);
            this.DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string first = idbox.Text.Substring(0, 2);
            string second = idbox.Text.Substring(2, 2);
            string third = idbox.Text.Substring(4, 2);
            if (first.All(char.IsDigit)==false || second.All(char.IsDigit)==true || third.All(char.IsDigit)==false || idbox.Text.Length >6)
            {
                MessageBox.Show("Given id is wrong format. Please fix it");
            }
            else 
            {
                this.DialogResult = true;
            }
        }
    }
}
