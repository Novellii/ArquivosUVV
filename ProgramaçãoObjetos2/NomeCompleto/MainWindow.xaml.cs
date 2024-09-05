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

namespace NomeCompleto
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxName.Text == String.Empty || TextBoxSobrenome.Text == String.Empty) {
                ButtonNS.Text = "SEM NOME";
            }
            else
            {
                ButtonNS.Text = $"{TextBoxName.Text} {TextBoxSobrenome.Text}";
            }
        }
    }
}