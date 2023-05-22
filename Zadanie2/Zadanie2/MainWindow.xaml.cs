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

namespace Zadanie2
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
            int age = int.Parse(TbNumberA.Text);
            if (age >= 20 && age <= 69)
            {
                int units = age % 10; // единицы возраста
                int tens = age / 10; // десятки возраста
                string tensWord = ""; // слово для десятков возраста
                string unitsWord = ""; // слово для единиц возраста

                // определяем слово для десятков возраста
                switch (tens)
                {
                    case 2:
                        tensWord = "двадцать";
                        break;
                    case 3:
                        tensWord = "тридцать";
                        break;
                    case 4:
                        tensWord = "сорок";
                        break;
                    case 5:
                        tensWord = "пятьдесят";
                        break;
                    case 6:
                        tensWord = "шестьдесят";
                        break;
                }

                // определяем слово для единиц возраста
                switch (units)
                {
                    case 1:
                        unitsWord = "один";
                        break;
                    case 2:
                        unitsWord = "два";
                        break;
                    case 3:
                        unitsWord = "три";
                        break;
                    case 4:
                        unitsWord = "четыре";
                        break;
                    case 5:
                        unitsWord = "пять";
                        break;
                    case 6:
                        unitsWord = "шесть";
                        break;
                    case 7:
                        unitsWord = "семь";
                        break;
                    case 8:
                        unitsWord = "восемь";
                        break;
                    case 9:
                        unitsWord = "девять";
                        break;
                }

                // определяем слово "год", "года" или "лет"
                string unitsEnding = "";
                if (units >= 2 && units <= 4)
                {
                    unitsEnding = "года";
                }
                else if (units == 1)
                {
                    unitsEnding = "год";
                }
                else
                {
                    unitsEnding = "лет";
                }

                // создаем строку-описание возраста
                string ageDescription = "";
                if (tensWord == "")
                {
                    ageDescription = $"{unitsWord} {unitsEnding}";
                }
                else if (units == 0)
                {
                    ageDescription = $"{tensWord} лет";
                }
                else
                {
                    ageDescription = $"{tensWord} {unitsWord} {unitsEnding}";
                }

                TextBlockAnswer.Text = $"{ageDescription}";
            }
            else
            {
                TextBlockAnswer.Text = "Возраст не входит в диапазон от 20 до 69 лет";
            }
        }

    }
    
}
