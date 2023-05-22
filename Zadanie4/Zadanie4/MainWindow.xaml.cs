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

namespace Zadanie4
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
           
            int a = int.Parse(TbNumberA.Text);

           
            int b = int.Parse(TbNumberB.Text);

            int count = 0;
            while (a >= b)
            {
                a -= b;
                count++;
            }

         TextBlockAnswer.Text = $"Количество отрезков B, размещенных на отрезке A: {count}";
        }
    }
}
