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
    /// Логика взаимодействия для AddEventPage.xaml
    /// </summary>
    public partial class AddEventPage : Page
    {
        public AddEventPage()
        {
            InitializeComponent();
            comboCity.ItemsSource = EventsDemoEntities.GetContext().City.ToList();
        }

        private void comboCity_TextChanged(object sender, TextChangedEventArgs e)
        {
            comboCity.ItemsSource = EventsDemoEntities.GetContext().City.ToList().Where(a => a.Name == comboCity.Text);
            comboCity.IsDropDownOpen = true;
        }
    }
}
