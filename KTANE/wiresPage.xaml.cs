﻿using System;
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
    /// Interaction logic for wiresPage.xaml
    /// </summary>
    public partial class wiresPage : Page
    {
        readonly MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
        public wiresPage()
        {
            InitializeComponent();
        }
        private void back_button_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.mainFrame.Navigate(new mainPage());
        }
    }
}
