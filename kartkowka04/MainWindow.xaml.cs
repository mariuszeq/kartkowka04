using System.Diagnostics.Eventing.Reader;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kartkowka04
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
            string liczba = liczba1_box.Text;
            string liczba2 = liczba2_box.Text;

            int l1;
            int l2;
            float a = 7;
            float b = 3;
            int wynik = 0;

            if (int_radio.IsChecked == true)
            {

            if (int.TryParse(liczba1_box.Text, out l1)
                && int.TryParse(liczba2_box.Text, out l2))
            {
                if (l2 != 0)
                {
                    int wynikus = 0;
                    wynikus = l1 / l2;
                    MessageBox.Show(wynikus.ToString());
                }
                else
                {
                    MessageBox.Show("liczba nie moze byc rowna 0");
                }
            }
            else
            {
                MessageBox.Show("wpisz liczbe");
            }
            }





            else if (float_radio.IsChecked == true)
            {


                string f_liczba = liczba1_box.Text;
                string f_liczba2 = liczba2_box.Text;


                float float_l1;
                float float_l2;
                float wyniczek = 0;


                if (float.TryParse(liczba1_box.Text, out float_l1)
                && float.TryParse(liczba2_box.Text, out float_l2))
                {
                    if (float_l2 != 0)
                    {

                        wyniczek = float_l1 / float_l2;
                        MessageBox.Show(wyniczek.ToString());

                    }
                    else
                    {
                        MessageBox.Show("liczba nie moze byc rowna 0");
                    }
                }
                else
                {
                    MessageBox.Show("wpisz liczbe");
                }
            }
        }
    }
}