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
using FunPayPROJECTFour.LastChangeFourPrgFunPayDataSetTableAdapters;

namespace FunPayPROJECTFour
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LastChangeBaseViewDataTableAdapter lastfun = new LastChangeBaseViewDataTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }



        private void ShowFullTable_Click(object sender, RoutedEventArgs e)
        {
            TableWindow tableWindow = new TableWindow();
            tableWindow.Show();
            this.Close();
        }

        private void ShowClients_Click(object sender, RoutedEventArgs e)
        {
             ClientsWindow clientsWindow = new ClientsWindow();
            clientsWindow.Show();
            this.Close();
        }

        private void ShowReviews_Click(object sender, RoutedEventArgs e)
        {
            ReviewsWindow reviewsWindow = new ReviewsWindow();
            reviewsWindow.Show();
            this.Close();
        }

        private void ShowSellers_Click(object sender, RoutedEventArgs e)
        {
            SellersWindow sellersWindow = new SellersWindow();
            sellersWindow.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            SearchWindow searchWindow = new SearchWindow();
            searchWindow.Show();
            this.Close();
        }
    }
}
