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
    /// Page1.xaml 的交互逻辑
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            this.text.Text = "没有对窗口尺寸进行配置";
        }

        public Page1(double width, double height, double hostwinWidth, double hostHeight):this()
        {
            this.Width = width;
            this.Height = height;
            this.WindowHeight = hostHeight;
            this.WindowWidth = hostwinWidth;

            this.WindowTitle = "对窗口尺寸进行了配置";
            this.text.Text = "Width= " + width +"\n\n"+ "Height= "+Height+"\n\n"+"WindowWidth= "+hostwinWidth+"\n\n"+"WindowHeight= "+hostHeight;
        }
    }
}
