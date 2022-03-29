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
using System.Data;
using System.Data.SqlClient;

namespace Aramey
{
    /// <summary>
    /// Логика взаимодействия для ListPostav.xaml
    /// </summary>
    public partial class ListPostav : Window
    {
        public ListPostav()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=418-002;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select * from Поставщик", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            поставщикDataGrid.ItemsSource = dt.AsDataView();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda = new SqlDataAdapter($"Select * from Поставщик where (IDПоставщик like '%{TextSearch.Text}%') or (Название like '%{TextSearch.Text}%')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            поставщикDataGrid.ItemsSource = dt.AsDataView();
        }

       /* private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=418-002;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            SqlCommand sqlCommand = new SqlCommand($"Select max (НомерТелефона) from Поставщик",con);
            SqlDataAdapter sda = new SqlDataAdapter($"Select * from Поставщик where НомерТелефона = '{(int)sqlCommand.ExecuteScalar()}'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            поставщикDataGrid.ItemsSource = dt.AsDataView();
        }*/

        private void Window_MouseLeave(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"Select * from Поставщик", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            поставщикDataGrid.ItemsSource = dt.AsDataView();
        }
    }
}
