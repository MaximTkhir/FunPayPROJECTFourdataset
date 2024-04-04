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
    public partial class ClientsWindow : Window
    {
        private readonly ClientsTableAdapter clientsTableAdapter;
        private DataTable clientInfoTable;

        public ClientsWindow()
        {
            InitializeComponent();
            clientsTableAdapter = new ClientsTableAdapter();
            RefreshData();
        }

        private void RefreshData()
        {
            ClientsDataGrid.ItemsSource = clientsTableAdapter.GetData();
            comboBox.ItemsSource = clientsTableAdapter.GetData().AsEnumerable().Select(row => row.Field<string>("ClientFirstName")).Distinct().ToList();
        }

        private void ButtonBackClient_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = SearchTextBox.Text;
            DataTable searchResult = clientsTableAdapter.GetDataByfilterfirstnameclients(keyword);
            ClientsDataGrid.ItemsSource = searchResult.DefaultView;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem != null)
            {
                string selectedValue = comboBox.SelectedItem.ToString();
                clientInfoTable = clientsTableAdapter.GetDataByfilterfirstnameclients(selectedValue);
                ClientsDataGrid.ItemsSource = clientInfoTable.DefaultView;

                ClientsDataGrid.ItemsSource = clientInfoTable.AsDataView();
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            comboBox.SelectedItem = null;
            ClientsDataGrid.ItemsSource = clientsTableAdapter.GetData();
            clientInfoTable = null;
        }
    }
}
