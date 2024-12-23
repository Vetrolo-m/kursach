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
using System.Globalization;

namespace NumberSystemCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            string input = inputNumber.Text;
            int fromBase = Convert.ToInt32((inputBase.SelectedItem as ComboBoxItem).Content);
            int toBase = Convert.ToInt32((outputBase.SelectedItem as ComboBoxItem).Content);

            try
            {
                int decimalValue = Convert.ToInt32(input, fromBase);

                string result = Convert.ToString(decimalValue, toBase);

                outputNumber.Text = result.ToUpper();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}