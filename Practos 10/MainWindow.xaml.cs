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

namespace Practos_10
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
        List<int> list = new List<int>();

        private void calculation_button(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(valueList.Text, out int value))
            {
                list.Add(value);
                listBox1.Items.Add(value);
            }
            else
            {
                MessageBox.Show("");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            if (listBox1.Items.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 3 == 0)
                    {
                      sum += list[i] ;
                    }

                }
            }
            number.Text = sum.ToString();
        }
    }
}
