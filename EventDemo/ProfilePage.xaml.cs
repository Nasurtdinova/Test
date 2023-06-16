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
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void cbVisiblePassword_Checked(object sender, RoutedEventArgs e)
        {
            if (cbVisiblePassword.IsChecked == true)
            {
                tbPassword.Visibility = Visibility.Visible;
                tbConfirmPassword.Visibility = Visibility.Visible;

                tbPassword.Text = pbPassword.Password;
                tbConfirmPassword.Text = pbConfirmPassword.Password;
                
                pbPassword.Visibility = Visibility.Collapsed;
                pbConfirmPassword.Visibility = Visibility.Collapsed;
            }   
            else
            {
                tbPassword.Visibility = Visibility.Collapsed;
                tbConfirmPassword.Visibility = Visibility.Collapsed;

                pbPassword.Password =  tbPassword.Text;
                pbConfirmPassword.Password = tbConfirmPassword.Text;

                pbPassword.Visibility = Visibility.Visible;
                pbConfirmPassword.Visibility = Visibility.Visible;
            }
        }
    }
}
