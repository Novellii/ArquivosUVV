using System.ComponentModel;
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
using tapoxa.Classes;

namespace tapoxa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<Capivaras> listCapivaras = new BindingList<Capivaras>();
        public MainWindow()
        {
            InitializeComponent();
            GridCapivaras.ItemsSource = listCapivaras;
        }

        private void ClicarBotão(object sender, RoutedEventArgs e)
        {
            Capivaras cp = new Capivaras(Nome.Text, int.Parse(Idade.Text), float.Parse(Peso.Text));
            listCapivaras.Add(cp);
        }
    }
}