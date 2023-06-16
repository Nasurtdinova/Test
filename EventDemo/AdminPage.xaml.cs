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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            if (MainWindow.CurrentUser != null)
            {
                if (DateTime.Now.TimeOfDay >= new TimeSpan(9, 0, 0) && DateTime.Now.TimeOfDay <= new TimeSpan(11, 0, 0))
                    tbHello.Text = $"Доброе утро {MainWindow.CurrentUser.FIO}";
                else if (DateTime.Now.TimeOfDay >= new TimeSpan(11, 1, 0) && DateTime.Now.TimeOfDay <= new TimeSpan(18, 0, 0))
                    tbHello.Text = $"Добрый день {MainWindow.CurrentUser.FIO}";
                else if (DateTime.Now.TimeOfDay >= new TimeSpan(18, 1, 0) && DateTime.Now.TimeOfDay <= new TimeSpan(24, 0, 0))
                    tbHello.Text = $"Добрый вечер {MainWindow.CurrentUser.FIO}";
            }
        }

        private void btnMyProfile_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProfilePage());
        }
    }
}
