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

namespace Zadanie3
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
           
            int elementNumber = int.Parse(TbNumberA.Text);

            
            double elementValue = double.Parse(TbNumberB.Text);

            double a = 0, c = 0, h = 0, s = 0;

            switch (elementNumber)
            {
                case 1: // катет a
                    a = elementValue;
                    c = a * Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    break;
                case 2: // гипотенуза c
                    c = elementValue;
                    a = c / Math.Sqrt(2);
                    h = c / 2;
                    s = c * h / 2;
                    break;
                case 3: // высота h
                    h = elementValue;
                    c = h * 2;
                    a = c / Math.Sqrt(2);
                    s = c * h / 2;
                    break;
                case 4: // площадь S
                    s = elementValue;
                    c = Math.Sqrt(s * 2);
                    h = c / 2;
                    a = c / Math.Sqrt(2);
                    break;
                default:
                    TextBlockAnswer.Text = "Некорректный номер элемента";
                    return;
            }

            TextBlockAnswer.Text = $"Катет a: {a:f2} \n Гипотенуза c: { c} \n Высота h: { h} \n Площадь S: {s}";

          
        }
    }
}
