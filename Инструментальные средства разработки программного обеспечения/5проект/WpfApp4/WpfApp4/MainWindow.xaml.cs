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

namespace WpfApp4
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

        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            shar sf = new shar();
            sf.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            chilindr cli = new chilindr();
            cli.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            konys kon = new konys();
            kon.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ysconys kons = new ysconys();
            kons.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
