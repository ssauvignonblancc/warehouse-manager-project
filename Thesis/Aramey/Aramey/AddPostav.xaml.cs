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
using System.Data.SqlClient;
using System.Data;

namespace Aramey
{
    /// <summary>
    /// Логика взаимодействия для AddPostav.xaml
    /// </summary>
    public partial class AddPostav : Window
    {
        public AddPostav()
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
            
            if (NamePostav.Text == "" || Vid.Text == "" || KolText.Text == "" || NumberTel.Text == "")
            {
                MessageBox.Show("Поля не заполнено.");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
                con.Open();
                SqlCommand sql = new SqlCommand($"select max(IDПоставщик) from Поставщик", con);
                sql = new SqlCommand($"insert into Поставщик (Название, ВидТехники, Адрес, НомерТелефона) values ('{NamePostav.Text}', '{Vid.Text}', '{KolText}', '{NumberTel.Text}')", con);
                sql.ExecuteNonQuery();
                MessageBox.Show("Поставщик добавлен.");
            }
        }

        private void Vid_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"Select Название From Техника", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                Vid.Items.Add(dr[0].ToString());
            }
        }
    }
}
