using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    public partial class ProductsPage : Page
    {
        public static List<Product> storage { get; set; }
        private GridViewColumnHeader listViewSortCol = null;
        private SortAdorner listViewSortAdorner = null;
        public ProductsPage()
        {
            InitializeComponent();
            storage = Product.GetProducts().ToList();
			lvUsers.ItemsSource = storage;

			var typeMan = Manufacturer.GetManufacturer();
			typeMan.Insert(0, new Manufacturer { Name = "Все производители" });
			manFilter.ItemsSource = typeMan;
			manFilter.SelectedIndex = 0;

			UpdateProdusts();
		}

		private void UpdateProdusts()
        {
			storage = Product.GetProducts().ToList(); 
			if (manFilter.SelectedIndex > 0)
            {
				storage = storage.Where(p => p.IdManufacturer == (manFilter.SelectedItem as Manufacturer).Id).ToList();
            }
			storage = storage.Where(p => p.Name.ToLower().Contains(txtSearch.Text.ToLower()) || p.Description.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
			lvUsers.ItemsSource = storage.ToList();
		}

		private void txtSearch_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
		{
			UpdateProdusts();
		}

		private void lvUsersColumnHeader_Click(object sender, RoutedEventArgs e)
		{
			GridViewColumnHeader column = (sender as GridViewColumnHeader);
			string sortBy = column.Tag.ToString();
			if (listViewSortCol != null)
			{
				AdornerLayer.GetAdornerLayer(listViewSortCol).Remove(listViewSortAdorner);
				lvUsers.Items.SortDescriptions.Clear();
			}

			ListSortDirection newDir = ListSortDirection.Ascending;
			if (listViewSortCol == column && listViewSortAdorner.Direction == newDir)
				newDir = ListSortDirection.Descending;

			listViewSortCol = column;
			listViewSortAdorner = new SortAdorner(listViewSortCol, newDir);
			AdornerLayer.GetAdornerLayer(listViewSortCol).Add(listViewSortAdorner);
			lvUsers.Items.SortDescriptions.Add(new SortDescription(sortBy, newDir));
		}

        private void manFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			UpdateProdusts();
		}

        private void lvUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
			var a = (sender as ListView).SelectedItem as Product;
			NavigationService.Navigate(new BuingPage(a));
        }
    }
    public class SortAdorner : Adorner
	{
		private static Geometry ascGeometry =
			Geometry.Parse("M 0 4 L 3.5 0 L 7 4 Z");

		private static Geometry descGeometry =
			Geometry.Parse("M 0 0 L 3.5 4 L 7 0 Z");

		public ListSortDirection Direction { get; private set; }

		public SortAdorner(UIElement element, ListSortDirection dir)
			: base(element)
		{
			this.Direction = dir;
		}

		protected override void OnRender(DrawingContext drawingContext)
		{
			base.OnRender(drawingContext);

			if (AdornedElement.RenderSize.Width < 20)
				return;

			TranslateTransform transform = new TranslateTransform
				(
					AdornedElement.RenderSize.Width - 15,
					(AdornedElement.RenderSize.Height - 5) / 2
				);
			drawingContext.PushTransform(transform);

			Geometry geometry = ascGeometry;
			if (this.Direction == ListSortDirection.Descending)
				geometry = descGeometry;
			drawingContext.DrawGeometry(Brushes.Black, null, geometry);

			drawingContext.Pop();
		}
	}
}
