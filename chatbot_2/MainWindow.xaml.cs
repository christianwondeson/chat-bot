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

namespace chatbot_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();  //this method is used to drag the window by left click
            }

        }

        private void Button_minimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState =WindowState.Minimized;//used to minimize our windows app
        }

        private void Button_max_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)//check condition if windows is not maximized
            {
                Application.Current.MainWindow.WindowState = WindowState.Maximized; // maximze the window displayed 
            }
            else
            {
                Application.Current.MainWindow.WindowState = WindowState.Normal; // normalze when pressed again
            }
        }

        private void Button_exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown(); //to shutdown current displayed window
        }
    }
}
