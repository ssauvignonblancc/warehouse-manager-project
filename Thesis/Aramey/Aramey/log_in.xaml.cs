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
    /// Логика взаимодействия для log_in.xaml
    /// </summary>
    public partial class log_in : Window
    {
      
        public log_in()
        {
            InitializeComponent();
        }

        private void log_in_load_Click(object sender, RoutedEventArgs e)
        {
            var loginUser = text_box_login.Text;
            var passUser = text_box_password.Password;

            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id_user, login_user, password_user from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, con);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButton.OK);
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
               // this.Hide();
               // mainWindow.ShowDialog();
                //this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунт не существует!", MessageBoxButton.OK);
        }

    }
}
