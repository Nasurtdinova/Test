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
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public int count { get; set; }
        public Random rnd = new Random();
        public string Captcha { get; set; }

        public AuthorizationPage()
        {
            InitializeComponent();
            tbLogin.Text = Properties.Settings.Default.Login;
            tbPassword.Password = Properties.Settings.Default.Password;
            Update();
        }

        public void Update()
        {
            spSymbols.Children.Clear();
            cvNoise.Children.Clear();
            Captcha = null;
            UpdateCaptcha();
            UpdateNoise();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var currentUser = EventsDemoEntities.GetContext().User.ToList().Where(a => a.Email == tbLogin.Text && a.Password == tbPassword.Password).FirstOrDefault();
            StringBuilder stringBuilder = new StringBuilder();

            if (DateTime.Now - Properties.Settings.Default.DateAuth >= new TimeSpan(0, 0, 10))
            {
                if (string.IsNullOrEmpty(tbCaptcha.Text) || tbCaptcha.Text != Captcha)
                    stringBuilder.AppendLine("Капча не правильная!");
                if (currentUser == null)
                    stringBuilder.AppendLine("Пароль или логин не правильный!");

                if (stringBuilder.Length > 0)
                {
                    Update();
                    count++;
                    MessageBox.Show(stringBuilder.ToString());
                    if (count == 3)
                    {
                        Properties.Settings.Default.DateAuth = DateTime.Now;
                        Properties.Settings.Default.Save();
                        count = 0;
                        MessageBox.Show("Вы заблокированы на 10 секунд!");
                    }
                    return;
                }
                else
                {
                    MainWindow.CurrentUser = currentUser;

                    if (cbRemember.IsChecked == true)
                    {
                        Properties.Settings.Default.Login = currentUser.Email;
                        Properties.Settings.Default.Password = currentUser.Password;
                        Properties.Settings.Default.Save();
                    }
                    NavigationService.Navigate(new AdminPage());
                }              
            }                  
        }

        public void UpdateCaptcha()
        {
            string alphabet = "QWERTYUIOPASDFGHJKLMNBVCXZ123456789!@#$%^&*";
            for (int i = 0; i < 4; i++)
            {
                string symbol = alphabet.ElementAt(rnd.Next(0, alphabet.Length)).ToString();
                Captcha += symbol;
                TextBlock tb = new TextBlock();
                tb.Text = symbol;
                tb.RenderTransform = new RotateTransform(rnd.Next(-45, 45));
                tb.Margin = new Thickness(10, 10, 10, 10);
                tb.FontSize = rnd.Next(35, 85);
                spSymbols.Children.Add(tb);
            }
        }

        public void UpdateNoise()
        {
            for (int i = 0; i < 4; i++)
            {
                Ellipse tb = new Ellipse();
                tb.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256)));
                tb.Width = tb.Height = rnd.Next(15, 45);
                cvNoise.Children.Add(tb);
                Canvas.SetLeft(tb, rnd.Next(10, 100));
            }
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }
}
