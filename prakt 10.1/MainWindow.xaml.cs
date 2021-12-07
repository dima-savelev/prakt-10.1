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

namespace prakt_10._1
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
        List<int> list = new List<int>();
        private void Add(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(addValue.Text, out int value) && value >= -100 && value <= 100)
            {
                list.Add(value);
                listBox.Items.Add(value);
            }
            else MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            addValue.Clear();
            outEven.Clear();
            outOdd.Clear();
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            int counterEven = 0;
            int counterOdd = 0;
            if (listBox.Items.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        counterEven++;
                    }
                    if (list[i] % 2 != 0)
                    {
                        counterOdd++;
                    }
                }
                outEven.Text = counterEven.ToString();
                outOdd.Text = counterOdd.ToString();
            }
            else MessageBox.Show("Введите значения в таблицу", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Савельев Дмитрий Александрович В13\nПрактическая работа №10\nДан массив в диапазоне [-100;100] найти количество четных и нечетных.", "Информация о программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            list.Clear();
            listBox.Items.Clear();
            addValue.Clear();
            outEven.Clear();
            outOdd.Clear();
        }
    }
}
