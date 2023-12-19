using AStarPath;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using Color = System.Drawing.Color;

namespace KTANE
{
    /// <summary>
    /// Interaction logic for Maze.xaml
    /// </summary>
    public partial class mazePage : Page
    {
        int cn = 0;
        System.Drawing.Point id;
        System.Drawing.Point p1;
        System.Drawing.Point p2;
        readonly MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        public mazePage()
        {
            InitializeComponent();
            CheckBoxUnenable();
        }
        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.mainFrame.Navigate(new mainPage());
        }
        private void CheckBoxUnenable()
        {
            null_two.IsEnabled = false;
            null_five.IsEnabled = false;

            one_one.IsEnabled = false;
            one_three.IsEnabled = false;
            one_five.IsEnabled = false;

            two_null.IsEnabled = false;
            two_one.IsEnabled = false;
            two_two.IsEnabled = false;
            two_three.IsEnabled = false;

            three_four.IsEnabled = false;

            four_one.IsEnabled = false;
            four_three.IsEnabled = false;
            four_four.IsEnabled = false;
            four_five.IsEnabled = false;

            five_null.IsEnabled = false;
            five_two.IsEnabled = false;
            five_four.IsEnabled = false;
            five_five.IsEnabled = false;
        }
        private void CheckBoxEnable()
        {
            null_two.IsEnabled =true;
            null_five.IsEnabled =true;

            one_one.IsEnabled =true;
            one_three.IsEnabled =true;
            one_five.IsEnabled =true;

            two_null.IsEnabled =true;
            two_one.IsEnabled =true;
            two_two.IsEnabled =true;
            two_three.IsEnabled =true;

            three_four.IsEnabled =true;

            four_one.IsEnabled =true;
            four_three.IsEnabled =true;
            four_four.IsEnabled =true;
            four_five.IsEnabled =true;

            five_null.IsEnabled =true;
            five_two.IsEnabled =true;
            five_four.IsEnabled =true;
            five_five.IsEnabled =true;
        }
        private void Checked_CheckBox(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (cn == 0)
            {
                id = GetPoint(checkBox.Name);
                // Convert System.Drawing.Color to System.Windows.Media.Color
                Color c = Color.FromArgb(0, 255, 0);
                System.Windows.Media.Color wpfColor = System.Windows.Media.Color.FromArgb(
                    c.A, c.R, c.G, c.B);
                SolidColorBrush borderBrush = new SolidColorBrush(wpfColor);

                // Set the BorderBrush property of the CheckBox to the new SolidColorBrush
                checkBox.BorderBrush = borderBrush;
                checkBox.IsChecked = false;
                CheckBoxEnable();
                cn++;
            }
            else if (cn == 1)
            {
                p1 = GetPoint(checkBox.Name);
                cn++;
            }
            else
            {
                p2 = GetPoint(checkBox.Name);
                direction_display.Text = AStar.Path(id, p1, p2);
            }
        }
        private static System.Drawing.Point GetPoint(string name)
        {
            string[] name_fregs = name.Split('_');
            System.Drawing.Point result;
            switch (name_fregs[0])
            {
                case "null":
                    result = name_fregs[1] == "null" ? new System.Drawing.Point(0, 0) :
                             name_fregs[1] == "one" ? new System.Drawing.Point(0, 1) :
                             name_fregs[1] == "two" ? new System.Drawing.Point(0, 2) :
                             name_fregs[1] == "three" ? new System.Drawing.Point(0, 3) :
                             name_fregs[1] == "four" ? new System.Drawing.Point(0, 4) :
                             name_fregs[1] == "five" ? new System.Drawing.Point(0, 5) :
                             new System.Drawing.Point();
                    break;
                case "one":
                    result = name_fregs[1] == "null" ? new System.Drawing.Point(1, 0) :
                             name_fregs[1] == "one" ? new System.Drawing.Point(1, 1) :
                             name_fregs[1] == "two" ? new System.Drawing.Point(1, 2) :
                             name_fregs[1] == "three" ? new System.Drawing.Point(1, 3) :
                             name_fregs[1] == "four" ? new System.Drawing.Point(1, 4) :
                             name_fregs[1] == "five" ? new System.Drawing.Point(1, 5) :
                             new System.Drawing.Point();
                    break;
                case "two":
                    result = name_fregs[1] == "null" ? new System.Drawing.Point(2, 0) :
                             name_fregs[1] == "one" ? new System.Drawing.Point(2, 1) :
                             name_fregs[1] == "two" ? new System.Drawing.Point(2, 2) :
                             name_fregs[1] == "three" ? new System.Drawing.Point(2, 3) :
                             name_fregs[1] == "four" ? new System.Drawing.Point(2, 4) :
                             name_fregs[1] == "five" ? new System.Drawing.Point(2, 5) :
                             new System.Drawing.Point();
                    break;
                case "three":
                    result = name_fregs[1] == "null" ? new System.Drawing.Point(3, 0) :
                             name_fregs[1] == "one" ? new System.Drawing.Point(3, 1) :
                             name_fregs[1] == "two" ? new System.Drawing.Point(3, 2) :
                             name_fregs[1] == "three" ? new System.Drawing.Point(3, 3) :
                             name_fregs[1] == "four" ? new System.Drawing.Point(3, 4) :
                             name_fregs[1] == "five" ? new System.Drawing.Point(3, 5) :
                             new System.Drawing.Point();
                    break;
                case "four":
                    result = name_fregs[1] == "null" ? new System.Drawing.Point(4, 0) :
                             name_fregs[1] == "one" ? new System.Drawing.Point(4, 1) :
                             name_fregs[1] == "two" ? new System.Drawing.Point(4, 2) :
                             name_fregs[1] == "three" ? new System.Drawing.Point(4, 3) :
                             name_fregs[1] == "four" ? new System.Drawing.Point(4, 4) :
                             name_fregs[1] == "five" ? new System.Drawing.Point(4, 5) :
                             new System.Drawing.Point();
                    break;
                case "five":
                    result = name_fregs[1] == "null" ? new System.Drawing.Point(5, 0) :
                             name_fregs[1] == "one" ? new System.Drawing.Point(5, 1) :
                             name_fregs[1] == "two" ? new System.Drawing.Point(5, 2) :
                             name_fregs[1] == "three" ? new System.Drawing.Point(5, 3) :
                             name_fregs[1] == "four" ? new System.Drawing.Point(5, 4) :
                             name_fregs[1] == "five" ? new System.Drawing.Point(5, 5) :
                             new System.Drawing.Point();
                    break;
                default:
                    result = new System.Drawing.Point();
                    break;
            }
            return result;
        }
    }
}
