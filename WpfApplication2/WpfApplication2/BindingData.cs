using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    class BindingData
    {
        public BindingData() { ColorName = "Red"; }

        private string name = "Red";
        public string ColorName
        {
            get { return name; }
            set { name = value; }
        }
    }
}
