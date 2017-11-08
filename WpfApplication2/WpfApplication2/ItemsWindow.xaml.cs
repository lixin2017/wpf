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
    /// ItemsWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ItemsWindow : Window
    {
        public ItemsWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (e.OriginalSource is RadioButton button)
            {
                string str = button.Content.ToString();
                switch (str)
                {
                    case "Single": this.Lb.SelectionMode = SelectionMode.Single;
                        break;
                    case "Multiple":
                        this.Lb.SelectionMode = SelectionMode.Multiple;
                        break;
                    case "Extended":
                        this.Lb.SelectionMode = SelectionMode.Extended;
                        break;

                }
            }
        }
    }
}
