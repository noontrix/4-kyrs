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
    /// Логика взаимодействия для chilindr.xaml
    /// </summary>
    public partial class chilindr : Window
    {
        public chilindr()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            ypr();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            ypr();
        }
        private void clear()
        {
            label3.Visibility = Visibility.Hidden;
            label4.Visibility = Visibility.Hidden;
            label5.Visibility = Visibility.Hidden;
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void ypr()
        {
           
            double r = 0, h = 0;
            clear();
            if (!(Double.TryParse(textBox.Text, out r) || textBox.Text == ""))
            {
                MessageBox.Show("Введите корректные данные1", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
           
            if (Double.TryParse(textBox1.Text, out h))
            {
                if (Double.TryParse(textBox.Text, out r))
                {
                    rascheti.schet1 valel = new rascheti.schet1(r, h);
                    textBox2.Text = Convert.ToString(valel.val1());
                    textBox3.Text = Convert.ToString(valel.znk1());
                    textBox4.Text = Convert.ToString(valel.wer());
                }
                else
                {
                    label3.Visibility = Visibility.Visible;
                    label4.Visibility = Visibility.Visible;
                    label5.Visibility = Visibility.Visible;
                }

            }
            else if (textBox1.Text == "")
            {
                label3.Visibility = Visibility.Visible;
                label4.Visibility = Visibility.Visible;
                label5.Visibility = Visibility.Visible;
            }
            else if (textBox1.Text != "" || textBox1.Text == "0." || textBox1.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }



        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
