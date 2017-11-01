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

namespace WpfApplication2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _oldFontSize = FontSize;
        }

        private double _oldFontSize;

        private void FontSizeWinBtn_Click(object sender, RoutedEventArgs e)
        {
            FontSize = 16;
        }

        private void FontSizeBtn_Click(object sender, RoutedEventArgs e)
        {
            this.FontSizeBtn.FontSize = 8;
        }

        private void ResetFontSizeBtn_Click(object sender, RoutedEventArgs e)
        {
            FontSize = _oldFontSize;
            this.FontSizeBtn.FontSize = _oldFontSize;
        }

        private void btnSpace_Click(object sender, RoutedEventArgs e)
        {
            this.btnSpace.Space = 2;
        }

        private void winSpace_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
