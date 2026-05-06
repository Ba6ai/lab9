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

namespace WPFprog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    private void Button_Click(object  sender, RoutedEventArgs e)
    {
        string text = textBox1.Text;
        if (text != " ")
        {
            MessageBox.Show(text);
        }
    }
    private void textBox1_TExtChanged(object sender, TextChangedEventArgs e)
    {
        string text = textBox1.Text;
        if (text != "no")
        {
            MessageBox.Show("Зачем ты так?)");
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}