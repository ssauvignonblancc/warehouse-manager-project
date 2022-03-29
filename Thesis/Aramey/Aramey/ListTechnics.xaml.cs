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
using System.Text.RegularExpressions;

namespace Aramey
{
    /// <summary>
    /// Логика взаимодействия для ListTechnics.xaml
    /// </summary>
    public partial class ListTechnics : Window
    {
        public ListTechnics()
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

        private void LoadBD_Copy_Click(object sender, RoutedEventArgs e)
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
            sda = new SqlDataAdapter($"Select * from Техника where (IDТехника like '%{TextSearch.Text}%') or (Название like '%{TextSearch.Text}%') or (Стоимость like '%{TextSearch.Text}%') or (ВремяЗаписи like '%{TextSearch.Text}%')", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            техникаDataGrid.ItemsSource = dt.AsDataView();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int countTech = 0;
          

            if (Regex.IsMatch(count.Text, @"[^0-9]"))
            {
                MessageBox.Show("Поле не заполнено.");
            }
            else
            {
                try
                {
                   countTech = Convert.ToInt32(count.Text);

                    

                    SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
                    con.Open();
                    DataTable dt = new DataTable();
                    DataRowView row = (DataRowView)техникаDataGrid.SelectedItems[0];
                    SqlCommand sql = new SqlCommand($"select Стоимость from Техника where Название='{row[1]}' and ВремяЗаписи='{row[3]}'", con);
                    string price = Convert.ToString(sql.ExecuteScalar());


                    if (Convert.ToInt32(row[5]) < countTech || countTech <= 0) {
                        MessageBox.Show("Число не удовлетворяет условию");
                            }

                    SqlDataAdapter sql2 = new SqlDataAdapter($"update Техника set Количество = Количество - '{countTech}' where ВремяЗаписи='{row[3]}' and Название='{row[1]}'", con);
                    sql2.Fill(dt);
                    техникаDataGrid.ItemsSource = dt.AsDataView();
                    SqlDataAdapter sda = new SqlDataAdapter($"Insert into Sold(Название,Стоимость,ВремяЗаписи, Поставщик, Количество) values ('{row[1]}','{price.ToString().Replace(',', '.')}','{row[3]}','{row[4]}', '{countTech}') ", con); sda.Fill(dt);
                }
                catch (Exception) { MessageBox.Show("Выберете технику."); }

                SqlConnection con2 = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
                con2.Open();
                SqlDataAdapter sda2 = new SqlDataAdapter();
                sda2 = new SqlDataAdapter($"Select * from Техника where (IDТехника like '%{TextSearch.Text}%') or (Название like '%{TextSearch.Text}%') or (Стоимость like '%{TextSearch.Text}%') or (ВремяЗаписи like '%{TextSearch.Text}%')", con2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                техникаDataGrid.ItemsSource = dt2.AsDataView();
            }
        }
    }
    }
