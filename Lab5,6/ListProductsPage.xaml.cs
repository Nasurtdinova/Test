using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Lab5_6
{
    /// <summary>
    /// Логика взаимодействия для ListProducts.xaml
    /// </summary>
    public partial class ListProducts : Page
    {
        public static List<Product> storage { get; set; }
        public ListProducts()
        {
            InitializeComponent();
            storage = Product.GetProducts();
            this.DataContext = this;
        }
    }
}
