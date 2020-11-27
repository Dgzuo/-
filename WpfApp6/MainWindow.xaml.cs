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

namespace WpfApp6
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

        private void gift_Click(object sender, RoutedEventArgs e)
        {
            //1,34,12,56,1,36,668,213,67,-8,45
            int[] arr = new int[14];

            Random r = new Random();

            string natch = "Нач: " ; 
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 14);
                natch += arr[i] + ", ";
            }

            for(int i = 0; i < arr.Length / 2 - 1; i++)
            {
                for (int j = i; j < arr.Length / 2 - 1; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int a = arr[j];
                        arr[j] = arr[i];
                        arr[i] = a;
                    }
                }
            }

            for (int i = arr.Length / 2 ; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int a = arr[j];
                        arr[j] = arr[i];
                        arr[i] = a;
                    }
                }
            }

            string res = "Конец сортировки: ";

            foreach (int i in arr)
            {
                res += i + ", ";
            }
            floor.Content = natch + "\n" + res;
        }
    }
}
