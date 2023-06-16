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
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            dgEvents.ItemsSource = EventsDemoEntities.GetContext().Event.ToList();
            var type = EventsDemoEntities.GetContext().TypeEvent.ToList();
            type.Insert(0, new TypeEvent {  Name = "Все типы"});
            comboType.ItemsSource = type;
            comboType.SelectedIndex = 0;
        }

        public void UpdateList()
        {
            var list = EventsDemoEntities.GetContext().Event.ToList();
            if (dpEvent.SelectedDate != null)
                list = list.Where(a => a.DateStart == dpEvent.SelectedDate).ToList();
            if (comboType.SelectedIndex > 0)
                list = list.Where(a=>a.TypeEvent == comboType.SelectedItem as TypeEvent).ToList();

            dgEvents.ItemsSource = list;
        }

        private void btnView_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAuth_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }

        private void comboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }

        private void dpEvent_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateList();
        }
    }
}
