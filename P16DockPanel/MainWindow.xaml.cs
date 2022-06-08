using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace P16DockPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            WebClient wc = new WebClient();

            string url = "http://tomaszles.pl/wp-content/uploads/2019/06/zawodnicy.txt";
            string dane = wc.DownloadString(url);

            string[] wiersze =
                dane.Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            lvDane.ItemsSource = wiersze;

             
        }
    }
}
