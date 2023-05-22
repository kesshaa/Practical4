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

namespace Zadanie8Dop
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

            string description = "";

            int hundreds = n / 100; // количество сотен
            int tens = (n / 10) % 10; // количество десятков
            int ones = n % 10; // количество единиц

            switch (hundreds)
            {
                case 1:
                    description += "сто ";
                    break;
                case 2:
                    description += "двести ";
                    break;
                case 3:
                    description += "триста ";
                    break;
                case 4:
                    description += "четыреста ";
                    break;
                case 5:
                    description += "пятьсот ";
                    break;
                case 6:
                    description += "шестьсот ";
                    break;
                case 7:
                    description += "семьсот ";
                    break;
                case 8:
                    description += "восемьсот ";
                    break;
                case 9:
                    description += "девятьсот ";
                    break;
            }

            if (tens == 1) // для чисел от 10 до 19
            {
                switch (ones)
                {
                    case 0:
                        description += "десять";
                        break;
                    case 1:
                        description += "одиннадцать";
                        break;
                    case 2:
                        description += "двенадцать";
                        break;
                    case 3:
                        description += "тринадцать";
                        break;
                    case 4:
                        description += "четырнадцать";
                        break;
                    case 5:
                        description += "пятнадцать";
                        break;
                    case 6:
                        description += "шестнадцать";
                        break;
                    case 7:
                        description += "семнадцать";
                        break;
                    case 8:
                        description += "восемнадцать";
                        break;
                    case 9:
                        description += "девятнадцать";
                        break;
                }
            }
            else // для чисел от 20 до 99
            {
                switch (tens)
                {
                    case 2:
                        description += "двадцать ";
                        break;
                    case 3:
                        description += "тридцать ";
                        break;
                    case 4:
                        description += "сорок ";
                        break;
                    case 5:
                        description += "пятьдесят ";
                        break;
                    case 6:
                        description += "шестьдесят ";
                        break;
                    case 7:
                        description += "семьдесят ";
                        break;
                    case 8:
                        description += "восемьдесят ";
                        break;
                    case 9:
                        description += "девяносто ";
                        break;
                }

                switch (ones)
                {
                    case 1:
                        description += "один";
                        break;
                    case 2:
                        description += "два";
                        break;
                    case 3:
                        description += "три";
                        break;
                    case 4:
                        description += "четыре";
                        break;
                    case 5:
                        description += "пять";
                        break;
                    case 6:
                        description += "шесть";
                        break;
                    case 7:
                        description += "семь";
                        break;
                    case 8:
                        description += "восемь";
                        break;
                    case 9:
                        description += "девять";
                        break;
                }
            }

            TextBlockAnswer.Text = $"{description}";
        }
    }
}
