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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public string Name { get; set; }
        public int Numb { get; set; }
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e, TextBox textBox)
        {
            Name = textBox.Text;
        }

        private void TextBox1_TextChanged1(object sender, TextChangedEventArgs e, TextBox textBox1)
        {
            Numb = Convert.ToInt32(textBox1.Text);
        }
    }
}
