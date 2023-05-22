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

namespace Zadanie5
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
           
            double p = double.Parse(TbNumberA.Text);

            double distance = 10; // длина пробега в первый день
            double totalDistance = 10; // суммарный пробег

            int days = 1; // количество дней

            while (totalDistance <= 200)
            {
                distance *= 1 + p / 100; // увеличиваем длину пробега на P процентов
                totalDistance += distance; // увеличиваем суммарный пробег на длину пробега текущего дня
                days++; // увеличиваем количество дней
            }

            TextBlockAnswer.Text = $"После {days} дней суммарный пробег лыжника составит {totalDistance:f2} км";
        }
    }
}
