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
    /// Логика взаимодействия для ysconys.xaml
    /// </summary>
    public partial class ysconys : Window
    {
        public ysconys()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox3.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            res();
        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox4.Text.Length >= 15)
            {
                MessageBox.Show("Переполнение данных", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                clear();
                return;
            }
            res();
        }
        private void clear()
        {
            label5.Visibility = Visibility.Hidden;
            label6.Visibility = Visibility.Hidden;
            label7.Visibility = Visibility.Hidden;
            label8.Visibility = Visibility.Hidden;
            label9.Visibility = Visibility.Hidden;
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
        private void res()
        {
           
            double r = 0, h = 0, l = 0, R = 0;
           
            clear();
           
            if (Double.TryParse(textBox1.Text, out R))
            {
                rascheti.schet3 vae = new rascheti.schet3(r, h, l, R);
                textBox5.Text = Convert.ToString(vae.val3());
            }
            else if (textBox1.Text == "")
            {
                label5.Visibility = Visibility.Visible;
            }
            else if (textBox1.Text != "" || textBox1.Text == "0." || textBox1.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                textBox5.Text = "";
            }


            if (Double.TryParse(textBox2.Text, out r))
            {
                rascheti.schet3 vae = new rascheti.schet3(r, h, l, R);
                textBox6.Text = Convert.ToString(vae.znk3());
            }
            else if (textBox2.Text == "")
            {
                label6.Visibility = Visibility.Visible;
            }
            else if (textBox2.Text != "" || textBox2.Text == "0." || textBox2.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                textBox6.Text = "";
            }


            if (Double.TryParse(textBox3.Text, out h))
            {
                if (Double.TryParse(textBox2.Text, out r) && Double.TryParse(textBox1.Text, out R))
                {
                    rascheti.schet3 vae = new rascheti.schet3(r, h, l, R);
                    textBox8.Text = Convert.ToString(vae.wef3());
                }
                else
                {
                    label8.Visibility = Visibility.Visible;
                }
            }
            else if (textBox3.Text == "")
            {
                label8.Visibility = Visibility.Visible;
            }
            else if (textBox3.Text != "" || textBox2.Text == "0." || textBox3.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                textBox8.Text = "";
            }

            if (Double.TryParse(textBox4.Text, out l))
            {
                if (Double.TryParse(textBox2.Text, out r) && Double.TryParse(textBox1.Text, out R))
                {
                    rascheti.schet3 vae = new rascheti.schet3(r, h, l, R);
                    textBox7.Text = Convert.ToString(vae.rgr3());
                    textBox9.Text = Convert.ToString(vae.egr3());
                }
                else
                {
                    label7.Visibility = Visibility.Visible;
                    label9.Visibility = Visibility.Visible;
                }
            }
            else if (textBox4.Text == "")
            {
                label7.Visibility = Visibility.Visible;
                label9.Visibility = Visibility.Visible;

            }
            else if (textBox3.Text != "" || textBox2.Text == "0." || textBox3.Text == "0,")
            {
                MessageBox.Show("Введите корректные данные", "Ерошкин Кирилл", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            else
            {
                textBox7.Text = "";
                textBox9.Text = "";

            }
        }

    }
}
