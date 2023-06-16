using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }

        private void btnRegistr_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (string.IsNullOrEmpty(tbFIO.Text))
                stringBuilder.AppendLine("Укажите ФИО");
            if (string.IsNullOrEmpty(tbLogin.Text))
                stringBuilder.AppendLine("Укажите Email");
            if (string.IsNullOrEmpty(tbPassword.Password))
                stringBuilder.AppendLine("Укажите пароль");

            bool isLetter = false;
            bool isDigit = false;
            bool isSymbol = false;
            char[] chars = { '!', '@', '#', '$', '%', '^' };

            foreach (var i in tbPassword.Password)
            {
                if (Char.IsLetter(i))
                    isLetter = true;
                if (Char.IsNumber(i))
                    isDigit = true;
                if (chars.Contains(i))
                    isSymbol = true;
            }

            if (EventsDemoEntities.GetContext().User.Any(a => a.Email == tbLogin.Text))
                stringBuilder.AppendLine("Такой логин уже существует");
            else if (!(tbPassword.Password.Length >= 6 && isLetter && isDigit && isSymbol))
                stringBuilder.AppendLine("Пароль не соответствует требованиям");

            if (stringBuilder.Length > 0)
            {
                MessageBox.Show(stringBuilder.ToString());
                return;
            }

            EventsDemoEntities.GetContext().User.Add(new User
            {
                FIO = tbFIO.Text,
                Email = tbLogin.Text,
                Password = tbPassword.Password,
                Phone = tbPhone.Text
            });
            EventsDemoEntities.GetContext().SaveChanges();
        }
    }
}
