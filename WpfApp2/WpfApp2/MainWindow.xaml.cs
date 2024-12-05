
using System.Windows;


namespace WpfApp2
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window2 = new Window2();
            Window2.ShowDialog();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Window1 Window1 = new Window1();
            Window1.ShowDialog();
        }
    }
}
