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
    /// Логика взаимодействия для ListEmployee.xaml
    /// </summary>
    public partial class ListEmployee : Window
    {
        public ListEmployee()
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
            SqlDataAdapter sda = new SqlDataAdapter($"select * from Приемщик",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            приемщикDataGrid.ItemsSource = dt.AsDataView();
        }

        

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda = new SqlDataAdapter($"Select * from Приемщик where (IDПриемщик like '%{TextSearch.Text}%') or (ФИО like '%{TextSearch.Text}%') or (ВремяРаботы like '%{TextSearch.Text}%') or (Должность like '%{TextSearch.Text}%') or (СтажРаботы like '%{TextSearch.Text}%')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            приемщикDataGrid.ItemsSource = dt.AsDataView();
        }
    }
}
