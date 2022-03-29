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
    /// Логика взаимодействия для DeletePostav.xaml
    /// </summary>
    public partial class DeletePostav : Window
    {
        public DeletePostav()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select * from Поставщик", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            поставщикDataGrid.ItemsSource = dt.AsDataView();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
                con.Open();
                DataTable dt = new DataTable();
                DataRowView row = (DataRowView)поставщикDataGrid.SelectedItems[0];
                SqlDataAdapter sda = new SqlDataAdapter($"Delete from Поставщик where IDПоставщик='{row[0]}'", con);
                sda.Fill(dt);
                поставщикDataGrid.ItemsSource = dt.AsDataView();
            }
            catch (Exception) { MessageBox.Show("Выберите поставщика."); }

            SqlConnection con2 = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con2.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter($"select * from Поставщик", con2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            поставщикDataGrid.ItemsSource = dt2.AsDataView();

        }
    }
}
