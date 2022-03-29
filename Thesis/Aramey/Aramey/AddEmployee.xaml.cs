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
    /// Логика взаимодействия для AddEmployee.xaml
    /// </summary> 418-002
    public partial class AddEmployee : Window
    {
        public AddEmployee()
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
            if (Name.Text == "" || Dol.Text == "" || Staj.Text == "")
            {
                MessageBox.Show("Не все поля заполнены.");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
                con.Open();
                SqlCommand sql = new SqlCommand($"select max(IDПриемщик) from Приемщик", con);
                sql = new SqlCommand($"insert into Приемщик (ФИО, ВремяРаботы, Должность, СтажРаботы) values ('{Name.Text}','{Time.Text}','{Dol.Text}','{Staj.Text}')", con);
                sql.ExecuteNonQuery();
                MessageBox.Show("Работник добавлен.");
            }
        }
    }
}
