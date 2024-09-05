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

namespace _29_08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int contador { get; set; }
        public MainWindow()
        {
            this.contador = 0;
            InitializeComponent();
        }

        private void ButtonContador_Click(object sender, RoutedEventArgs e)
        {
            contador++;
            LabelContador.Content = contador.ToString();
        }
    }
}