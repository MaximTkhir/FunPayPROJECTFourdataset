using FunPayPROJECTFour.LastChangeFourPrgFunPayDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace FunPayPROJECTFour
{
    /// <summary>
    /// Interaction logic for ReviewsWindow.xaml
    /// </summary>
    public partial class ReviewsWindow : Window
    {
        private readonly ReviewsTableAdapter reviewsTableAdapter;
        public ReviewsWindow()
        {
            InitializeComponent();
            reviewsTableAdapter = new ReviewsTableAdapter();
            RefreshData();
        }

        private void RefreshData()
        {
            ReviewsDataGrid.ItemsSource = reviewsTableAdapter.GetData();
        }

        private void ButtonBackReviews_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }


        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(SearchTextBox.Text, out int keyword))
            {
                DataTable searchResult = reviewsTableAdapter.GetDataBySellerRating(keyword);
                ReviewsDataGrid.ItemsSource = searchResult.DefaultView;
            }
            else
            {
                MessageBox.Show("Введите число в поле поиска.");
            }
        }
    }
}