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
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Aramey
{
    /// <summary>
    /// Логика взаимодействия для HistoryTechnics.xaml
    /// </summary>
    public partial class HistoryTechnics : Window
    {
        public HistoryTechnics()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select * from ИсторияПоставок", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            историяПоставокDataGrid.ItemsSource = dt.AsDataView();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select * from ИсторияПоставок where ВремяЗаписи >= '{H_picker.SelectedDate}' and ВремяЗаписи <= '{H_picker.SelectedDate.Value.AddMonths(3)}'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            историяПоставокDataGrid.ItemsSource = dt.AsDataView();
        }
    }
}
