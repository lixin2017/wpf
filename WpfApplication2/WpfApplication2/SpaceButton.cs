using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApplication2
{
    public class SpaceButton:Button
    {
        private string txt;
        public string Text
        {
            set 
            { 
                txt = value;
                Content = SpaceoutText(txt);
            }
            get
            {
                return txt;
            }
        }

        public static readonly DependencyProperty SpaceProperty;

        public int Space
        {
            set
            {
                SetValue(SpaceProperty, value);
            }
            get
            {
                return (int)GetValue(SpaceProperty);
            }
        }

        static SpaceButton()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.DefaultValue = 0;
            metadata.PropertyChangedCallback += OnSpacePropertyChanged;

            //注册依赖属性
            SpaceProperty = DependencyProperty.Register("Space", typeof(int), typeof(SpaceButton), metadata, ValidateSpaceValue);
        }

        private static bool ValidateSpaceValue(object value)
        {
            int i = (int)value;
            return i >= 0;
        }

        private static void OnSpacePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            SpaceButton btn = d as SpaceButton;
            string txt = btn.Content as string;
            if (txt == null)
                return;
            btn.Content = btn.SpaceoutText(txt);
        }

        public string SpaceoutText(string txt)
        {
            if (txt == null)
                return null;
            StringBuilder build = new StringBuilder();
            foreach (char ch in txt)
            {
                build.Append(ch + new string(' ', Space));
            }
            return build.ToString();
        }
    }
}
