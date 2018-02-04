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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();

        }
        string a = null;
        decimal wynik = 0, drugi = 0;

        private void wcisniecie(object sender, KeyEventArgs e)
        {
            
        }

        private void wcisnieciep(object sender, KeyEventArgs e)
        {
            char b = textBox.Text.Last();

            a += b;


            if (a != null)
            {
                if (a.Last() == '+')
                {
                    a = a.Remove(a.Length - 1, 1);
                    wynik += Convert.ToDecimal(a);
                    a = null;
                    //MessageBox.Show("pierwszy=" + pierwszy.ToString());
                }
            }
            if (a != null)
            {
                if (a.Last() == '=')
                {
                    a = a.Remove(a.Length - 1, 1);
                    drugi = Convert.ToDecimal(a);

                    MessageBox.Show((wynik + drugi).ToString());
                }
            }
        }

        private void textBox_TextChanged(object sender, KeyEventArgs e)
        {
            
        }

        
    }
}
