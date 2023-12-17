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
    /// Interaction logic for Maze.xaml
    /// </summary>
    public partial class mazePage : Page
    {
        readonly MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        public mazePage()
        {
            InitializeComponent();
        }
        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.mainFrame.Navigate(new mainPage());
        }
        private void p2_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (p2_text.Text.Split(new string[] {","}, StringSplitOptions.RemoveEmptyEntries).Length == 2)
            {
                Point id = new Point();
                Point p1 = new Point();
                Point p2 = new Point();
                if (identifier_text.Text != string.Empty && p1_text.Text != string.Empty)
                {
                    int[] idp = identifier_text.Text.Split(',').Select(int.Parse).ToArray();
                    int[] p1p = p1_text.Text.Split(',').Select(int.Parse).ToArray();
                    int[] p2p = p2_text.Text.Split(',').Select(int.Parse).ToArray();

                    id = new Point(idp[0], idp[1]);
                    idp = null;
                    p1 = new Point(p1p[0], p1p[1]);
                    p1p = null;
                    p2 = new Point(p2p[0], p2p[1]);
                    p2p = null;


                }
            }
        }
    }
}
