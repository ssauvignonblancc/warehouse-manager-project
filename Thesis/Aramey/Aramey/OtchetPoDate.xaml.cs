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
using Excel = Microsoft.Office.Interop.Excel;

namespace Aramey
{
    /// <summary>
    /// Логика взаимодействия для OtchetPoDate.xaml
    /// </summary>
    public partial class OtchetPoDate : Window
    {
        public OtchetPoDate()
        {
            InitializeComponent();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter($"select * from Техника", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            техникаDataGrid.ItemsSource = dt.AsDataView();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Otchet otchet = new Otchet();
            otchet.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DataRowView dataRow;
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            string path = @"C:\Users\ssauvignonblancc\Desktop\Диплом ОСНОВА\Отчет за период.xlsx";
            excelApp.Workbooks.Open(path);
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;
            int allCount = техникаDataGrid.Items.Count;

            for (int i = 0; i < 150; i++)
            {
                workSheet.Cells[i + 3, "A"] = "";
                workSheet.Cells[i + 3, "B"] = "";
                workSheet.Cells[i + 3, "C"] = "";
                workSheet.Cells[i + 3, "D"] = "";
                workSheet.Cells[i + 3, "E"] = "";
            }

            workSheet.Cells[1, "A"] = $"Отчет на {DateTime.Now}";
            workSheet.Cells[2, "A"] = $"Название техники";
            workSheet.Cells[2, "B"] = $"Стоимость техники, руб";
            workSheet.Cells[2, "C"] = $"Время записи";
            workSheet.Cells[2, "D"] = $"Поставщик";
            workSheet.Cells[2, "E"] = $"Количество, штук";

            for (int i = 0; i < allCount - 1; i++)
            {
                dataRow = техникаDataGrid.Items[i] as DataRowView;
                workSheet.Cells[i + 3, "A"] = dataRow[0];
                workSheet.Cells[i + 3, "B"] = dataRow[1];
                workSheet.Cells[i + 3, "C"] = dataRow[2];
                workSheet.Cells[i + 3, "D"] = dataRow[3].ToString();
                workSheet.Cells[i + 3, "E"] = dataRow[4];
            }
            excelApp.Workbooks.Close();
            MessageBox.Show("Отчет создан.");
        }

        private void one_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            if (two.SelectedDate == null)
            {
                sda = new SqlDataAdapter($"select Название,Стоимость,ВремяЗаписи, Поставщик, Количество From Техника where ВремяЗаписи>='{one.SelectedDate}'", con);
            }
            else
            {
                sda = new SqlDataAdapter($"select Название,Стоимость,ВремяЗаписи, Поставщик, Количество From Техника where ВремяЗаписи>='{one.SelectedDate}' and ВремяЗаписи<='{two.SelectedDate}'", con);
            }
            sda.Fill(dt);
            техникаDataGrid.ItemsSource = dt.AsDataView();
        }

        private void two_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=HOME-PC;Initial Catalog=Арамей;Integrated Security=True");
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter();
            if (one.SelectedDate == null)
            {
                sda = new SqlDataAdapter($"select Название,Стоимость,ВремяЗаписи, Поставщик, Количество From Техника where ВремяЗаписи>='{two.SelectedDate}'", con);
            }
            else
            {
                sda = new SqlDataAdapter($"select Название,Стоимость,ВремяЗаписи, Поставщик, Количество From Техника where ВремяЗаписи>='{one.SelectedDate}' and ВремяЗаписи<='{two.SelectedDate}'", con);
            }
            sda.Fill(dt);
            техникаDataGrid.ItemsSource = dt.AsDataView();

        }
    }
}
