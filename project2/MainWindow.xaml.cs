using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace project2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Find the MenuBar control and subscribe to the ImageSelected event
            MenuBarControl.ImageSelected += MenuBarControl_ImageSelected;
        }

        private void MenuBarControl_ImageSelected(string filePath)
        {
            // Create a BitmapImage and set it as the source of the main Image control
            var image = new BitmapImage(new Uri(filePath));
            MainImage.Source = image;
        }
    }
}