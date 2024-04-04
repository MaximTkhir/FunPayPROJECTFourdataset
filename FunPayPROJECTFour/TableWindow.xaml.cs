using FunPayPROJECTFour.LastChangeFourPrgFunPayDataSetTableAdapters;
using FunPayPROJECTFour;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
    /// Interaction logic for TableWindow.xaml
    /// </summary>
    public partial class TableWindow : Window
    {
        LastChangeBaseViewDataTableAdapter lastfun = new LastChangeBaseViewDataTableAdapter();
        public TableWindow()
        {
            InitializeComponent();
            AllInfa.ItemsSource = lastfun.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
