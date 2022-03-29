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
using Excel = Microsoft.Office.Interop.Excel;

namespace Aramey
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListTechnics listTechnics = new ListTechnics();
            listTechnics.Show();
            Close();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DeletTechnics deletTechnics = new DeletTechnics();
            deletTechnics.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddTechnics addTechnics = new AddTechnics();
            addTechnics.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ListEmployee listEmployee = new ListEmployee();
            listEmployee.Show();
            Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
            Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DeletEmployee deletEmployee = new DeletEmployee();
            deletEmployee.Show();
            Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            HistoryTechnics historyTechnics = new HistoryTechnics();
            historyTechnics.Show();
            Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ListPostav listPostav = new ListPostav();
            listPostav.Show();
            Close();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            AddPostav addPostav = new AddPostav();
            addPostav.Show();
            Close();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            DeletePostav deletePostav = new DeletePostav();
            deletePostav.Show();
            Close();
        }



        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            Otchet otchet = new Otchet();
            otchet.Show();
            Close();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            Sold sold = new Sold();
            sold.Show();
            Close();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
          System.Diagnostics.Process.Start(@"Справка.docx");
        }
    }

}
