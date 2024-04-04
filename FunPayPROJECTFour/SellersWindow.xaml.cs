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
    /// Interaction logic for SellersWindow.xaml
    /// </summary>
    public partial class SellersWindow : Window
    {
        private readonly SellersTableAdapter sellersTableAdapter;
        public SellersWindow()
        {
            InitializeComponent();
            sellersTableAdapter = new SellersTableAdapter();
            RefreshData();
        }

        private void RefreshData()
        {
            SellersDataGrid.ItemsSource = sellersTableAdapter.GetData();
        }
        private void ButtonBackSellers_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = SearchTextBox.Text;
            DataTable searchResult = sellersTableAdapter.GetDataBySellerEmailS(keyword);
            SellersDataGrid.ItemsSource = searchResult.DefaultView;
        }

    }
}
