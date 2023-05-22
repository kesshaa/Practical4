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

namespace Zadanie1
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
            int K =int.Parse(TbNumberA.Text);
            string description;
            switch (K)
            {
                case 1:
                    description = "плохо";
                    break;
                case 2:
                    description = "неудовлетворительно";
                    break;
                case 3:
                    description = "удовлетворительно";
                    break;
                case 4:
                    description = "хорошо";
                    break;
                case 5:
                    description = "отлично";
                    break;
                default:
                    description = "ошибка";
                    break;
            }
            TextBlockAnswer.Text=$"{description}";
        }
    }
}
