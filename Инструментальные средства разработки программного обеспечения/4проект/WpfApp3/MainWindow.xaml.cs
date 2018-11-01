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

namespace WpfApp3
{

    public partial class MainWindow : Window
    {
        public int rows = 10; // кол-во строк
        public char[,] buf = new char[10, 10];
        public string[,] bu1 = new string[11,10];// переменная для заполнения таблицы
        public DataTable dt = new DataTable(); // для заполнения таблицы
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < bu1.GetLength(0); i++)
            {

                string check = textbox1.Text.Split('\n')[i];
                for (int j = 0; j < check.Length; j++)
                  
                    buf[i, j] = check[j];
            }

            textbox1.Text = "";
            datagrid1.ItemsSource = DataGridInput(false).DefaultView;
            button1.IsEnabled = false;
            button.IsEnabled = true;
            buttondown.IsEnabled = true;
            button2.IsEnabled = false;
            buttonobn.IsEnabled = true;
        }
        
        public char[,] arr()
        {
            Random rand = new Random();
            char[,] ar = new char[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    ar[i, j] = (char)rand.Next(50, 93);
                }

            }
            return ar;
        }

        public DataTable DataGridInput(bool flag)
        {
            buf = flag ? arr() : buf;
            var rows = buf.GetLength(0);
            var columns = buf.GetLength(1);

            var t = new DataTable();
            for (var c = 0; c < columns; c++)
                t.Columns.Add(new DataColumn(c.ToString()));

            for (var r = 0; r < rows; r++)
            {
                var newRow = t.NewRow();
                for (var c = 0; c < columns; c++)
                    newRow[c] = buf[r, c];
                t.Rows.Add(newRow);
            }

            return t;
        }


        private void datagrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            {
                button1.IsEnabled = false;
                button2.IsEnabled = false;
                DataTable dt = new DataTable();
                dt = new DataTable();
                for (int i = 0; i < 10; i++)
                {
                    dt.Columns.Add((i + 1).ToString());
                }

                for (int i = 0; i < 10; i++)
                {
                    var nr = dt.NewRow();
                    for (int j = 0; j < 10; j++)
                    {
                        char ff;
                        ff = arr()[i, j];
                        nr[j] = ff;
                        buf[i, j] = ff;
                    }
                    dt.Rows.Add(nr);
                }
                datagrid1.ItemsSource = dt.DefaultView;
            }

        }
        public void zapolnenie(char[,] sss)
        {
            DataTable dt2 = new DataTable();
            dt2 = new DataTable();
            for (int i = 0; i < 10; i++)
            {
                dt2.Columns.Add((i + 1).ToString());
            }

            for (int i = 0; i < rows; i++)
            {
                var nr = dt2.NewRow();

                for (int j = 0; j < 10; j++)
                {

                    nr[j] = sss[i, j];
                }
                dt2.Rows.Add(nr);
            }
            datagrid1.ItemsSource = dt2.DefaultView;
        }
       
        private void button_Click(object sender, RoutedEventArgs e)
        {
            datagrid1.ItemsSource = null;

            for (int i = 0; i < buf.GetLength(0); i++)
            {
                for (int j = 0; j < buf.GetLength(1); j++)
                    textbox1.Text += buf[i, j].ToString();
                textbox1.Text += "\n";
            }


            buttonobn.IsEnabled = false;
            button1.IsEnabled = true;
            button.IsEnabled = false;
            buttondown.IsEnabled = false;
            button2.IsEnabled = false;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttondown_Click(object sender, RoutedEventArgs e)
        {
            {
                datagrid1.ItemsSource = null;

                for (int i = 0; i < buf.GetLength(0); i++)
                {
                    for (int j = 0; j < buf.GetLength(1); j++)
                        textbox2.Text += buf[j, i].ToString();
                    textbox2.Text += "\n";
                }
                buttonobn.IsEnabled = false;
                button1.IsEnabled = false;
                button.IsEnabled = false;
                buttondown.IsEnabled = false;
                button2.IsEnabled = true;
            }
        }

        private void buttonobn_Click(object sender, RoutedEventArgs e)
        {
            datagrid1.ItemsSource = DataGridInput(true).DefaultView;
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click_2(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < bu1.GetLength(0); i++)
            {

                string check = textbox2.Text.Split('\n')[i];
                for (int j = 0; j < check.Length; j++)

                    buf[j,i] = check[j];
            }

            textbox2.Text = "";
            datagrid1.ItemsSource = DataGridInput(false).DefaultView;
            button.IsEnabled = true;
            button1.IsEnabled = false;
            buttondown.IsEnabled = true;
            button2.IsEnabled = false;
            buttonobn.IsEnabled = true;
        }
    }
}
