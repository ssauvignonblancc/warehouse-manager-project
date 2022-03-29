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
    /// Логика взаимодействия для DeletTechnics.xaml
    /// </summary>
    public partial class DeletTechnics : Window
    {
        public DeletTechnics()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select * from Техника", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            техникаDataGrid.ItemsSource = dt.AsDataView();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
          try
          {
                SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
                con.Open();
                DataTable dt = new DataTable();
                DataRowView row = (DataRowView)техникаDataGrid.SelectedItems[0];
                SqlCommand sql = new SqlCommand($"select Стоимость from Техника where Название='{row[1]}' and ВремяЗаписи='{row[3]}'", con);
                string price = Convert.ToString(sql.ExecuteScalar());
                SqlDataAdapter sda = new SqlDataAdapter($"Insert into ИсторияПоставок(Название,Стоимость,ВремяЗаписи, Поставщик, Количество) values ('{row[1]}','{price.ToString().Replace(',', '.')}','{row[3]}','{row[4]}', '{row[5]}') ", con);
                sda.Fill(dt);
                sda = new SqlDataAdapter($"Delete from Техника where IDТехника={row[0]}", con);
                sda.Fill(dt);
                техникаDataGrid.ItemsSource = dt.AsDataView();
            }
            catch (Exception) { MessageBox.Show("Выберете технику."); }


            SqlConnection con2 = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con2.Open();
            SqlDataAdapter sda2 = new SqlDataAdapter($"select * from Техника", con2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            техникаDataGrid.ItemsSource = dt2.AsDataView();

        }
    }
}


                    