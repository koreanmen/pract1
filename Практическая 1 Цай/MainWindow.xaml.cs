using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib_11;

namespace Практическая_1_Цай
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool f2;
            f2 = Int32.TryParse(tbv.Text, out int n);
            if (f2)
            {
                string s = "";
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(0, n);
                    s += x + " ";
                }
                tbs.Text = s;
                Class1.Mult(n, s, out float mult);
                Class1.Dif(n, s, out float dif);
                Class1.Sum(n, s, out float sum);
                tbr.Text ="Произведение чисел = " + mult.ToString() + "\r\nРазность чисел = " + dif.ToString() + "\r\nСумма чисел = " + sum.ToString();
            }
            else MessageBox.Show("Введите верные значения","Ошибка",MessageBoxButton.OK);
        }

        private void MenuItem_inf(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Цай Владислав, ИСП-31, Практическая 1, Вариант-11 \nНайти произведение n целых случайных чисел X., распределенных в диапазоне от 0 до n. \r\nВывести на экран на одной строке сгенерированные числа, на другой строке результат.","Информация",MessageBoxButton.OK);
        }

        private void MenuItem_Clear(object sender, RoutedEventArgs e)
        {
            tbr.Clear();
            tbs.Clear();
            tbv.Clear();
        }

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tbv_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbr.Clear();
            tbs.Clear();
        }
    }
}