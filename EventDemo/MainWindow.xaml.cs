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

namespace EventDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static User CurrentUser { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.NavigationService.Navigate(new MainPage());
            mainFrame.Navigated += MainFrame_Navigated; 
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            var content = mainFrame.Content as Page;

            tbName.Text = content.Title;

            if (CurrentUser == null)
                btnExit.Visibility = Visibility.Collapsed;
            else
                btnExit.Visibility = Visibility.Visible;

            if (content is AdminPage || mainFrame.CanGoBack)
                btnBack.Visibility = Visibility.Collapsed;
            else
                btnBack.Visibility = Visibility.Visible;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (mainFrame.CanGoBack)
                mainFrame.GoBack();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {          
            CurrentUser = null;
            mainFrame.NavigationService.Navigate(new MainPage());           
        }
    }
}
