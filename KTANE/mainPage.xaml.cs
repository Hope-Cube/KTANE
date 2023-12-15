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

namespace KTANE
{
    /// <summary>
    /// Interaction logic for mainPage.xaml
    /// </summary>
    public partial class mainPage : Page
    {
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        public mainPage()
        {
            InitializeComponent();
        }
        private void wires_button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.mainFrame.Navigate(new wiresPage());
        }
    }
}
