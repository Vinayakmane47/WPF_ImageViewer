using Microsoft.Win32;
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

namespace project2.view.usercontrols
{
    public partial class MenuBar : UserControl
    {
        // Event to notify subscribers when an image is selected
        public event Action<string> ImageSelected;

        public MenuBar()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open_file_dialog = new OpenFileDialog();
            open_file_dialog.Filter = "Image files|*.jpg;*.jpeg;*.png";
            open_file_dialog.FilterIndex = 1;
            if (open_file_dialog.ShowDialog() == true)
            {
                // Raise the event with the selected file path
                ImageSelected?.Invoke(open_file_dialog.FileName);
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)


        {

          MessageBoxResult result = MessageBox.Show("Do you want to exit ?","Close" , MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
