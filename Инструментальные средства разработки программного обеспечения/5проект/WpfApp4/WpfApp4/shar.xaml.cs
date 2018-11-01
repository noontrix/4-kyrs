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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для shar.xaml
    /// </summary>
    public partial class shar : Window
    {
        public shar()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double r = 0;
            if (textbox1.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Переполнение", MessageBoxButton.OK, MessageBoxImage.Error);
                textbox2.Text = "";
                textbox3.Text = "";
                return;
            }
            if (double.TryParse(textbox1.Text, out r))
            {
                rascheti.schet vale = new rascheti.schet(r);
                textbox2.Text = "";
                textbox2.Text = Convert.ToString(vale.val());
                textbox3.Text = "";
                textbox3.Text = Convert.ToString(vale.znk());

            }
            else if (textbox1.Text != "" || textbox1.Text == "0." || textbox1.Text == "0,")
            {

                MessageBox.Show("Введите корректные данные");
                textbox2.Text = "";
                textbox3.Text = "";
            }
            else
            {
                textbox2.Text = "";
                textbox3.Text = "";
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
