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

namespace Zadanie6
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

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
           
            int n = int.Parse(TbNumberA.Text);

            int count = 0; // количество цифр
            int sum = 0; // сумма цифр

            while (n > 0)
            {
                int digit = n % 10; // выделяем последнюю цифру
                count++; // увеличиваем количество цифр
                sum += digit; // увеличиваем сумму цифр
                n /= 10; // удаляем последнюю цифру
            }

           TextBlockAnswer.Text = $"Количество цифр: {count}    Сумма цифр: {sum}";
        
        }
    }
}
