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
    /// Логика взаимодействия для AddTechnics.xaml
    /// </summary>
    public partial class AddTechnics : Window
    {
        public AddTechnics()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void Add_Click_1(object sender, RoutedEventArgs e)
        {
            if (NameTech.Text == "" || PriceTech.Text == "" || TimeTech.Text == "" || CountTech.Text == "")
            {
                MessageBox.Show("Не все поля заполнены.");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
                con.Open();
                SqlCommand sql = new SqlCommand($"select max(IDТехника) from Техника", con);
                sql = new SqlCommand($"insert into Техника (Название,Стоимость,ВремяЗаписи, Поставщик, Количество) values ('{NameTech.Text}','{PriceTech.Text}','{TimeTech.Text}','{listPostav.SelectedItem}', '{CountTech.Text}')", con);
                sql.ExecuteNonQuery();
                MessageBox.Show("Техника добавлена.");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter($"select Название from Поставщик", con);
            sda.Fill(dt);
            foreach(DataRow item in dt.Rows)
            {
                listPostav.Items.Add(item[0].ToString());
            }
        }
    }
}


