using Lab5_6;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Wpf
{
    public partial class BuingPage : Page
    {
        public Product product { get; set; }
        public static List<TypeOfPayment> list { get; set; }
        public static List<MethodOfObtaining> list1 { get; set; }
        public static string delivery { get; set; }

        public BuingPage(Product prod)
        {
            InitializeComponent();
            product = prod;
            list = TypeOfPayment.GetTypeOfPayment().ToList(); 
            typePayment.ItemsSource = list;
            list1 = MethodOfObtaining.GetMethodOfObtaining().ToList();
            methodDelivery.ItemsSource = list1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void methodDelivery_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ComboBox).SelectedItem as MethodOfObtaining;
            delivery = a.Name;
            if (a.Name == "доставка" || a.Name == "срочная доставка")
            {
                tblockStreet.Visibility = Visibility.Visible;
                tblockHome.Visibility = Visibility.Visible;
                tbStreet.Visibility = Visibility.Visible;
                tbHome.Visibility = Visibility.Visible;
            }
            else
            {
                tblockStreet.Visibility = Visibility.Hidden;
                tblockHome.Visibility = Visibility.Hidden;
                tbStreet.Visibility = Visibility.Hidden;
                tbHome.Visibility = Visibility.Hidden;
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (delivery == "доставка" || delivery == "срочная доставка")
            {
                if (string.IsNullOrEmpty(tbStreet.Text) || string.IsNullOrEmpty(tbHome.Text))
                {
                    MessageBox.Show("Данные не заполнены");
                }
            }

            else if (string.IsNullOrEmpty(tbCount.Text) || string.IsNullOrEmpty(tbSurname.Text) || string.IsNullOrEmpty(tbName.Text)
                || string.IsNullOrEmpty(tbPatronymic.Text) || string.IsNullOrEmpty(tbPhone.Text) || string.IsNullOrEmpty(methodDelivery.Text.ToString())
                || string.IsNullOrEmpty(typePayment.Text.ToString()))
            {
                MessageBox.Show("Данные не заполнены");
            }
            else if (product.Count < Convert.ToInt32(tbCount.Text))
            {
                MessageBox.Show("Не в наличии");
            }
            else
            {
                MessageBox.Show("Покупка совершена");
            }
        }
    }
}
