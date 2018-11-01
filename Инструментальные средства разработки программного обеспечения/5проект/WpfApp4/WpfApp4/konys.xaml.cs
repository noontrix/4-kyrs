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
    /// Логика взаимодействия для konys.xaml
    /// </summary>
    public partial class konys : Window
    {
        public konys()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox2.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            res();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            res();

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox1.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            res();
        }
        private void clear()
        {
            label3.Visibility = Visibility.Hidden;
            label4.Visibility = Visibility.Hidden;
            label5.Visibility = Visibility.Hidden;
            label6.Visibility = Visibility.Hidden;
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
        private void res()
        {
            double r = 0, h = 0, l = 0;
            clear();

            if (Double.TryParse(textBox.Text, out r))
            {
                rascheti.schet2 valel = new rascheti.schet2(r, h, l);
                textBox3.Text = Convert.ToString(valel.val2());
            }
            else if (textBox.Text == "")
            {
                label3.Visibility = Visibility.Visible;
            }
            else if (textBox.Text != "" || textBox.Text == "0." || textBox.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {

                textBox3.Text = "";
            }
            if (Double.TryParse(textBox1.Text, out h))
            {
                if (Double.TryParse(textBox.Text, out r) && Double.TryParse(textBox1.Text, out h))
                {
                    rascheti.schet2 valel = new rascheti.schet2(r, h, l);
                    textBox6.Text = Convert.ToString(valel.znk2());
                }
                else if (textBox.Text == "" || textBox1.Text == "")
                {
                    label6.Visibility = Visibility.Visible;
                }
            }
            else if (textBox1.Text == "")
            {
                label6.Visibility = Visibility.Visible;
            }
            else if (textBox1.Text != "" || textBox1.Text == "0." || textBox1.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (Double.TryParse(textBox2.Text, out l))
            {
                if (Double.TryParse(textBox.Text, out r) && Double.TryParse(textBox2.Text, out l))
                {
                    rascheti.schet2 valel = new rascheti.schet2(r, h, l);
                    textBox4.Text = Convert.ToString(valel.wef());
                    textBox5.Text = Convert.ToString(valel.rgr());
                }
                else if (textBox.Text == "" || textBox2.Text == "")
                {
                    label4.Visibility = Visibility.Visible;
                    label5.Visibility = Visibility.Visible;
                }
            }
            else if (textBox2.Text == "")
            {
                label4.Visibility = Visibility.Visible;
                label5.Visibility = Visibility.Visible;
            }
            else if (textBox2.Text != "" || textBox2.Text == "0." || textBox2.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void textBox6_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
