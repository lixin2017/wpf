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

namespace WpfApplication2
{
    /// <summary>
    /// Notepad.xaml 的交互逻辑
    /// </summary>
    public partial class Notepad : Window
    {
        private bool isdirty = false;
        public Notepad()
        {
            InitializeComponent();
        }

       

        private void CloseCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show(e.Source.ToString());
            App.Current.Shutdown();
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show(e.Source.ToString());
            isdirty = false;
        }

        private void SaveCanExecuted(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = isdirty;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            isdirty = true;
        }
    }
}
