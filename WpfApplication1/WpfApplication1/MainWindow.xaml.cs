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

namespace WpfApplication1
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
        int x = 0;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            String[] phrase = { "you are STINKY", "you are TROUBLE", "you are a PAIN", "you are a GROWDALOPE" };
            if (x == phrase.Count())
            {
                x = 0;
                this.txtblock.Text = "Hello " + this.txtbox.Text + ", " + phrase[x].ToString();
            }
            else
            {
                this.txtblock.Text = "Hello " + this.txtbox.Text + ", " + phrase[x].ToString();
                x++;
            }
        }
    }
}
